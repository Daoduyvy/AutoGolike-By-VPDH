using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoGolike_By_VPDH
{
    public partial class AddAccount : Form
    {
        public AddAccount()
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
                DataTable dt = Convert(url, "test", "|");
                foreach (DataRow row in dt.Rows)
                {
                    GridViewAddAccount.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5]);
                }
                //GridViewAddAccount.DataSource = dt.DefaultView;

            }
        }

        DataTable table;
        public DataTable Convert(string File, string TableName, string delimiter)
        {
            table = new DataTable();
            table.Columns.Add("uid");
            table.Columns.Add("Pass");
            table.Columns.Add("2fa");
            table.Columns.Add("Cookie");
            table.Columns.Add("username golike");
            table.Columns.Add("pass golike");
            table.Columns.Add("Status");

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

        private void BtnSaveDB_Click(object sender, EventArgs e)
        {

        }
    }
}
