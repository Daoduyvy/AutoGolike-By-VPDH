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
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            //LoadSettings();
        }

        

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SaveDataJson();
        }

        #region ham
        public void SaveDataJson()
        {
            if (!File.Exists("./data.json"))
            {
                //File.Create("./data.json");
                File.AppendAllText("./data.json", "{\"fills\":{}}");
            }
            string fileJson = File.ReadAllText("./data.json");
            //data.DataJson Data = JsonConvert.DeserializeObject<data.DataJson>(fileJson);
            //Data.fills.HDBrowser = HideBrowsera;

            //Data.fills.NumThread = NumThread;
            //List<data.DataJson> _data = new List<data.DataJson>();
            //_data.Add(Data);
            //string json = JsonConvert.SerializeObject(_data.ToArray());
            //json = json.Remove(0, 1);
            //json = json.Remove(json.Length - 1, 1);
            //File.WriteAllText("./data.json", json);
        }


        public void LoadSettings()
        {
            try
            {
                //string fileJson = File.ReadAllText("./data.json");
                //data.DataJson Data = JsonConvert.DeserializeObject<data.DataJson>(fileJson);
                ////textBox1.Text = Data.fills.textbox;
                ////textBox2.Text = Data.fills.textbox2;

                //NumThread = Data.fills.NumThread;
                //if (Data.fills.HDBrowser == true)
                //    HideBrowsera = true;
                //else HideBrowsera = false;
            }
            catch (Exception)
            {

            }
        }

        #endregion
    }
}
