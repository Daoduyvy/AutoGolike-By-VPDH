namespace AutoGolike_By_VPDH
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
            this.MainView = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnMenuWorking = new System.Windows.Forms.Button();
            this.btnMenuManager = new System.Windows.Forms.Button();
            this.btnMenuSettings = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainView
            // 
            this.MainView.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MainView.Location = new System.Drawing.Point(200, 0);
            this.MainView.Name = "MainView";
            this.MainView.Size = new System.Drawing.Size(1724, 750);
            this.MainView.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.flowLayoutPanel1.Controls.Add(this.btnMenuWorking);
            this.flowLayoutPanel1.Controls.Add(this.btnMenuManager);
            this.flowLayoutPanel1.Controls.Add(this.btnMenuSettings);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 750);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // btnMenuWorking
            // 
            this.btnMenuWorking.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMenuWorking.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuWorking.Location = new System.Drawing.Point(3, 3);
            this.btnMenuWorking.Name = "btnMenuWorking";
            this.btnMenuWorking.Size = new System.Drawing.Size(197, 66);
            this.btnMenuWorking.TabIndex = 3;
            this.btnMenuWorking.Text = "Working";
            this.btnMenuWorking.UseVisualStyleBackColor = false;
            this.btnMenuWorking.Click += new System.EventHandler(this.BtnMenuWorking_Click);
            // 
            // btnMenuManager
            // 
            this.btnMenuManager.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMenuManager.FlatAppearance.BorderColor = System.Drawing.Color.LightSalmon;
            this.btnMenuManager.FlatAppearance.BorderSize = 2;
            this.btnMenuManager.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnMenuManager.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btnMenuManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuManager.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMenuManager.Location = new System.Drawing.Point(3, 75);
            this.btnMenuManager.Name = "btnMenuManager";
            this.btnMenuManager.Size = new System.Drawing.Size(197, 66);
            this.btnMenuManager.TabIndex = 0;
            this.btnMenuManager.Text = "Manager";
            this.btnMenuManager.UseVisualStyleBackColor = false;
            this.btnMenuManager.Click += new System.EventHandler(this.BtnMenuManager_Click);
            // 
            // btnMenuSettings
            // 
            this.btnMenuSettings.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMenuSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuSettings.Location = new System.Drawing.Point(3, 147);
            this.btnMenuSettings.Name = "btnMenuSettings";
            this.btnMenuSettings.Size = new System.Drawing.Size(197, 66);
            this.btnMenuSettings.TabIndex = 2;
            this.btnMenuSettings.Text = "Settings";
            this.btnMenuSettings.UseVisualStyleBackColor = false;
            this.btnMenuSettings.Click += new System.EventHandler(this.BtnMenuSettings_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 750);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.MainView);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto Golike Tool";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainView;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnMenuManager;
        private System.Windows.Forms.Button btnMenuSettings;
        private System.Windows.Forms.Button btnMenuWorking;
    }
}