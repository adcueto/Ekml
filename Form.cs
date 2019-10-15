using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ekml
{
    public partial class Form : System.Windows.Forms.Form
    {

        public List<string> ColumnList = new List<string>();
        public List<string> ValueList = new List<string>();
        public string PathFile,dSource;
        public int iSource, iLatitude, iLongitude;

        public Form()
        {
            InitializeComponent();
        }

        private void openCsvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Csv CsvFile = new Csv();
            CsvFile.LoadFile();

            PathFile = CsvFile.Path;

            //Does the route exist?
            if (!String.IsNullOrEmpty(PathFile))
            {
                CsvFile.ReadColumn();
                ColumnList = CsvFile.ColList;

                //Headers load
                foreach (string element in CsvFile.ColList)
                {
                    comboBox1.Items.Add(element);
                    comboBox2.Items.Add(element);
                    comboBox3.Items.Add(element);
                }
            }
        }

        private void export_Click(object sender, EventArgs e)
        {

            Kml FileKml = new Kml();
            FileKml.Create(dSource);
            FileKml.Header();
            FileKml.StyleRange("Range0","RSSI", "ff00ff55", 0.7);
            if(iLatitude==0){MessageBox.Show("seleccione el valor de latitud y longitud");}
            FileKml.PlaceMark("Range0", iSource, iLatitude, iLongitude, PathFile, ColumnList);
            FileKml.End();

            MessageBox.Show("file created");



        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Kml FileKml = new Kml();
            FileKml.Create(dSource);
            FileKml.Header();
            FileKml.StyleRange("Range0", "RSSI", "ff00ff55", 0.7);
            if (iLatitude == 0) { MessageBox.Show("seleccione el valor de latitud y longitud"); }
            else
            {
                FileKml.PlaceMark("Range0", iSource, iLatitude, iLongitude, PathFile, ColumnList);
            }

            FileKml.End();

            MessageBox.Show("file created");

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            iSource = comboBox1.SelectedIndex;
            dSource = comboBox1.SelectedItem.ToString();
            labelIndex.Text = dSource;

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            iLatitude = comboBox2.SelectedIndex;
            string Data1 = comboBox2.SelectedItem.ToString();
            
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            iLongitude = comboBox3.SelectedIndex;
            string Data2 = comboBox3.SelectedItem.ToString();
        }
    }
}
