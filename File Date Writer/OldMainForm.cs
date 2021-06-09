using System;
using System.Windows.Forms;
using System.IO;

namespace Baxendale.FileDateWriter
{
    public partial class OldMainForm : Form
    {
        public OldMainForm(string path)
        {
            InitializeComponent();
            if (!string.IsNullOrEmpty(path))
            {
                if (Directory.Exists(path))
                {
                    LoadFolder(path);
                }
                else
                {
                    LoadFile(path);
                }
            }
        }

        private void LoadFile(string path)
        {
            try
            {
                dlgOpenFile.FileName = path;
                lblFilename.Text = "Filename:";
                txtCreateTime.Text = File.GetCreationTime(path).ToString();
                lblCurrCreationTime.Text = txtCreateTime.Text;
                txtLastWrite.Text = File.GetLastWriteTime(path).ToString();
                lblCurrLastWrite.Text = txtLastWrite.Text;
                txtLastAccess.Text = File.GetLastAccessTime(path).ToString();
                lblCurrLastAccess.Text = txtLastAccess.Text;
                txtFilename.Text = Path.GetFileName(path);
                btnSave.Enabled = false;
            }
            catch (Exception ex)
            {
                ResetForm();
                if (ex is ArgumentException || ex is IOException || ex is UnauthorizedAccessException)
                {
                    MessageBox.Show(this, ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    throw;
                }
            }
        }

        private void LoadFolder(string path)
        {
            try
            {
                dlgOpenFolder.SelectedPath = path;
                lblFilename.Text = "Folder:";
                txtCreateTime.Text = Directory.GetCreationTime(path).ToString();
                lblCurrCreationTime.Text = txtCreateTime.Text;
                txtLastWrite.Text = Directory.GetLastWriteTime(path).ToString();
                lblCurrLastWrite.Text = txtLastWrite.Text;
                txtLastAccess.Text = Directory.GetLastAccessTime(path).ToString();
                lblCurrLastAccess.Text = txtLastAccess.Text;
                txtFilename.Text = Path.GetFileName(path);
                btnSave.Enabled = false;
            }
            catch (Exception ex)
            {
                ResetForm();
                if (ex is ArgumentException || ex is IOException || ex is UnauthorizedAccessException)
                {
                    MessageBox.Show(this, ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    throw;
                }
            }
        }

        private void ResetForm()
        {
            txtCreateTime.Text = txtLastWrite.Text = txtLastAccess.Text = "";
            txtFilename.Text = "";
            lblCurrCreationTime.Text = lblCurrLastWrite.Text = lblCurrLastAccess.Text = "--/--/-- --:-- --";
            dlgOpenFile.FileName = dlgOpenFolder.SelectedPath = "";
            lblFilename.Text = "Filename:";
            btnSave.Enabled = false;
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            if (dlgOpenFile.ShowDialog() == DialogResult.OK)
            {
                LoadFile(dlgOpenFile.FileName);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DateTime? creationTime = ParseDate(txtCreateTime, "creation");
            if (creationTime == null) return;
            DateTime? lastWriteTime = ParseDate(txtLastWrite, "last write");
            if (lastWriteTime == null) return;
            DateTime? lastAccessTime = ParseDate(txtLastAccess, "last access");
            if (lastAccessTime == null) return;

            try
            {
                if (lblFilename.Text == "Filename:")
                {
                    File.SetCreationTime(dlgOpenFile.FileName, creationTime.Value);
                    File.SetLastWriteTime(dlgOpenFile.FileName, lastWriteTime.Value);
                    File.SetLastAccessTime(dlgOpenFile.FileName, lastAccessTime.Value);
                    LoadFile(dlgOpenFile.FileName);
                }
                else
                {
                    Directory.SetCreationTime(dlgOpenFolder.SelectedPath, creationTime.Value);
                    Directory.SetLastWriteTime(dlgOpenFolder.SelectedPath, lastWriteTime.Value);
                    Directory.SetLastAccessTime(dlgOpenFolder.SelectedPath, lastAccessTime.Value);
                    LoadFolder(dlgOpenFolder.SelectedPath);
                }
                btnSave.Enabled = false;
            }
            catch (Exception ex)
            {
                if (ex is ArgumentException || ex is IOException || ex is UnauthorizedAccessException)
                {
                    MessageBox.Show(this, ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    throw;
                }
            }
        }

        private DateTime? ParseDate(TextBox textBox, string name)
        {
            DateTime dateTime;
            if (DateTime.TryParse(textBox.Text, out dateTime))
            {
                return dateTime;
            }
            MessageBox.Show(this, "The " + name + " time was not in the correct format", Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            textBox.SelectAll();
            textBox.Focus();
            return null;
        }

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            if (dlgOpenFolder.ShowDialog() == DialogResult.OK)
            {
                LoadFolder(dlgOpenFolder.SelectedPath);
            }
        }

        private void txtCreateTime_TextChanged(object sender, EventArgs e)
        {
            if (!btnSave.Enabled) { btnSave.Enabled = true; }
        }

        private void txtLastWrite_TextChanged(object sender, EventArgs e)
        {
            if (!btnSave.Enabled) { btnSave.Enabled = true; }
        }

        private void txtLastAccess_TextChanged(object sender, EventArgs e)
        {
            if (!btnSave.Enabled) { btnSave.Enabled = true; }
        }

        private void txtFilename_MouseHover(object sender, EventArgs e)
        {
            if (lblFilename.Text == "Filename:")
            {
                toolTip.Show(dlgOpenFile.FileName, txtFilename);
            }
            else
            {
                toolTip.Show(dlgOpenFolder.SelectedPath, txtFilename);
            }
        }
    }
}
