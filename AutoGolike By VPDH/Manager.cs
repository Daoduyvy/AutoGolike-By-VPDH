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
    public partial class Manager : Form
    {
        AddAccount addF = new AddAccount();
        public Manager()
        {
            InitializeComponent();
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            OpenForm(addF);   
        }

        private void OpenForm(Form f)
        {
            //f.TopLevel = false;
            //f.AutoScroll = true;
            //f.Dock = DockStyle.Fill;
            //f.FormBorderStyle = FormBorderStyle.None;
            f.Show();
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {

        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {

        }
    }
}
