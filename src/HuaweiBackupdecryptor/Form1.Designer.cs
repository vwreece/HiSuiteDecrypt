namespace HuaweiBackupdecryptor
{
    partial class frmMain
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
            this.btnMain = new System.Windows.Forms.Button();
            this.txtFileToDecrypt = new System.Windows.Forms.TextBox();
            this.btnOpenDecrypt = new System.Windows.Forms.Button();
            this.btnOutputOpen = new System.Windows.Forms.Button();
            this.txtOutputFolder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtConsole = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnMain
            // 
            this.btnMain.Location = new System.Drawing.Point(12, 107);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(198, 31);
            this.btnMain.TabIndex = 0;
            this.btnMain.Text = "Decrypt";
            this.btnMain.UseVisualStyleBackColor = true;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // txtFileToDecrypt
            // 
            this.txtFileToDecrypt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFileToDecrypt.Location = new System.Drawing.Point(123, 13);
            this.txtFileToDecrypt.Name = "txtFileToDecrypt";
            this.txtFileToDecrypt.Size = new System.Drawing.Size(438, 23);
            this.txtFileToDecrypt.TabIndex = 1;
            // 
            // btnOpenDecrypt
            // 
            this.btnOpenDecrypt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenDecrypt.Location = new System.Drawing.Point(567, 13);
            this.btnOpenDecrypt.Name = "btnOpenDecrypt";
            this.btnOpenDecrypt.Size = new System.Drawing.Size(33, 23);
            this.btnOpenDecrypt.TabIndex = 2;
            this.btnOpenDecrypt.Text = "...";
            this.btnOpenDecrypt.UseVisualStyleBackColor = true;
            this.btnOpenDecrypt.Click += new System.EventHandler(this.btnOpenDecrypt_Click);
            // 
            // btnOutputOpen
            // 
            this.btnOutputOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOutputOpen.Location = new System.Drawing.Point(567, 40);
            this.btnOutputOpen.Name = "btnOutputOpen";
            this.btnOutputOpen.Size = new System.Drawing.Size(33, 23);
            this.btnOutputOpen.TabIndex = 4;
            this.btnOutputOpen.Text = "...";
            this.btnOutputOpen.UseVisualStyleBackColor = true;
            this.btnOutputOpen.Click += new System.EventHandler(this.btnOutputOpen_Click);
            // 
            // txtOutputFolder
            // 
            this.txtOutputFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutputFolder.Location = new System.Drawing.Point(123, 41);
            this.txtOutputFolder.Name = "txtOutputFolder";
            this.txtOutputFolder.Size = new System.Drawing.Size(438, 23);
            this.txtOutputFolder.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Backup To Decrypt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Output Folder";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(123, 69);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(275, 23);
            this.txtPassword.TabIndex = 7;
            // 
            // txtConsole
            // 
            this.txtConsole.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConsole.BackColor = System.Drawing.Color.White;
            this.txtConsole.Location = new System.Drawing.Point(12, 144);
            this.txtConsole.Multiline = true;
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.ReadOnly = true;
            this.txtConsole.Size = new System.Drawing.Size(588, 207);
            this.txtConsole.TabIndex = 9;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 363);
            this.Controls.Add(this.txtConsole);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOutputOpen);
            this.Controls.Add(this.txtOutputFolder);
            this.Controls.Add(this.btnOpenDecrypt);
            this.Controls.Add(this.txtFileToDecrypt);
            this.Controls.Add(this.btnMain);
            this.Name = "frmMain";
            this.Text = "Backup Decryptor HiSuite";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.TextBox txtFileToDecrypt;
        private System.Windows.Forms.Button btnOpenDecrypt;
        private System.Windows.Forms.Button btnOutputOpen;
        private System.Windows.Forms.TextBox txtOutputFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtConsole;
    }
}
