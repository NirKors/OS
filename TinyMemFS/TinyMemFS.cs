using System.IO.Compression;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;

class TinyMemFS
{
    private Dictionary<string, InternalFile> files;
    private byte sortSelection;
    private ReaderWriterLockSlim rwl; // ReaderWriterLockSlim allows us to classify methods as read \ write and allow access accordingly.

    public TinyMemFS()
    {
        // constructor
        files = new();
        sortSelection = 0;
        rwl = new();
    }

    public class InternalFile
    {
        public MemoryStream data;
        public DateTime creationTime;
        public bool hidden;
        public long size;
        public string name;
        public List<byte[]> vector;
        public InternalFile(string name, byte[] data)
        {
            creationTime = DateTime.Now;

            this.data = new MemoryStream();
            this.data.Write(data);
            this.name = name;
            hidden = false;
            size = data.Length;
            vector = new List<byte[]>();
        }

        public string display()
        {
            string messurement = "Bytes";
            long temp = size;
            if (temp > 1024)
            {
                temp /= 1024;
                messurement = "KB";
            }
            return $"File name: \"{name}\" | Original size: {temp} {messurement} | Creation time: {creationTime}";
        }
    }

    [Serializable]
    public class ExternalFile
    {
        public byte[] data;
        public string name;
        public DateTime creationTime;
        public bool hidden;
        public long size;
        public List<byte[]> vector;
        public ExternalFile(InternalFile file)
        {
            data = file.data.ToArray();
            name = file.name;
            creationTime = file.creationTime;
            hidden = file.hidden;
            size = file.size;
            vector = file.vector;
        }

        public InternalFile ToInternal()
        {
            InternalFile file = new InternalFile(name, data);
            file.creationTime = creationTime;
            file.hidden = hidden;
            file.size = size;
            file.vector = vector;
            return file;

        }
    }

    public bool add(String fileName, String fileToAdd)
    {
        // fileName - The name of the file to be added to the file system
        // fileToAdd - The file path on the computer that we add to the system
        // return false if operation failed for any reason
        // Example:
        // add("name1.pdf", "C:\\Users\\user\Desktop\\report.pdf")
        // note that fileToAdd isn't the same as the fileName

        if (fileName == null || fileToAdd == null)
            return false;

        rwl.EnterUpgradeableReadLock();

        if (files.ContainsKey(fileName))
        {
            rwl.ExitUpgradeableReadLock();
            return false;
        }

        bool result = false;
        try
        {
            byte[] data = File.ReadAllBytes(fileToAdd);
            InternalFile file = new(fileName, data);
            rwl.EnterWriteLock();
            files.Add(fileName, file);
        }
        catch {}
        rwl.ExitUpgradeableReadLock();
        return result;
    }

    public bool remove(String fileName)
    {
        // fileName - remove fileName from the system
        // this operation releases all allocated memory for this file
        // return false if operation failed for any reason
        // Example:
        // remove("name1.pdf")

        if (fileName == null)
            return false;

        rwl.EnterWriteLock();
        bool result = files.Remove(fileName);
        rwl.ExitWriteLock();
        return result;
    }
    
    public List<String> listFiles()
    {
        // The function returns a list of strings with the file information in the system
        // Each string holds details of one file as following: "fileName,size,creation time"
        // Example:{
        // "report.pdf,630KB,Friday, ‎May ‎13, ‎2022, ‏‎12:16:32 PM",
        // "table1.csv,220KB,Monday, ‎February ‎14, ‎2022, ‏‎8:38:24 PM" }
        // You can use any format for the creation time and date

        rwl.EnterReadLock();
        List<InternalFile> todisplay = new(files.Values.ToArray());
        rwl.ExitReadLock();
        switch (sortSelection)
        {
            case 1: // Name
                todisplay.Sort((file1, file2) => file1.name.CompareTo(file2.name));
                break;
            case 2: // Date
                todisplay.Sort((file1, file2) => file1.creationTime.CompareTo(file2.creationTime));
                break;
            case 3: // Size
                todisplay.Sort((file1, file2) => file2.size.CompareTo(file1.size));
                break;
        }

        List<string> display = new();
        foreach (InternalFile file in todisplay)
        {
            if (!file.hidden)
            {
                display.Add(file.display());
            }
        }

        return display;
    }

    public bool save(String fileName, String fileToAdd)
    {
        // this function saves file from the TinyMemFS file system into a file in the physical disk
        // fileName - file name from TinyMemFS to save in the computer
        // fileToAdd - The file path to be saved on the computer
        // return false if operation failed for any reason
        // Example:
        // save("name1.pdf", "C:\\tmp\\fileName.pdf")
        if (fileToAdd == null || fileToAdd == null)
            return false;

        bool result = false;
        rwl.EnterReadLock();
        try
        {
            using (FileStream fs = File.Create(fileToAdd))
            {
                byte[] info = files[fileName].data.ToArray();
                fs.Write(info, 0, info.Length);
            }
            result = true;
        }
        catch{}

        rwl.ExitReadLock();
        return result;
    }

