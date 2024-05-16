namespace TinyMemFS_CHANGENAME
{
    public partial class Form1 : Form
    {
        TinyMemFS FS = new TinyMemFS();

        class ColorizedText
        {
            public string Text;
            public Color Color;
        }

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            reSize();
            listBox1.DrawMode = DrawMode.OwnerDrawFixed;
            listBox1.ItemHeight = 18;

        }

        private void listBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            ColorizedText item = null;
            if (e.Index >= 0)
            {
                item = listBox1.Items[e.Index] as ColorizedText;
            }

            if (item != null)
            {
                e.Graphics.DrawString(
                    item.Text,
                    e.Font,
                    new SolidBrush(item.Color),
                    e.Bounds);
            }

        }

        private static DialogResult NewDialogBox(string title, ref string input1, ref string input2, bool singleButton = false)
        {
            Size size;
            if (!singleButton)
            {
                size = new Size(300, 170);
            }
            else
            {
                size = new Size(300, 100);
            }

            Form inputBox = new Form();

            inputBox.FormBorderStyle = FormBorderStyle.FixedDialog;
            inputBox.ClientSize = size;
            inputBox.Text = title;
            inputBox.StartPosition = FormStartPosition.CenterScreen;

            Label label1 = new Label();
            label1.Text = $"{input1}:";
            label1.Location = new Point(5, 5);
            label1.Width = size.Width - 10;
            inputBox.Controls.Add(label1);

            TextBox textBox1 = new TextBox();
            textBox1.Size = new Size(size.Width - 10, 23);
            textBox1.Location = new Point(5, label1.Location.Y + 20);
            textBox1.Text = $"Enter the {input1}...";
            inputBox.Controls.Add(textBox1);

            Label label2;
            TextBox textBox2 = null;
            if (!singleButton)
            {
                label2 = new Label();
                label2.Text = $"{input2}:";
                label2.Location = new Point(5, 55);
                label2.Width = size.Width - 10;
                inputBox.Controls.Add(label2);

                textBox2 = new TextBox();
                textBox2.Size = new Size(size.Width - 10, 23);
                textBox2.Location = new Point(5, label2.Location.Y + 20);
                textBox2.Text = $"Enter the {input2}...";
                inputBox.Controls.Add(textBox2);
            }



            Button okButton = new Button();
            okButton.DialogResult = DialogResult.OK;
            okButton.Name = "okButton";
            okButton.Size = new Size(75, 23);
            okButton.Text = "&OK";
            okButton.Location = new Point(size.Width - 80 - 80, size.Height - 30);
            inputBox.Controls.Add(okButton);

            Button cancelButton = new Button();
            cancelButton.DialogResult = DialogResult.Cancel;
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.Text = "&Cancel";
            cancelButton.Location = new Point(size.Width - 80, size.Height - 30);
            inputBox.Controls.Add(cancelButton);

            inputBox.AcceptButton = okButton;
            inputBox.CancelButton = cancelButton;

            DialogResult result = inputBox.ShowDialog();
            input1 = textBox1.Text;
            if (!singleButton)
            {
                input2 = textBox2.Text;
            }

            return result;
        }

        private void UpdateList(string msg, bool error = false)
        {
            DateTime dateTime = DateTime.Now;
            ColorizedText newitem = new ColorizedText();
            newitem.Text = $"[{dateTime}]: {msg}";
            newitem.Color = error ? Color.Red : Color.Black;

            listBox1.Items.Add(newitem);
            listBox1.TopIndex = listBox1.Items.Count - 1;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string filename = "File name";
            string fileToAdd = "File path";
            if (NewDialogBox("Add file to FS", ref filename, ref fileToAdd) == DialogResult.OK)
            {
                if (FS.add(filename, fileToAdd))
                {
                    UpdateList($"Added file \"{filename}\".");
                }
                else
                {
                    UpdateList($"Failed to add file \"{filename}\".", true);
                }
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            string filename = "File name";
            string _ = "";
            if (NewDialogBox("Remove file to FS", ref filename, ref _, true) == DialogResult.OK)
            {
                if (FS.remove(filename))
                {
                    UpdateList($"File \"{filename}\" removed successfuly.");
                }
                else
                {
                    UpdateList($"Unable to find file \"{filename}\".", true);
                }
            }
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            List<string> allFiles = FS.listFiles();
            foreach (string file in allFiles)
            {
                textBox1.Text += file + "\r\n";
            }

            UpdateList($"Displaying {allFiles.Count} file{(allFiles.Count == 1 ? "" : "s")}.");
        }

        private void saveToDiskButton_Click(object sender, EventArgs e)
        {
            string filename = "File name";
            string fileToAdd = "File path";
            if (NewDialogBox("Save file from FS to disk", ref filename, ref fileToAdd) == DialogResult.OK)
            {
                if (FS.save(filename, fileToAdd))
                {
                    UpdateList($"File \"{filename}\" saved to \"{fileToAdd}\" successfully.");
                }
                else
                {
                    UpdateList($"Unable to save file to disk.", true);
                }
            }
        }

        private void encryptButton_Click(object sender, EventArgs e)
        {
            string key = "Key";
            string _ = "";
            if (NewDialogBox("Encrypt files", ref key, ref _, true) == DialogResult.OK)
            {
                if (!(key.Length == 16 || key.Length == 24 || key.Length == 32))
                {
                    UpdateList("Length of key has to be 16/24/32 characters.", true);
                }
                else if (FS.encrypt(key))
                {
                    UpdateList($"Files encrypted successfully.");
                }
                else
                {
                    UpdateList($"Unable to encrypt files with given key.", true);
                }
            }
        }

        private void decryptButton_Click(object sender, EventArgs e)
        {
            string key = "Key";
            string _ = "";
            if (NewDialogBox("Decrypt files", ref key, ref _, true) == DialogResult.OK)
            {
                if (!(key.Length != 16 || key.Length != 24 || key.Length != 32))
                {
                    UpdateList("Length of key has to be 16/24/32 characters.", true);
                }
                else if (FS.decrypt(key))
                {
                    UpdateList($"Files decrypted with the given key successfully.");
                }
                else
                {
                    UpdateList($"Unable to decrypt files with the given key.", true);
                }
            }
        }

        private void compressButton_Click(object sender, EventArgs e)
        {
            string fileName = "File name...";
            string _ = "";

            if (NewDialogBox("Compress file", ref fileName, ref _, true) == DialogResult.OK)
            {
                if (FS.compressFile(fileName))
                {
                    UpdateList($"Compressed \"{fileName}\" successfully.");
                }
                else
                {
                    UpdateList($"Unable to compress \"{fileName}\".", true);
                }
            }
        }

        private void decompressButton_Click(object sender, EventArgs e)
        {
            string fileName = "File name...";
            string _ = "";

            if (NewDialogBox("Compress file", ref fileName, ref _, true) == DialogResult.OK)
            {
                if (FS.uncompressFile(fileName))
                {
                    UpdateList($"Decompressed \"{fileName}\" successfully.");
                }
                else
                {
                    UpdateList($"Unable to decompress \"{fileName}\".", true);
                }
            }
        }

        private void leaveCursor(object sender, EventArgs e)
        {
            reSize();
        }
        private void reSize()
        {
            pictureBoxAdd.Size = new Size(50, 50);
            pictureBoxAdd.Location = new Point(addButton.Location.X + 60, addButton.Location.Y + 20);

            pictureBoxRemove.Size = new Size(50, 50);
            pictureBoxRemove.Location = new Point(removeButton.Location.X + 60, removeButton.Location.Y + 20);

            pictureBoxList.Size = new Size(50, 50);
            pictureBoxList.Location = new Point(returnButton.Location.X + 60, returnButton.Location.Y + 20);

            pictureBoxSave.Size = new Size(50, 50);
            pictureBoxSave.Location = new Point(saveToDiskButton.Location.X + 60, saveToDiskButton.Location.Y + 20);

            pictureBoxEncrypt.Size = new Size(50, 50);
            pictureBoxEncrypt.Location = new Point(encryptButton.Location.X + 60, encryptButton.Location.Y + 20);

            pictureBoxDecrypt.Size = new Size(50, 50);
            pictureBoxDecrypt.Location = new Point(decryptButton.Location.X + 60, decryptButton.Location.Y + 20);
        }
        private void enlarge(PictureBox p)
        {
            p.Size = new Size(70, 70);
            p.Location = new Point(p.Location.X - 10, p.Location.Y - 10);
        }
        private void enter1(object sender, EventArgs e)
        {
            reSize();
            enlarge(pictureBoxAdd);
        }
        private void enter2(object sender, EventArgs e)
        {
            reSize();
            enlarge(pictureBoxRemove);
        }
        private void enter3(object sender, EventArgs e)
        {
            reSize();
            enlarge(pictureBoxList);
        }
        private void enter4(object sender, EventArgs e)
        {
            reSize();
            enlarge(pictureBoxSave);
        }
        private void enter5(object sender, EventArgs e)
        {
            reSize();
            enlarge(pictureBoxEncrypt);
        }
        private void enter6(object sender, EventArgs e)
        {
            reSize();
            enlarge(pictureBoxDecrypt);
        }


        private void saveAllToDisk_Click(object sender, EventArgs e)
        {
            string fileName = "File path";
            string _ = "";
            if (NewDialogBox("Save FS to disk", ref fileName, ref _, true) == DialogResult.OK)
            {
                if (FS.saveToDisk(fileName))
                {
                    UpdateList($"Saved FS to \"{fileName}\"");
                }
                else
                {
                    UpdateList("Can't save FS to given path.", true);
                }
            }
        }

        private void loadAllToDisk_Click(object sender, EventArgs e)
        {
            string filePath = "File path";
            string _ = "";
            if (NewDialogBox("Load FS from disk", ref filePath, ref _, true) == DialogResult.OK)
            {
                if (FS.loadFromDisk(filePath))
                {
                    UpdateList("FS loaded successfully.");
                }
                else
                {
                    UpdateList("Can't load FS from given path.", true);
                }
            }
        }

        private void compressFileButton_Click(object sender, EventArgs e)
        {
            string fileName = "File name";
            string _ = "";
            if (NewDialogBox("Compress file", ref fileName, ref _, true) == DialogResult.OK)
            {
                if (FS.compressFile(fileName))
                {
                    UpdateList($"File \"{fileName}\" compressed successfully.");
                }
                else
                {
                    UpdateList($"Can't compress \"{fileName}\".", true);
                }
            }
        }

        private void uncompressFileButton_Click(object sender, EventArgs e)
        {
            string fileName = "File name";
            string _ = "";
            if (NewDialogBox("Decompress file", ref fileName, ref _, true) == DialogResult.OK)
            {
                if (FS.uncompressFile(fileName))
                {
                    UpdateList($"File \"{fileName}\" decompressed successfully.");
                }
                else
                {
                    UpdateList($"Can't decompress \"{fileName}\".", true);
                }
            }
        }

        private void setHiddenButton_Click(object sender, EventArgs e)
        {
            string fileName = "File name";
            bool result = false;
            if (NewDialogBoxCheck("Set file hidden", ref fileName, ref result) == DialogResult.OK)
            {
                if (FS.setHidden(fileName, result))
                {
                    UpdateList($"File \"{fileName}\" set to {(result ? "hidden" : "visible")} successfully.");
                }
                else
                {
                    UpdateList($"Unable to set \"{fileName}\" to {(result ? "hidden" : "visible")}.", true);
                }
            }
        }

        private static DialogResult NewDialogBoxCheck(string title, ref string input1, ref bool input2)
        {
            Size size;
            size = new Size(300, 130);
            Form inputBox = new Form();

            inputBox.FormBorderStyle = FormBorderStyle.FixedDialog;
            inputBox.ClientSize = size;
            inputBox.Text = title;
            inputBox.StartPosition = FormStartPosition.CenterScreen;

            Label label1 = new Label();
            label1.Text = $"{input1}:";
            label1.Location = new Point(5, 5);
            label1.Width = size.Width - 10;
            inputBox.Controls.Add(label1);

            TextBox textBox1 = new TextBox();
            textBox1.Size = new Size(size.Width - 10, 23);
            textBox1.Location = new Point(5, label1.Location.Y + 20);
            textBox1.Text = $"Enter the {input1}...";
            inputBox.Controls.Add(textBox1);

            Label label2 = new Label();
            label2.Text = $"Set file to hidden";
            label2.Location = new Point(5, textBox1.Location.Y + 30);
            label2.AutoSize = true;


            inputBox.Controls.Add(label2);

            CheckBox checkBox = new CheckBox();
            checkBox.Location = new Point(label2.Width + 10, label2.Location.Y - 3);
            checkBox.Checked = false;

            inputBox.Controls.Add(checkBox);

            Button okButton = new Button();
            okButton.DialogResult = DialogResult.OK;
            okButton.Name = "okButton";
            okButton.Size = new Size(75, 23);
            okButton.Text = "&OK";
            okButton.Location = new Point(size.Width - 80 - 80, size.Height - 30);
            inputBox.Controls.Add(okButton);

            Button cancelButton = new Button();
            cancelButton.DialogResult = DialogResult.Cancel;
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.Text = "&Cancel";
            cancelButton.Location = new Point(size.Width - 80, size.Height - 30);
            inputBox.Controls.Add(cancelButton);

            inputBox.AcceptButton = okButton;
            inputBox.CancelButton = cancelButton;

            DialogResult result = inputBox.ShowDialog();


            input1 = textBox1.Text;
            input2 = checkBox.Checked;


            return result;
        }

        private void renameButton_Click(object sender, EventArgs e)
        {
            string filename = "File name";
            string newFileName = "New file name";
            if (NewDialogBox("Rename file", ref filename, ref newFileName) == DialogResult.OK)
            {
                if (FS.rename(filename, newFileName))
                {
                    UpdateList($"Renamed \"{filename}\" to \"{newFileName}\".");
                }
                else
                {
                    UpdateList($"Unable to rename \"{filename}\".", true);
                }
            }
        }

        private void sortNameButton_Click(object sender, EventArgs e)
        {
            FS.sortByName();
            UpdateList("Files will now be sorted by name (alphabetical order).");

            returnButton_Click(sender, e);
        }

        private void sortDateButton_Click(object sender, EventArgs e)
        {
            FS.sortByDate();
            UpdateList("Files will now be sorted by date (new to old).");
            returnButton_Click(sender, e);
        }

        private void sortSizeButton_Click(object sender, EventArgs e)
        {
            FS.sortBySize();
            UpdateList("Files will now be sorted by size (large to small).");
            returnButton_Click(sender, e);
        }

        private void compareButton_Click(object sender, EventArgs e)
        {
            string filename = "File1 name";
            string newFileName = "File2 name";
            if (NewDialogBox("Compare files", ref filename, ref newFileName) == DialogResult.OK)
            {
                if (FS.compare(filename, newFileName))
                {
                    UpdateList($"\"{filename}\" is equal to \"{newFileName}\".");
                }
                else
                {
                    UpdateList($"\"{filename}\" is not equal to \"{newFileName}\".", true);
                }
            }
        }

        private void sizeButton_Click(object sender, EventArgs e)
        {
            long size = FS.getSize();
            if (size > 1024)
            {
                UpdateList($"Size of stored files: {size / 1024} KB.");
            }
            else
            {
                UpdateList($"Size of stored files: {size} bytes.");
            }
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            string filename = "Name of file to copy from";
            string newFileName = "Name of file to create";
            if (NewDialogBox("Copy to new file", ref filename, ref newFileName) == DialogResult.OK)
            {
                if (FS.copy(filename, newFileName))
                {
                    UpdateList($"Copied \"{filename}\" to \"{newFileName}\".");
                }
                else
                {
                    UpdateList($"Unable to copy.", true);
                }
            }
        }
    }
}