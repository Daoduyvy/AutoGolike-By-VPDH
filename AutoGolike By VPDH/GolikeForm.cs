using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using System.IO;

namespace AutoGolike_By_VPDH
{
    public partial class GolikeForm : Form
    {
        public GolikeForm()
        {
            InitializeComponent();
        }

        private void BtnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            //Nullable<bool> result = ofd.ShowDialog();

            ofd.Filter = "Text files (*.txt) | *.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string url = ofd.FileName;
                tbDataPath.Text = url;
                DataTable dt = Convert(url, "test", "|");
                dataGridView1.DataSource = dt;

            }
        }

        DataTable table;
        public DataTable Convert(string File, string TableName, string delimiter)
        {
            table = new DataTable();
            table.Columns.Add("Username");
            table.Columns.Add("Password");
            

            StreamReader s = new StreamReader(File);

            string AllData = s.ReadToEnd();
            string[] stringSeparators = new string[] { "\r\n" };
            string[] rows = AllData.Split(stringSeparators, StringSplitOptions.None);
            foreach (string r in rows)
            {
                string[] items = r.Split(delimiter.ToCharArray());
                table.Rows.Add(items);
            }
            return table;
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {

        }

        private void BtnStop_Click(object sender, EventArgs e)
        {

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
