﻿namespace AutoGolike_By_VPDH
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbAuto = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.tbSetting = new System.Windows.Forms.TabPage();
            this.Tab = new System.Windows.Forms.TabControl();
            this.tbGolike = new System.Windows.Forms.TabPage();
            this.grdGolike = new System.Windows.Forms.DataGridView();
            this.tbFacebook = new System.Windows.Forms.TabPage();
            this.grdFacebook = new System.Windows.Forms.DataGridView();
            this.tbStatus = new System.Windows.Forms.TabPage();
            this.grdStatus = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnAddGolikeAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDeleteGolikeAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddFacebooktoGolike = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddFacebookAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDeleteFacebookAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tbAuto.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Tab.SuspendLayout();
            this.tbGolike.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdGolike)).BeginInit();
            this.tbFacebook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdFacebook)).BeginInit();
            this.tbStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdStatus)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbAuto);
            this.tabControl1.Controls.Add(this.tbSetting);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1000, 115);
            this.tabControl1.TabIndex = 0;
            // 
            // tbAuto
            // 
            this.tbAuto.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbAuto.Controls.Add(this.groupBox1);
            this.tbAuto.Location = new System.Drawing.Point(4, 22);
            this.tbAuto.Name = "tbAuto";
            this.tbAuto.Padding = new System.Windows.Forms.Padding(3);
            this.tbAuto.Size = new System.Drawing.Size(992, 89);
            this.tbAuto.TabIndex = 0;
            this.tbAuto.Text = "Auto";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnStop);
            this.groupBox1.Controls.Add(this.btnStart);
            this.groupBox1.Location = new System.Drawing.Point(4, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(114, 85);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bắt đầu";
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(10, 35);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(10, 15);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // tbSetting
            // 
            this.tbSetting.Location = new System.Drawing.Point(4, 22);
            this.tbSetting.Name = "tbSetting";
            this.tbSetting.Padding = new System.Windows.Forms.Padding(3);
            this.tbSetting.Size = new System.Drawing.Size(992, 89);
            this.tbSetting.TabIndex = 1;
            this.tbSetting.Text = "Setting";
            this.tbSetting.UseVisualStyleBackColor = true;
            // 
            // Tab
            // 
            this.Tab.Controls.Add(this.tbGolike);
            this.Tab.Controls.Add(this.tbFacebook);
            this.Tab.Controls.Add(this.tbStatus);
            this.Tab.Location = new System.Drawing.Point(0, 115);
            this.Tab.Name = "Tab";
            this.Tab.SelectedIndex = 0;
            this.Tab.Size = new System.Drawing.Size(1000, 445);
            this.Tab.TabIndex = 1;
            // 
            // tbGolike
            // 
            this.tbGolike.Controls.Add(this.grdGolike);
            this.tbGolike.Location = new System.Drawing.Point(4, 22);
            this.tbGolike.Name = "tbGolike";
            this.tbGolike.Padding = new System.Windows.Forms.Padding(3);
            this.tbGolike.Size = new System.Drawing.Size(992, 419);
            this.tbGolike.TabIndex = 0;
            this.tbGolike.Text = "Tài khoản Golike";
            this.tbGolike.UseVisualStyleBackColor = true;
            // 
            // grdGolike
            // 
            this.grdGolike.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdGolike.ContextMenuStrip = this.contextMenuStrip1;
            this.grdGolike.Location = new System.Drawing.Point(0, 0);
            this.grdGolike.Name = "grdGolike";
            this.grdGolike.Size = new System.Drawing.Size(990, 420);
            this.grdGolike.TabIndex = 0;
            // 
            // tbFacebook
            // 
            this.tbFacebook.Controls.Add(this.grdFacebook);
            this.tbFacebook.Location = new System.Drawing.Point(4, 22);
            this.tbFacebook.Name = "tbFacebook";
            this.tbFacebook.Padding = new System.Windows.Forms.Padding(3);
            this.tbFacebook.Size = new System.Drawing.Size(992, 419);
            this.tbFacebook.TabIndex = 1;
            this.tbFacebook.Text = "Tài khoản Facebook";
            this.tbFacebook.UseVisualStyleBackColor = true;
            // 
            // grdFacebook
            // 
            this.grdFacebook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdFacebook.ContextMenuStrip = this.contextMenuStrip2;
            this.grdFacebook.Location = new System.Drawing.Point(0, 0);
            this.grdFacebook.Name = "grdFacebook";
            this.grdFacebook.Size = new System.Drawing.Size(990, 420);
            this.grdFacebook.TabIndex = 0;
            // 
            // tbStatus
            // 
            this.tbStatus.Controls.Add(this.grdStatus);
            this.tbStatus.Location = new System.Drawing.Point(4, 22);
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.Size = new System.Drawing.Size(992, 419);
            this.tbStatus.TabIndex = 2;
            this.tbStatus.Text = "Status";
            this.tbStatus.UseVisualStyleBackColor = true;
            // 
            // grdStatus
            // 
            this.grdStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdStatus.Location = new System.Drawing.Point(0, 0);
            this.grdStatus.Name = "grdStatus";
            this.grdStatus.Size = new System.Drawing.Size(990, 420);
            this.grdStatus.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddGolikeAccount,
            this.btnDeleteGolikeAccount});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(158, 48);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddFacebooktoGolike,
            this.btnAddFacebookAccount,
            this.btnDeleteFacebookAccount});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(164, 70);
            // 
            // btnAddGolikeAccount
            // 
            this.btnAddGolikeAccount.Name = "btnAddGolikeAccount";
            this.btnAddGolikeAccount.Size = new System.Drawing.Size(157, 22);
            this.btnAddGolikeAccount.Text = "Thêm tài khoản";
            this.btnAddGolikeAccount.Click += new System.EventHandler(this.btnAddGolikeAccount_Click);
            // 
            // btnDeleteGolikeAccount
            // 
            this.btnDeleteGolikeAccount.Name = "btnDeleteGolikeAccount";
            this.btnDeleteGolikeAccount.Size = new System.Drawing.Size(157, 22);
            this.btnDeleteGolikeAccount.Text = "Xoá tài khoản";
            this.btnDeleteGolikeAccount.Click += new System.EventHandler(this.btnDeleteGolikeAccount_Click);
            // 
            // btnAddFacebooktoGolike
            // 
            this.btnAddFacebooktoGolike.Name = "btnAddFacebooktoGolike";
            this.btnAddFacebooktoGolike.Size = new System.Drawing.Size(163, 22);
            this.btnAddFacebooktoGolike.Text = "Thêm vào Golike";
            // 
            // btnAddFacebookAccount
            // 
            this.btnAddFacebookAccount.Name = "btnAddFacebookAccount";
            this.btnAddFacebookAccount.Size = new System.Drawing.Size(163, 22);
            this.btnAddFacebookAccount.Text = "Thêm tài khoản";
            this.btnAddFacebookAccount.Click += new System.EventHandler(this.btnAddFacebookAccount_Click);
            // 
            // btnDeleteFacebookAccount
            // 
            this.btnDeleteFacebookAccount.Name = "btnDeleteFacebookAccount";
            this.btnDeleteFacebookAccount.Size = new System.Drawing.Size(163, 22);
            this.btnDeleteFacebookAccount.Text = "Xoá tài khoản";
            this.btnDeleteFacebookAccount.Click += new System.EventHandler(this.btnDeleteFacebookAccount_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 561);
            this.Controls.Add(this.Tab);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tbAuto.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.Tab.ResumeLayout(false);
            this.tbGolike.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdGolike)).EndInit();
            this.tbFacebook.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdFacebook)).EndInit();
            this.tbStatus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdStatus)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbAuto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TabPage tbSetting;
        private System.Windows.Forms.TabControl Tab;
        private System.Windows.Forms.TabPage tbGolike;
        private System.Windows.Forms.TabPage tbFacebook;
        private System.Windows.Forms.TabPage tbStatus;
        private System.Windows.Forms.DataGridView grdGolike;
        private System.Windows.Forms.DataGridView grdFacebook;
        private System.Windows.Forms.DataGridView grdStatus;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnAddGolikeAccount;
        private System.Windows.Forms.ToolStripMenuItem btnDeleteGolikeAccount;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem btnAddFacebooktoGolike;
        private System.Windows.Forms.ToolStripMenuItem btnAddFacebookAccount;
        private System.Windows.Forms.ToolStripMenuItem btnDeleteFacebookAccount;
    }
}

