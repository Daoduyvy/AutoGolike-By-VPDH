namespace AutoGolike_By_VPDH
{
    partial class AddAccount
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSaveDB = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.GridViewAddAccount = new System.Windows.Forms.DataGridView();
            this.Uid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fb2fa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cookie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsernameGolike = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PasswordGolike = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proxy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewAddAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSaveDB);
            this.panel1.Controls.Add(this.btnImport);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1258, 64);
            this.panel1.TabIndex = 0;
            // 
            // btnSaveDB
            // 
            this.btnSaveDB.Location = new System.Drawing.Point(1146, 12);
            this.btnSaveDB.Name = "btnSaveDB";
            this.btnSaveDB.Size = new System.Drawing.Size(91, 32);
            this.btnSaveDB.TabIndex = 1;
            this.btnSaveDB.Text = "SaveDB";
            this.btnSaveDB.UseVisualStyleBackColor = true;
            this.btnSaveDB.Click += new System.EventHandler(this.BtnSaveDB_Click);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(1023, 12);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(88, 32);
            this.btnImport.TabIndex = 0;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.BtnImport_Click);
            // 
            // GridViewAddAccount
            // 
            this.GridViewAddAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewAddAccount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Uid,
            this.Password,
            this.fb2fa,
            this.Cookie,
            this.UsernameGolike,
            this.PasswordGolike,
            this.Proxy,
            this.Status});
            this.GridViewAddAccount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GridViewAddAccount.Location = new System.Drawing.Point(0, 86);
            this.GridViewAddAccount.Name = "GridViewAddAccount";
            this.GridViewAddAccount.RowHeadersWidth = 51;
            this.GridViewAddAccount.RowTemplate.Height = 24;
            this.GridViewAddAccount.Size = new System.Drawing.Size(1258, 618);
            this.GridViewAddAccount.TabIndex = 1;
            // 
            // Uid
            // 
            this.Uid.HeaderText = "Uid";
            this.Uid.MinimumWidth = 6;
            this.Uid.Name = "Uid";
            this.Uid.Width = 125;
            // 
            // Password
            // 
            this.Password.HeaderText = "Password";
            this.Password.MinimumWidth = 6;
            this.Password.Name = "Password";
            this.Password.Width = 125;
            // 
            // fb2fa
            // 
            this.fb2fa.HeaderText = "2fa";
            this.fb2fa.MinimumWidth = 6;
            this.fb2fa.Name = "fb2fa";
            this.fb2fa.Width = 125;
            // 
            // Cookie
            // 
            this.Cookie.HeaderText = "Cookie";
            this.Cookie.MinimumWidth = 6;
            this.Cookie.Name = "Cookie";
            this.Cookie.Width = 125;
            // 
            // UsernameGolike
            // 
            this.UsernameGolike.HeaderText = "Username Golike";
            this.UsernameGolike.MinimumWidth = 6;
            this.UsernameGolike.Name = "UsernameGolike";
            this.UsernameGolike.Width = 125;
            // 
            // PasswordGolike
            // 
            this.PasswordGolike.HeaderText = "Password Golike";
            this.PasswordGolike.MinimumWidth = 6;
            this.PasswordGolike.Name = "PasswordGolike";
            this.PasswordGolike.Width = 125;
            // 
            // Proxy
            // 
            this.Proxy.HeaderText = "Proxy";
            this.Proxy.MinimumWidth = 6;
            this.Proxy.Name = "Proxy";
            this.Proxy.Width = 125;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.Width = 125;
            // 
            // AddAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 704);
            this.Controls.Add(this.GridViewAddAccount);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddAccount";
            this.Text = "AddAccount";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewAddAccount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView GridViewAddAccount;
        private System.Windows.Forms.Button btnSaveDB;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.DataGridViewTextBoxColumn Uid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn fb2fa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cookie;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsernameGolike;
        private System.Windows.Forms.DataGridViewTextBoxColumn PasswordGolike;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proxy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}