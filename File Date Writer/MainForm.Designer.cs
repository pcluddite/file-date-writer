namespace Baxendale.FileDateWriter
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblCreateTime = new System.Windows.Forms.Label();
            this.lblLastWrite = new System.Windows.Forms.Label();
            this.lblLastAccess = new System.Windows.Forms.Label();
            this.txtCreateTime = new System.Windows.Forms.TextBox();
            this.txtLastWrite = new System.Windows.Forms.TextBox();
            this.txtLastAccess = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dlgOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.lblFilename = new System.Windows.Forms.Label();
            this.lblCurrentFileSettings = new System.Windows.Forms.Label();
            this.lblCurrCreationTime = new System.Windows.Forms.Label();
            this.lblCurrLastWrite = new System.Windows.Forms.Label();
            this.lblCurrLastAccess = new System.Windows.Forms.Label();
            this.txtFilename = new System.Windows.Forms.TextBox();
            this.btnOpenFolder = new System.Windows.Forms.Button();
            this.dlgOpenFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.lblNewFileSettings = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lblCreateTime
            // 
            this.lblCreateTime.AutoSize = true;
            this.lblCreateTime.Location = new System.Drawing.Point(33, 53);
            this.lblCreateTime.Name = "lblCreateTime";
            this.lblCreateTime.Size = new System.Drawing.Size(75, 13);
            this.lblCreateTime.TabIndex = 3;
            this.lblCreateTime.Text = "Creation Time:";
            // 
            // lblLastWrite
            // 
            this.lblLastWrite.AutoSize = true;
            this.lblLastWrite.Location = new System.Drawing.Point(24, 79);
            this.lblLastWrite.Name = "lblLastWrite";
            this.lblLastWrite.Size = new System.Drawing.Size(84, 13);
            this.lblLastWrite.TabIndex = 6;
            this.lblLastWrite.Text = "Last Write Time:";
            // 
            // lblLastAccess
            // 
            this.lblLastAccess.AutoSize = true;
            this.lblLastAccess.Location = new System.Drawing.Point(2, 105);
            this.lblLastAccess.Name = "lblLastAccess";
            this.lblLastAccess.Size = new System.Drawing.Size(106, 13);
            this.lblLastAccess.TabIndex = 9;
            this.lblLastAccess.Text = "Last Accessed Time:";
            // 
            // txtCreateTime
            // 
            this.txtCreateTime.Location = new System.Drawing.Point(121, 50);
            this.txtCreateTime.Name = "txtCreateTime";
            this.txtCreateTime.Size = new System.Drawing.Size(137, 20);
            this.txtCreateTime.TabIndex = 4;
            this.txtCreateTime.TextChanged += new System.EventHandler(this.txtCreateTime_TextChanged);
            // 
            // txtLastWrite
            // 
            this.txtLastWrite.Location = new System.Drawing.Point(121, 76);
            this.txtLastWrite.Name = "txtLastWrite";
            this.txtLastWrite.Size = new System.Drawing.Size(137, 20);
            this.txtLastWrite.TabIndex = 7;
            this.txtLastWrite.TextChanged += new System.EventHandler(this.txtLastWrite_TextChanged);
            // 
            // txtLastAccess
            // 
            this.txtLastAccess.Location = new System.Drawing.Point(121, 102);
            this.txtLastAccess.Name = "txtLastAccess";
            this.txtLastAccess.Size = new System.Drawing.Size(137, 20);
            this.txtLastAccess.TabIndex = 10;
            this.txtLastAccess.TextChanged += new System.EventHandler(this.txtLastAccess_TextChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(118, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(170, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "File Date Writing Utility 2009";
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(169, 132);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(75, 23);
            this.btnOpenFile.TabIndex = 14;
            this.btnOpenFile.Text = "Open File";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(331, 132);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dlgOpenFile
            // 
            this.dlgOpenFile.DefaultExt = "*.*";
            this.dlgOpenFile.Filter = "All Files(*.*)|*.*";
            // 
            // lblFilename
            // 
            this.lblFilename.AutoSize = true;
            this.lblFilename.Location = new System.Drawing.Point(12, 137);
            this.lblFilename.Name = "lblFilename";
            this.lblFilename.Size = new System.Drawing.Size(52, 13);
            this.lblFilename.TabIndex = 12;
            this.lblFilename.Text = "Filename:";
            // 
            // lblCurrentFileSettings
            // 
            this.lblCurrentFileSettings.AutoSize = true;
            this.lblCurrentFileSettings.Location = new System.Drawing.Point(283, 31);
            this.lblCurrentFileSettings.Name = "lblCurrentFileSettings";
            this.lblCurrentFileSettings.Size = new System.Drawing.Size(104, 13);
            this.lblCurrentFileSettings.TabIndex = 2;
            this.lblCurrentFileSettings.Text = "Current File Settings:";
            // 
            // lblCurrCreationTime
            // 
            this.lblCurrCreationTime.AutoSize = true;
            this.lblCurrCreationTime.Location = new System.Drawing.Point(270, 53);
            this.lblCurrCreationTime.Name = "lblCurrCreationTime";
            this.lblCurrCreationTime.Size = new System.Drawing.Size(62, 13);
            this.lblCurrCreationTime.TabIndex = 5;
            this.lblCurrCreationTime.Text = "--/--/-- --:-- --";
            // 
            // lblCurrLastWrite
            // 
            this.lblCurrLastWrite.AutoSize = true;
            this.lblCurrLastWrite.Location = new System.Drawing.Point(270, 79);
            this.lblCurrLastWrite.Name = "lblCurrLastWrite";
            this.lblCurrLastWrite.Size = new System.Drawing.Size(62, 13);
            this.lblCurrLastWrite.TabIndex = 8;
            this.lblCurrLastWrite.Text = "--/--/-- --:-- --";
            // 
            // lblCurrLastAccess
            // 
            this.lblCurrLastAccess.AutoSize = true;
            this.lblCurrLastAccess.Location = new System.Drawing.Point(270, 105);
            this.lblCurrLastAccess.Name = "lblCurrLastAccess";
            this.lblCurrLastAccess.Size = new System.Drawing.Size(62, 13);
            this.lblCurrLastAccess.TabIndex = 11;
            this.lblCurrLastAccess.Text = "--/--/-- --:-- --";
            // 
            // txtFilename
            // 
            this.txtFilename.BackColor = System.Drawing.SystemColors.Window;
            this.txtFilename.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFilename.Location = new System.Drawing.Point(65, 134);
            this.txtFilename.Name = "txtFilename";
            this.txtFilename.ReadOnly = true;
            this.txtFilename.Size = new System.Drawing.Size(98, 20);
            this.txtFilename.TabIndex = 13;
            this.txtFilename.MouseHover += new System.EventHandler(this.txtFilename_MouseHover);
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.Location = new System.Drawing.Point(250, 132);
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Size = new System.Drawing.Size(75, 23);
            this.btnOpenFolder.TabIndex = 15;
            this.btnOpenFolder.Text = "Open Folder";
            this.btnOpenFolder.UseVisualStyleBackColor = true;
            this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click);
            // 
            // lblNewFileSettings
            // 
            this.lblNewFileSettings.AutoSize = true;
            this.lblNewFileSettings.Location = new System.Drawing.Point(71, 31);
            this.lblNewFileSettings.Name = "lblNewFileSettings";
            this.lblNewFileSettings.Size = new System.Drawing.Size(92, 13);
            this.lblNewFileSettings.TabIndex = 1;
            this.lblNewFileSettings.Text = "New File Settings:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 170);
            this.Controls.Add(this.lblNewFileSettings);
            this.Controls.Add(this.btnOpenFolder);
            this.Controls.Add(this.txtFilename);
            this.Controls.Add(this.lblCurrLastAccess);
            this.Controls.Add(this.lblCurrLastWrite);
            this.Controls.Add(this.lblCurrCreationTime);
            this.Controls.Add(this.lblCurrentFileSettings);
            this.Controls.Add(this.lblFilename);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtLastAccess);
            this.Controls.Add(this.txtLastWrite);
            this.Controls.Add(this.txtCreateTime);
            this.Controls.Add(this.lblLastAccess);
            this.Controls.Add(this.lblLastWrite);
            this.Controls.Add(this.lblCreateTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Date Writing Utility 2009";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCreateTime;
        private System.Windows.Forms.Label lblLastWrite;
        private System.Windows.Forms.Label lblLastAccess;
        private System.Windows.Forms.TextBox txtCreateTime;
        private System.Windows.Forms.TextBox txtLastWrite;
        private System.Windows.Forms.TextBox txtLastAccess;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.OpenFileDialog dlgOpenFile;
        private System.Windows.Forms.Label lblFilename;
        private System.Windows.Forms.Label lblCurrentFileSettings;
        private System.Windows.Forms.Label lblCurrCreationTime;
        private System.Windows.Forms.Label lblCurrLastWrite;
        private System.Windows.Forms.Label lblCurrLastAccess;
        private System.Windows.Forms.TextBox txtFilename;
        private System.Windows.Forms.Button btnOpenFolder;
        private System.Windows.Forms.FolderBrowserDialog dlgOpenFolder;
        private System.Windows.Forms.Label lblNewFileSettings;
        private System.Windows.Forms.ToolTip toolTip;
    }
}

