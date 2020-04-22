using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessAccess;

namespace AutoGolike_By_VPDH
{
    public partial class Form1 : Form
    {
        NordVPN nordVpn = new NordVPN();
        public Form1()
        {
            InitializeComponent();
        }
        private void CreateGrid()
        {
            //Create Golike
            {
                grdGolike.ColumnCount = 7;
                DataGridViewColumn column = grdGolike.Columns[0]; column.Width = 50;
                column = grdGolike.Columns[1]; column.Width = 140;
                column = grdGolike.Columns[2]; column.Width = 140;
                column = grdGolike.Columns[3]; column.Width = 150;
                column = grdGolike.Columns[4]; column.Width = 150;
                column = grdGolike.Columns[5]; column.Width = 150;
                column = grdGolike.Columns[6]; column.Width = 160;

                grdGolike.Columns[0].HeaderText = "ID";
                grdGolike.Columns[1].HeaderText = "User";
                grdGolike.Columns[2].HeaderText = "Password";
                grdGolike.Columns[3].HeaderText = "Số Job";
                grdGolike.Columns[4].HeaderText = "Tình trạng";
                grdGolike.Columns[5].HeaderText = "Ghi chú";
                grdGolike.Columns[6].HeaderText = "Kết quả";
            }
            //Create Facebook
            {
                grdFacebook.ColumnCount = 9;
                DataGridViewColumn column = grdFacebook.Columns[0]; column.Width = 40;
                column = grdFacebook.Columns[1]; column.Width = 120;
                column = grdFacebook.Columns[2]; column.Width = 120;
                column = grdFacebook.Columns[3]; column.Width = 100;
                column = grdFacebook.Columns[4]; column.Width = 100;
                column = grdFacebook.Columns[5]; column.Width = 120;
                column = grdFacebook.Columns[6]; column.Width = 130;
                column = grdFacebook.Columns[7]; column.Width = 130;
                column = grdFacebook.Columns[8]; column.Width = 85;

                grdFacebook.Columns[0].HeaderText = "ID";
                grdFacebook.Columns[1].HeaderText = "UID";
                grdFacebook.Columns[2].HeaderText = "Pasword";
                grdFacebook.Columns[3].HeaderText = "Token";
                grdFacebook.Columns[4].HeaderText = "Cookies";
                grdFacebook.Columns[5].HeaderText = "2FA";
                grdFacebook.Columns[6].HeaderText = "Tình trạng";
                grdFacebook.Columns[7].HeaderText = "Ghi chú";
                grdFacebook.Columns[8].HeaderText = "TKGolike";
            }
            //Create Status
            {
                grdStatus.ColumnCount = 7;
                DataGridViewColumn column = grdStatus.Columns[0]; column.Width = 40;
                column = grdStatus.Columns[1]; column.Width = 150;
                column = grdStatus.Columns[2]; column.Width = 150;
                column = grdStatus.Columns[3]; column.Width = 170;
                column = grdStatus.Columns[4]; column.Width = 170;
                column = grdStatus.Columns[5]; column.Width = 150;
                column = grdStatus.Columns[6]; column.Width = 110;

                grdStatus.Columns[0].HeaderText = "ID";
                grdStatus.Columns[1].HeaderText = "TK Golike";
                grdStatus.Columns[2].HeaderText = "TK Facebook";
                grdStatus.Columns[3].HeaderText = "Tương tác";
                grdStatus.Columns[4].HeaderText = "Tình trạng";
                grdStatus.Columns[5].HeaderText = "Ghi chú";
                grdStatus.Columns[6].HeaderText = "Kết quả";
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            CreateGrid();
        }

    }
}
