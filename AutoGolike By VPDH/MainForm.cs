using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoGolike_By_VPDH
{
    public partial class MainForm : Form
    {
        
        SettingsForm stf = new SettingsForm();
        WorkingForm wkf = new WorkingForm();
        Manager mf = new Manager();
        public MainForm()
        {
            InitializeComponent();
            MainLoadForm();
        }

        private void MainLoadForm()
        {
            IsMdiContainer = true;
            addForm(wkf);
        }
        private void addForm(Form f)
        {
            f.TopLevel = false;
            f.AutoScroll = true;
            f.Dock = DockStyle.Fill;
            f.FormBorderStyle = FormBorderStyle.None;
            this.MainView.Controls.Clear();
            this.MainView.Controls.Add(f);
            
            f.Show();
        }
        

        
        private void BtnMenuSettings_Click(object sender, EventArgs e)
        {
            addForm(stf);
        }

        private void BtnMenuWorking_Click(object sender, EventArgs e)
        {
            addForm(wkf);
        }

        private void BtnMenuManager_Click(object sender, EventArgs e)
        {
            addForm(mf);
        }
    }
}
