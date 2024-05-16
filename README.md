# TinyMemFS

TinyMemFS is a lightweight, in-memory file system implemented in C#. It provides a simple yet powerful interface for managing files and directories in memory. This README serves as a guide to understand and use TinyMemFS effectively.

## Table of Contents

- [Introduction](#introduction)
- [Features](#features)
- [Usage](#usage)
- [Advanced Features](#advanced-features)
- [Contributing](#contributing)
- [License](#license)

## Introduction

TinyMemFS is designed to simulate a file system within the memory of a C# application. It allows you to create, read, update, and delete files, as well as perform various operations like encryption, compression, sorting, and more.

## Features

- **In-Memory File System:** Files are stored in memory, providing fast access and manipulation.
- **File Management:** Add, remove, list, save, and load files within the file system.
- **Encryption and Decryption:** Encrypt and decrypt file contents using a provided key.
- **Compression and Decompression:** Compress and decompress file data to reduce storage space.
- **Sorting:** Sort files by name, date, or size.
- **Hidden Files:** Mark files as hidden, preventing them from appearing in directory listings.
- **File Comparison:** Compare file contents for equality.
- **Size Calculation:** Calculate the total size of all files in the file system.

## Usage

### Basic Operations

```csharp
// Create a new TinyMemFS instance
TinyMemFS fs = new TinyMemFS();

// Add a file to the file system
fs.add("file1.txt", "C:\\path\\to\\file.txt");

// Remove a file from the file system
fs.remove("file1.txt");

// List files in the file system
List<string> files = fs.listFiles();
foreach (string file in files)
{
    Console.WriteLine(file);
}

// Save a file from the file system to disk
fs.save("file1.txt", "C:\\path\\to\\save\\file.txt");

// Encrypt and decrypt files
fs.encrypt("myKey");
fs.decrypt("myKey");
```

### Advanced Operations

```csharp
// Sort files by name, date, or size
fs.sortByName();
fs.sortByDate();
fs.sortBySize();

// Compare two files
bool isEqual = fs.compare("file1.txt", "file2.txt");

// Get the total size of all files in the file system
long totalSize = fs.getSize();
```

## Advanced Features

### Saving and Loading

```csharp
// Save the entire file system to a single file
fs.saveToDisk("myFS.dat");

// Load a saved file system from a file
fs.loadFromDisk("myFS.dat");
```

### Compression and Decompression

```csharp
// Compress a file
fs.compressFile("file1.txt");

// Decompress a file
fs.uncompressFile("file1.txt");
```

### Hidden Files

```csharp
// Set a file as hidden
fs.setHidden("file1.txt", true);
```

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
