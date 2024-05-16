namespace TinyMemFS_CHANGENAME
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
            this.saveToDiskButton = new System.Windows.Forms.Button();
            this.encryptButton = new System.Windows.Forms.Button();
            this.decryptButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxDecrypt = new System.Windows.Forms.PictureBox();
            this.pictureBoxEncrypt = new System.Windows.Forms.PictureBox();
            this.pictureBoxSave = new System.Windows.Forms.PictureBox();
            this.pictureBoxList = new System.Windows.Forms.PictureBox();
            this.pictureBoxRemove = new System.Windows.Forms.PictureBox();
            this.pictureBoxAdd = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.saveAllToDisk = new System.Windows.Forms.Button();
            this.loadAllToDisk = new System.Windows.Forms.Button();
            this.compressFileButton = new System.Windows.Forms.Button();
            this.uncompressFileButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.sortNameButton = new System.Windows.Forms.Button();
            this.copyButton = new System.Windows.Forms.Button();
            this.renameButton = new System.Windows.Forms.Button();
            this.setHiddenButton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.sizeButton = new System.Windows.Forms.Button();
            this.compareButton = new System.Windows.Forms.Button();
            this.sortSizeButton = new System.Windows.Forms.Button();
            this.sortDateButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDecrypt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEncrypt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRemove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdd)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.addButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.addButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addButton.ForeColor = System.Drawing.Color.Transparent;
            this.addButton.Location = new System.Drawing.Point(15, 26);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(170, 100);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Add file to FS";
            this.addButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            this.addButton.MouseEnter += new System.EventHandler(this.enter1);
            // 
            // removeButton
            // 
            this.removeButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.removeButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.removeButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.removeButton.ForeColor = System.Drawing.Color.Transparent;
            this.removeButton.Location = new System.Drawing.Point(15, 126);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(170, 100);
            this.removeButton.TabIndex = 1;
            this.removeButton.Text = "Remove file from FS";
            this.removeButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.removeButton.UseVisualStyleBackColor = false;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            this.removeButton.MouseEnter += new System.EventHandler(this.enter2);
            // 
            // returnButton
            // 
            this.returnButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.returnButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.returnButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.returnButton.ForeColor = System.Drawing.Color.Transparent;
            this.returnButton.Location = new System.Drawing.Point(15, 226);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(170, 100);
            this.returnButton.TabIndex = 2;
            this.returnButton.Text = "List files in the FS";
            this.returnButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.returnButton.UseVisualStyleBackColor = false;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            this.returnButton.MouseEnter += new System.EventHandler(this.enter3);
            // 
            // saveToDiskButton
            // 
            this.saveToDiskButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.saveToDiskButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.saveToDiskButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.saveToDiskButton.ForeColor = System.Drawing.Color.Transparent;
            this.saveToDiskButton.Location = new System.Drawing.Point(15, 326);
            this.saveToDiskButton.Name = "saveToDiskButton";
            this.saveToDiskButton.Size = new System.Drawing.Size(170, 100);
            this.saveToDiskButton.TabIndex = 3;
            this.saveToDiskButton.Text = "Save file to disk";
            this.saveToDiskButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.saveToDiskButton.UseVisualStyleBackColor = false;
            this.saveToDiskButton.Click += new System.EventHandler(this.saveToDiskButton_Click);
            this.saveToDiskButton.MouseEnter += new System.EventHandler(this.enter4);
            // 
            // encryptButton
            // 
            this.encryptButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.encryptButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.encryptButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.encryptButton.ForeColor = System.Drawing.Color.Transparent;
            this.encryptButton.Location = new System.Drawing.Point(15, 426);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(170, 100);
            this.encryptButton.TabIndex = 4;
            this.encryptButton.Text = "Encrypt all files";
            this.encryptButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.encryptButton.UseVisualStyleBackColor = false;
            this.encryptButton.Click += new System.EventHandler(this.encryptButton_Click);
            this.encryptButton.MouseEnter += new System.EventHandler(this.enter5);
            // 
            // decryptButton
            // 
            this.decryptButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.decryptButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.decryptButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.decryptButton.ForeColor = System.Drawing.Color.Transparent;
            this.decryptButton.Location = new System.Drawing.Point(15, 526);
            this.decryptButton.Name = "decryptButton";
            this.decryptButton.Size = new System.Drawing.Size(170, 100);
            this.decryptButton.TabIndex = 5;
            this.decryptButton.Text = "Decrypt all files";
            this.decryptButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.decryptButton.UseVisualStyleBackColor = false;
            this.decryptButton.Click += new System.EventHandler(this.decryptButton_Click);
            this.decryptButton.MouseEnter += new System.EventHandler(this.enter6);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.pictureBoxDecrypt);
            this.panel1.Controls.Add(this.pictureBoxEncrypt);
            this.panel1.Controls.Add(this.pictureBoxSave);
            this.panel1.Controls.Add(this.pictureBoxList);
            this.panel1.Controls.Add(this.pictureBoxRemove);
            this.panel1.Controls.Add(this.pictureBoxAdd);
            this.panel1.Controls.Add(this.addButton);
            this.panel1.Controls.Add(this.removeButton);
            this.panel1.Controls.Add(this.returnButton);
            this.panel1.Controls.Add(this.saveToDiskButton);
            this.panel1.Controls.Add(this.encryptButton);
            this.panel1.Controls.Add(this.decryptButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(30);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(15);
            this.panel1.Size = new System.Drawing.Size(200, 641);
            this.panel1.TabIndex = 6;
            this.panel1.MouseEnter += new System.EventHandler(this.leaveCursor);
            // 
            // pictureBoxDecrypt
            // 
            this.pictureBoxDecrypt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxDecrypt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxDecrypt.BackgroundImage")));
            this.pictureBoxDecrypt.Enabled = false;
            this.pictureBoxDecrypt.ErrorImage = null;
            this.pictureBoxDecrypt.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDecrypt.Image")));
            this.pictureBoxDecrypt.Location = new System.Drawing.Point(78, 532);
            this.pictureBoxDecrypt.Name = "pictureBoxDecrypt";
            this.pictureBoxDecrypt.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxDecrypt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDecrypt.TabIndex = 11;
            this.pictureBoxDecrypt.TabStop = false;
            // 
            // pictureBoxEncrypt
            // 
            this.pictureBoxEncrypt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxEncrypt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxEncrypt.BackgroundImage")));
            this.pictureBoxEncrypt.Enabled = false;
            this.pictureBoxEncrypt.ErrorImage = null;
            this.pictureBoxEncrypt.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxEncrypt.Image")));
            this.pictureBoxEncrypt.Location = new System.Drawing.Point(78, 448);
            this.pictureBoxEncrypt.Name = "pictureBoxEncrypt";
            this.pictureBoxEncrypt.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxEncrypt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEncrypt.TabIndex = 10;
            this.pictureBoxEncrypt.TabStop = false;
            // 
            // pictureBoxSave
            // 
            this.pictureBoxSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxSave.BackgroundImage")));
            this.pictureBoxSave.Enabled = false;
            this.pictureBoxSave.ErrorImage = null;
            this.pictureBoxSave.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSave.Image")));
            this.pictureBoxSave.Location = new System.Drawing.Point(78, 344);
            this.pictureBoxSave.Name = "pictureBoxSave";
            this.pictureBoxSave.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSave.TabIndex = 9;
            this.pictureBoxSave.TabStop = false;
            // 
            // pictureBoxList
            // 
            this.pictureBoxList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxList.Enabled = false;
            this.pictureBoxList.ErrorImage = null;
            this.pictureBoxList.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxList.Image")));
            this.pictureBoxList.Location = new System.Drawing.Point(78, 242);
            this.pictureBoxList.Name = "pictureBoxList";
            this.pictureBoxList.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxList.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxList.TabIndex = 8;
            this.pictureBoxList.TabStop = false;
            // 
            // pictureBoxRemove
            // 
            this.pictureBoxRemove.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxRemove.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxRemove.BackgroundImage")));
            this.pictureBoxRemove.Enabled = false;
            this.pictureBoxRemove.ErrorImage = null;
            this.pictureBoxRemove.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRemove.Image")));
            this.pictureBoxRemove.Location = new System.Drawing.Point(78, 144);
            this.pictureBoxRemove.Name = "pictureBoxRemove";
            this.pictureBoxRemove.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxRemove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRemove.TabIndex = 7;
            this.pictureBoxRemove.TabStop = false;
            // 
            // pictureBoxAdd
            // 
            this.pictureBoxAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxAdd.BackgroundImage")));
            this.pictureBoxAdd.Enabled = false;
            this.pictureBoxAdd.ErrorImage = null;
            this.pictureBoxAdd.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAdd.Image")));
            this.pictureBoxAdd.Location = new System.Drawing.Point(78, 42);
            this.pictureBoxAdd.Name = "pictureBoxAdd";
            this.pictureBoxAdd.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAdd.TabIndex = 6;
            this.pictureBoxAdd.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalExtent = 100;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(205, 471);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox1.Size = new System.Drawing.Size(720, 184);
            this.listBox1.TabIndex = 7;
            this.listBox1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBox1_DrawItem);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(205, 448);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Log:";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(205, 32);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(720, 413);
            this.textBox1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(205, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "File List:";
            // 
            // saveAllToDisk
            // 
            this.saveAllToDisk.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.saveAllToDisk.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.saveAllToDisk.Dock = System.Windows.Forms.DockStyle.Left;
            this.saveAllToDisk.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.saveAllToDisk.ForeColor = System.Drawing.Color.Transparent;
            this.saveAllToDisk.Location = new System.Drawing.Point(5, 5);
            this.saveAllToDisk.Name = "saveAllToDisk";
            this.saveAllToDisk.Size = new System.Drawing.Size(226, 40);
            this.saveAllToDisk.TabIndex = 1;
            this.saveAllToDisk.Text = "Save FS to disk";
            this.saveAllToDisk.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.saveAllToDisk.UseVisualStyleBackColor = false;
            this.saveAllToDisk.Click += new System.EventHandler(this.saveAllToDisk_Click);
            // 
            // loadAllToDisk
            // 
            this.loadAllToDisk.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.loadAllToDisk.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.loadAllToDisk.Dock = System.Windows.Forms.DockStyle.Left;
            this.loadAllToDisk.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loadAllToDisk.ForeColor = System.Drawing.Color.Transparent;
            this.loadAllToDisk.Location = new System.Drawing.Point(231, 5);
            this.loadAllToDisk.Name = "loadAllToDisk";
            this.loadAllToDisk.Size = new System.Drawing.Size(226, 40);
            this.loadAllToDisk.TabIndex = 2;
            this.loadAllToDisk.Text = "Load FS to disk";
            this.loadAllToDisk.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.loadAllToDisk.UseVisualStyleBackColor = false;
            this.loadAllToDisk.Click += new System.EventHandler(this.loadAllToDisk_Click);
            // 
            // compressFileButton
            // 
            this.compressFileButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.compressFileButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.compressFileButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.compressFileButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.compressFileButton.ForeColor = System.Drawing.Color.Transparent;
            this.compressFileButton.Location = new System.Drawing.Point(457, 5);
            this.compressFileButton.Name = "compressFileButton";
            this.compressFileButton.Size = new System.Drawing.Size(226, 40);
            this.compressFileButton.TabIndex = 3;
            this.compressFileButton.Text = "Compress file";
            this.compressFileButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.compressFileButton.UseVisualStyleBackColor = false;
            this.compressFileButton.Click += new System.EventHandler(this.compressFileButton_Click);
            // 
            // uncompressFileButton
            // 
            this.uncompressFileButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.uncompressFileButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.uncompressFileButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.uncompressFileButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uncompressFileButton.ForeColor = System.Drawing.Color.Transparent;
            this.uncompressFileButton.Location = new System.Drawing.Point(683, 5);
            this.uncompressFileButton.Name = "uncompressFileButton";
            this.uncompressFileButton.Size = new System.Drawing.Size(226, 40);
            this.uncompressFileButton.TabIndex = 7;
            this.uncompressFileButton.Text = "Decompress file";
            this.uncompressFileButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.uncompressFileButton.UseVisualStyleBackColor = false;
            this.uncompressFileButton.Click += new System.EventHandler(this.uncompressFileButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.uncompressFileButton);
            this.panel2.Controls.Add(this.compressFileButton);
            this.panel2.Controls.Add(this.loadAllToDisk);
            this.panel2.Controls.Add(this.saveAllToDisk);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 3);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(921, 50);
            this.panel2.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.sortNameButton);
            this.panel3.Controls.Add(this.copyButton);
            this.panel3.Controls.Add(this.renameButton);
            this.panel3.Controls.Add(this.setHiddenButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 53);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(5);
            this.panel3.Size = new System.Drawing.Size(921, 50);
            this.panel3.TabIndex = 13;
            // 
            // sortNameButton
            // 
            this.sortNameButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sortNameButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.sortNameButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.sortNameButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sortNameButton.ForeColor = System.Drawing.Color.Transparent;
            this.sortNameButton.Location = new System.Drawing.Point(683, 5);
            this.sortNameButton.Name = "sortNameButton";
            this.sortNameButton.Size = new System.Drawing.Size(226, 40);
            this.sortNameButton.TabIndex = 7;
            this.sortNameButton.Text = "Sort by name";
            this.sortNameButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.sortNameButton.UseVisualStyleBackColor = false;
            this.sortNameButton.Click += new System.EventHandler(this.sortNameButton_Click);
            // 
            // copyButton
            // 
            this.copyButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.copyButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.copyButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.copyButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.copyButton.ForeColor = System.Drawing.Color.Transparent;
            this.copyButton.Location = new System.Drawing.Point(457, 5);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(226, 40);
            this.copyButton.TabIndex = 3;
            this.copyButton.Text = "Copy";
            this.copyButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.copyButton.UseVisualStyleBackColor = false;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // renameButton
            // 
            this.renameButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.renameButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.renameButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.renameButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.renameButton.ForeColor = System.Drawing.Color.Transparent;
            this.renameButton.Location = new System.Drawing.Point(231, 5);
            this.renameButton.Name = "renameButton";
            this.renameButton.Size = new System.Drawing.Size(226, 40);
            this.renameButton.TabIndex = 2;
            this.renameButton.Text = "Rename file";
            this.renameButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.renameButton.UseVisualStyleBackColor = false;
            this.renameButton.Click += new System.EventHandler(this.renameButton_Click);
            // 
            // setHiddenButton
            // 
            this.setHiddenButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.setHiddenButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.setHiddenButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.setHiddenButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.setHiddenButton.ForeColor = System.Drawing.Color.Transparent;
            this.setHiddenButton.Location = new System.Drawing.Point(5, 5);
            this.setHiddenButton.Name = "setHiddenButton";
            this.setHiddenButton.Size = new System.Drawing.Size(226, 40);
            this.setHiddenButton.TabIndex = 1;
            this.setHiddenButton.Text = "Set file hidden";
            this.setHiddenButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.setHiddenButton.UseVisualStyleBackColor = false;
            this.setHiddenButton.Click += new System.EventHandler(this.setHiddenButton_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.sizeButton);
            this.panel4.Controls.Add(this.compareButton);
            this.panel4.Controls.Add(this.sortSizeButton);
            this.panel4.Controls.Add(this.sortDateButton);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 103);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(5);
            this.panel4.Size = new System.Drawing.Size(921, 50);
            this.panel4.TabIndex = 13;
            // 
            // sizeButton
            // 
            this.sizeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sizeButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.sizeButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.sizeButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sizeButton.ForeColor = System.Drawing.Color.Transparent;
            this.sizeButton.Location = new System.Drawing.Point(683, 5);
            this.sizeButton.Name = "sizeButton";
            this.sizeButton.Size = new System.Drawing.Size(226, 40);
            this.sizeButton.TabIndex = 7;
            this.sizeButton.Text = "Get size";
            this.sizeButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.sizeButton.UseVisualStyleBackColor = false;
            this.sizeButton.Click += new System.EventHandler(this.sizeButton_Click);
            // 
            // compareButton
            // 
            this.compareButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.compareButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.compareButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.compareButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.compareButton.ForeColor = System.Drawing.Color.Transparent;
            this.compareButton.Location = new System.Drawing.Point(457, 5);
            this.compareButton.Name = "compareButton";
            this.compareButton.Size = new System.Drawing.Size(226, 40);
            this.compareButton.TabIndex = 3;
            this.compareButton.Text = "Compare";
            this.compareButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.compareButton.UseVisualStyleBackColor = false;
            this.compareButton.Click += new System.EventHandler(this.compareButton_Click);
            // 
            // sortSizeButton
            // 
            this.sortSizeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sortSizeButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.sortSizeButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.sortSizeButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sortSizeButton.ForeColor = System.Drawing.Color.Transparent;
            this.sortSizeButton.Location = new System.Drawing.Point(231, 5);
            this.sortSizeButton.Name = "sortSizeButton";
            this.sortSizeButton.Size = new System.Drawing.Size(226, 40);
            this.sortSizeButton.TabIndex = 2;
            this.sortSizeButton.Text = "Sort by size";
            this.sortSizeButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.sortSizeButton.UseVisualStyleBackColor = false;
            this.sortSizeButton.Click += new System.EventHandler(this.sortSizeButton_Click);
            // 
            // sortDateButton
            // 
            this.sortDateButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sortDateButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.sortDateButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.sortDateButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sortDateButton.ForeColor = System.Drawing.Color.Transparent;
            this.sortDateButton.Location = new System.Drawing.Point(5, 5);
            this.sortDateButton.Name = "sortDateButton";
            this.sortDateButton.Size = new System.Drawing.Size(226, 40);
            this.sortDateButton.TabIndex = 1;
            this.sortDateButton.Text = "Sort by date";
            this.sortDateButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.sortDateButton.UseVisualStyleBackColor = false;
            this.sortDateButton.Click += new System.EventHandler(this.sortDateButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(0, 641);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Optional:";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Controls.Add(this.panel2);
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Controls.Add(this.panel4);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 661);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(921, 153);
            this.panel5.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(921, 814);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TinyMemFS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseEnter += new System.EventHandler(this.leaveCursor);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDecrypt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEncrypt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRemove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdd)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button addButton;
        private Button removeButton;
        private Button returnButton;
        private Button saveToDiskButton;
        private Button encryptButton;
        private Button decryptButton;
        private Panel panel1;
        private PictureBox pictureBoxAdd;
        private PictureBox pictureBoxRemove;
        private PictureBox pictureBoxDecrypt;
        private PictureBox pictureBoxEncrypt;
        private PictureBox pictureBoxSave;
        private PictureBox pictureBoxList;
        private ListBox listBox1;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Button saveAllToDisk;
        private Button loadAllToDisk;
        private Button compressFileButton;
        private Button uncompressFileButton;
        private Panel panel2;
        private Panel panel3;
        private Button sortNameButton;
        private Button copyButton;
        private Button renameButton;
        private Button setHiddenButton;
        private Panel panel4;
        private Button sizeButton;
        private Button compareButton;
        private Button sortSizeButton;
        private Button sortDateButton;
        private Label label3;
        private Panel panel5;
    }
}