    public bool encrypt(String key)
    {
        // key - Encryption key to encrypt the contents of all files in the system 
        // You can use an encryption algorithm of your choice
        // return false if operation failed for any reason
        // Example:
        // encrypt("myFSpassword")

        if (key == null)
        {
            return false;
        }

        if (files.Count == 0)
        {
            return true;
        }

        Aes aes = Aes.Create();
        byte[] bytekey = Encoding.ASCII.GetBytes(key);

        try
        {
            aes.KeySize = bytekey.Length * 8;
            aes.Key = bytekey;
            aes.GenerateIV();
        }
        catch
        {
            return false;
        }
        rwl.EnterWriteLock();
        int counter = 0;
        foreach (InternalFile file in files.Values)
        {
            try
            {

                byte[] decrypted = EncryptData(file.data.ToArray(), aes);
                file.data = new MemoryStream();
                file.data.Write(decrypted);
                file.vector.Add(aes.IV);

                counter++;
            }
            catch { continue; }
        }
        rwl.ExitWriteLock();
        if (counter == 0)
            return false;

        return true;
    }

    private byte[] EncryptData(byte[] data, Aes aes)
    {

        ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);
        byte[] encrypted;

        // Create the streams used for encryption.
        using (MemoryStream msEncrypt = new MemoryStream())
        {
            using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
            {
                //Write all data to the stream.
                csEncrypt.Write(data);
            }
            encrypted = msEncrypt.ToArray();
        }
        return encrypted;
    }

    public bool decrypt(String key)
    {
        // fileName - Decryption key to decrypt the contents of all files in the system 
        // return false if operation failed for any reason
        // Example:
        // decrypt("myFSpassword")

        if (key == null)
        {
            return false;
        }

        if (files.Count == 0)
        {
            return true;
        }


        Aes aes = Aes.Create();
        byte[] bytekey = Encoding.ASCII.GetBytes(key);

        try
        {
            aes.KeySize = bytekey.Length * 8;
            aes.Key = bytekey;
        }
        catch
        {
            return false;
        }
        int counter = 0;
        rwl.EnterWriteLock();
        foreach (InternalFile file in files.Values)
        {
            try
            {
                aes.IV = file.vector.Last();
                byte[] decrypted = DecryptData(file.data.ToArray(), aes);
                file.data = new MemoryStream();
                file.data.Write(decrypted);
                counter++;
                file.vector.RemoveAt(file.vector.Count - 1);
            }
            catch { continue; }
        }
        rwl.ExitWriteLock();
        if (counter == 0)
            return false;

        return true;
    }

    private byte[] DecryptData(byte[] data, Aes aes)
    {

        ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);
        byte[] decrypted;

        // Create the streams used for encryption.
        using (MemoryStream msEncrypt = new MemoryStream())
        {
            using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, decryptor, CryptoStreamMode.Write))
            {
                //Write all data to the stream.
                csEncrypt.Write(data);
            }
            decrypted = msEncrypt.ToArray();
        }
        return decrypted;
    }


    // ************** NOT MANDATORY ********************************************
    // ********** Extended features of TinyMemFS ********************************
    public bool saveToDisk(String fileName)
    {
        /*
         * Save the FS to a single file in disk
         * return false if operation failed for any reason
         * You should store the entire FS (metadata and files) from memory to a single file.
         * You can decide how to save the FS in a single file (format, etc.) 
         * Example:
         * SaveToDisk("MYTINYFS.DAT")
         */

        if (fileName == null)
        {
            return false;
        }

        try
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None);

            ExternalFile[] eFiles = new ExternalFile[files.Count];
            InternalFile[] eFiles2 = files.Values.ToArray();
            for (int i = 0; i < files.Count; i++)
            {
                eFiles[i] = new ExternalFile(eFiles2[i]);
            }

            formatter.Serialize(stream, eFiles);
            stream.Close();
            return true;

        }
        catch { return false; }
    }

    public bool loadFromDisk(String fileName)
    {
        /*
         * Load a saved FS from a file  
         * return false if operation failed for any reason
         * You should clear all the files in the current TinyMemFS if exist, before loading the filenName
         * Example:
         * LoadFromDisk("MYTINYFS.DAT")
         */

        if (fileName == null)
        {
            return false;
        }
        bool result = false;
        try
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read);
            ExternalFile[] eFiles = (ExternalFile[])formatter.Deserialize(stream);
            stream.Close();

            rwl.EnterWriteLock();

            files.Clear();
            foreach (ExternalFile file in eFiles)
            {
                files.Add(file.name, file.ToInternal());
            }

            result = true;
        }
        catch {}
        rwl.ExitWriteLock();
        return result;

    }

    public bool compressFile(String fileName)
    {
        /* Compress file fileName
         * return false if operation failed for any reason
         * You can use an compression/uncompression algorithm of your choice
         * Note that the file size might be changed due to this operation, update it accordingly
         * Example:
         * compressFile ("name1.pdf");
         */

        bool result = false;
        rwl.EnterWriteLock();
        try
        {
            InternalFile file = files[fileName];
            byte[] compressed = Compress(file.data.ToArray());
            file.data = new();
            file.data.Write(compressed);
            file.size = compressed.Length;

            result = true;
        }
        catch {}
        rwl.ExitWriteLock();
        return result;
    }

    public bool uncompressFile(String fileName)
    {
        /* uncompress file fileName
         * return false if operation failed for any reason
         * You can use an compression/uncompression algorithm of your choice
         * Note that the file size might be changed due to this operation, update it accordingly
         * Example:
         * uncompressFile ("name1.pdf");
         */

        bool result = false;
        rwl.EnterWriteLock();
        try
        {
            InternalFile file = files[fileName];
            byte[] decompressed = Decompress(file.data.ToArray());
            file.data = new();
            file.data.Write(decompressed);
            file.size = decompressed.Length;

            result = true;
        }
        catch { }
        rwl.ExitWriteLock();
        return result;
    }

    public static byte[] Compress(byte[] data)
    {

        MemoryStream output = new MemoryStream();
        using (DeflateStream dstream = new DeflateStream(output, CompressionLevel.Optimal))
        {
            dstream.Write(data, 0, data.Length);
        }
        return output.ToArray();
    }

    public static byte[] Decompress(byte[] data)
    {
        MemoryStream input = new MemoryStream(data);
        MemoryStream output = new MemoryStream();
        using (DeflateStream dstream = new DeflateStream(input, CompressionMode.Decompress))
        {
            dstream.CopyTo(output);
        }
        return output.ToArray();
    }

    public bool setHidden(String fileName, bool hidden)
    {
        /* set the hidden property of fileName
         * If file is hidden, it will not appear in the listFiles() results
         * return false if operation failed for any reason
         * Example:
         * setHidden ("name1.pdf", true);
         */

        if (fileName == null)
            return false;

        bool result = false;
        rwl.EnterWriteLock();
        try
        {
            files[fileName].hidden = hidden;
            result = true;
        }
        catch {}
        rwl.ExitWriteLock();
        return result;
    }

    public bool rename(String fileName, string newFileName)
    {
        /* Rename filename to newFileName
         * Return false if operation failed for any reason (E.g., newFileName already exists)
         * Example:
         * rename ("name1.pdf", "name2.pdf");
         */

        if (fileName == null || newFileName == null)
            return false;

        if (fileName == newFileName)
            return true;

        rwl.EnterUpgradeableReadLock();

        if (files.ContainsKey(newFileName) || !files.ContainsKey(fileName))
        {
            rwl.ExitUpgradeableReadLock();
            return false;
        }

        rwl.EnterWriteLock();

        InternalFile file = files[fileName];
        file.name = newFileName;
        files.Add(newFileName, file);
        files.Remove(fileName);

        rwl.ExitUpgradeableReadLock();
        return true;
    }

    public bool copy(String fileName1, string fileName2)
    {
        /* Rename filename1 to a new filename2
         * Return false if operation failed for any reason (E.g., fileName1 doesn't exist or filename2 already exists)
         * Example:
         * rename ("name1.pdf", "name2.pdf");
         */

        if (fileName1 == null || fileName2 == null || fileName1 == fileName2)
            return false;

        rwl.EnterUpgradeableReadLock();

        if (files.ContainsKey(fileName2) || !files.ContainsKey(fileName1))
        {
            rwl.ExitUpgradeableReadLock();
            return false;
        }

        rwl.EnterWriteLock();

        InternalFile copyfrom = files[fileName1];
        copyfrom.name = fileName2;
        files.Add(fileName2, copyfrom);

        rwl.ExitUpgradeableReadLock();
        return true;
    }

    public void sortByName()
    {
        /* Sort the files in the FS by their names (alphabetical order)
         * This should affect the order the files appear in the listFiles 
         * if two names are equal you can sort them arbitrarily
         */
        sortSelection = 1;
    }

    public void sortByDate()
    {
        /* Sort the files in the FS by their date (new to old)
         * This should affect the order the files appear in the listFiles  
         * if two dates are equal you can sort them arbitrarily
         */
        sortSelection = 2;
    }

    public void sortBySize()
    {
        /* Sort the files in the FS by their sizes (large to small)
         * This should affect the order the files appear in the listFiles  
         * if two sizes are equal you can sort them arbitrarily
         */

        sortSelection = 3;
    }

    public bool compare(String fileName1, String fileName2)
    {
        /* compare fileName1 and fileName2
         * files considered equal if their content is equal 
         * Return false if the two files are not equal, or if operation failed for any reason (E.g., fileName1 or fileName2 not exist)
         * Example:
         * compare ("name1.pdf", "name2.pdf");
         */

        if (fileName1 == null || fileName2 == null)
        {
            return false;
        }

        if (fileName1 == fileName2)
            return true;

        bool result = false;
        rwl.EnterReadLock();
        try
        {
            result = files[fileName1].data == files[fileName2].data;
        }
        catch (Exception)
        {}
        rwl.ExitReadLock();
        return result;
    }

    public Int64 getSize()
    {
        /* return the size of all files in the FS (sum of all sizes)
         */


        long size = 0;
        rwl.EnterReadLock();
        foreach (InternalFile file in files.Values)
        {
            size += file.size;
        }
        rwl.ExitReadLock();

        return size;
    }
}