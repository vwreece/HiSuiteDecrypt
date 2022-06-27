using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HuaweiBackupdecryptor
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            Console.TxtBoxOut = this.txtConsole;
        }
        
        private void btnMain_Click(object sender, EventArgs e)
        {
            Console.TxtBoxOut.Clear();
            var user_password = txtPassword.Text;
            var backup_path_in = txtFileToDecrypt.Text;
            var dest_path_out = txtOutputFolder.Text;
            kobackupdec.decrypt(user_password, backup_path_in, dest_path_out);
        }

        private void btnOpenDecrypt_Click(object sender, EventArgs e)
        {
            var openFileDlg = new OpenFileDialog();
            openFileDlg.Filter = "All Files (*.*)|*.*";
            openFileDlg.FilterIndex = 1;
            openFileDlg.Multiselect = false;

            if (openFileDlg.ShowDialog() == DialogResult.OK)
            {
                txtFileToDecrypt.Text = openFileDlg.FileName;
            }
        }

        private void btnOutputOpen_Click(object sender, EventArgs e)
        {
            var folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description = "Output path";
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txtOutputFolder.Text = folderBrowserDialog.SelectedPath;
            }
        }
    }
}
