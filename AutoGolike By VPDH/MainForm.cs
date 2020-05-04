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
        GolikeForm glf = new GolikeForm();
        FacebookForm fbf = new FacebookForm();
        SettingsForm stf = new SettingsForm();
        public MainForm()
        {
            InitializeComponent();
            MainLoadForm();
        }

        private void MainLoadForm()
        {
            IsMdiContainer = true;
            addForm(glf);
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
        private void BtnMenuGolike_Click(object sender, EventArgs e)
        {
            addForm(glf);
        }

        private void BtnMenuFacebook_Click(object sender, EventArgs e)
        {
            FacebookForm fbf = new FacebookForm();
            addForm(fbf);
            

        }

        private void BtnMenuSettings_Click(object sender, EventArgs e)
        {
            addForm(stf);
        }
    }
}
