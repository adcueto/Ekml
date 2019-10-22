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

        private List<string> colList = new List<string>();
        private string csvFilePath;
        private int refIndex, latIndex, lonIndex;
        private string opaValue = "cc";
        private string[] rgbColor = {"ffffff", "ffffff", "ffffff", "ffffff", "ffffff"};
        private string pointSize = "0.6";
        private string[] rngValues= { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0"};
        private bool nameDisabled = true;
  
        public Form()
        {
            InitializeComponent();  
            this.MaximizeBox = false;
            this.MinimizeBox = true;
            this.ControlBox = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Width = 660;
            this.Height = 410;
            this.cmbSize.Text = "0.6";
            this.cmbOpacity.Text = "80";
            
        }


        private void openCsvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Csv CsvFile = new Csv();
            CsvFile.LoadFile();

            csvFilePath = CsvFile.Path;

            this.comboBox1.Items.Clear();
            this.comboBox2.Items.Clear();
            this.comboBox3.Items.Clear();

            //Does the route exist?
            if (!String.IsNullOrEmpty(csvFilePath))
            {
                CsvFile.ReadColumn();
                colList = CsvFile.ColList;

                //Headers load
                foreach (string element in CsvFile.ColList)
                {
                    this.comboBox1.Items.Add(element);
                    this.comboBox2.Items.Add(element);
                    this.comboBox3.Items.Add(element);
                }
            }
        }
        private void btnRng1_Click(object sender, EventArgs e)
        {
            Point PointKml = new Point();
            PointKml.GetColor(colorDialog1);
            btnRng1.BackColor = PointKml.ValColor;
            rgbColor[0] = PointKml.HexColor;

        }
        private void btnRng2_Click(object sender, EventArgs e)
        {
            Point PointKml = new Point();
            PointKml.GetColor(colorDialog1);
            btnRng2.BackColor = PointKml.ValColor;
            rgbColor[1] = PointKml.HexColor;
        }

        private void btnRng3_Click(object sender, EventArgs e)
        {
            Point PointKml = new Point();
            PointKml.GetColor(colorDialog1);
            btnRng3.BackColor = PointKml.ValColor;
            rgbColor[2] = PointKml.HexColor;
        }

        private void btnRng4_Click(object sender, EventArgs e)
        {
            Point PointKml = new Point();
            PointKml.GetColor(colorDialog1);
            btnRng4.BackColor = PointKml.ValColor;
            rgbColor[3] = PointKml.HexColor;
        }

        private void btnRng5_Click(object sender, EventArgs e)
        {
            Point PointKml = new Point();
            PointKml.GetColor(colorDialog1);
            btnRng5.BackColor = PointKml.ValColor;
            rgbColor[4] = PointKml.HexColor;
        }

        private void export_Click(object sender, EventArgs e)
        {
            Plotter();

        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Plotter();
        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            refIndex = this.comboBox1.SelectedIndex;
        }

        private void textVal0_TextChanged(object sender, EventArgs e)
        {
            rngValues[0]= textVal0.Text;
        }

        private void textVal1_TextChanged(object sender, EventArgs e)
        {
            rngValues[1] = textVal1.Text;
        }

        private void textVal2_TextChanged(object sender, EventArgs e)
        {
            rngValues[2] = textVal2.Text;
        }

        private void textVal3_TextChanged(object sender, EventArgs e)
        {
            rngValues[3] = textVal3.Text;
        }

        private void textVal4_TextChanged(object sender, EventArgs e)
        {
            rngValues[4] = textVal4.Text;
        }

        private void textVal5_TextChanged(object sender, EventArgs e)
        {
            rngValues[5] = textVal5.Text;
        }

        private void textVal6_TextChanged(object sender, EventArgs e)
        {
            rngValues[6] = textVal6.Text;
        }

        private void textVal7_TextChanged(object sender, EventArgs e)
        {
            rngValues[7] = textVal7.Text;
        }

        private void textVal8_TextChanged(object sender, EventArgs e)
        {
            rngValues[8] = textVal8.Text;
        }

        private void textVal9_TextChanged(object sender, EventArgs e)
        {
            rngValues[9] = textVal9.Text;
        }

        private void cmbOpacity_SelectedIndexChanged(object sender, EventArgs e)
        {
            int vaOpa= (Int32.Parse(cmbOpacity.Text)*255)/100;
            opaValue = vaOpa.ToString("x2");
        }

        private void cmbSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            pointSize = cmbSize.Text;
        }

        private void checkName_CheckedChanged(object sender, EventArgs e)
        {
            if (checkName.Enabled) { nameDisabled = false; }
            else { nameDisabled = true; }
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            latIndex = this.comboBox2.SelectedIndex;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            lonIndex = this.comboBox3.SelectedIndex;
        }

        private void Plotter()
        {
            try
            {
                Kml FileKml = new Kml();
                Notify Notification = new Notify();
               
                FileKml.Name = colList[refIndex];
                FileKml.CsvFilePath = csvFilePath;
                FileKml.PointNameDisable = nameDisabled;
                FileKml.Scale = pointSize;
                FileKml.Opacity = opaValue;
                
                FileKml.Create();
                FileKml.Header();
                            
                this.progressBar.Value = 10;
                
                FileKml.StyleRange("Range0", rgbColor[0]);
                FileKml.StyleRange("Range1", rgbColor[1]);
                FileKml.StyleRange("Range2", rgbColor[2]);
                FileKml.StyleRange("Range3", rgbColor[3]);
                FileKml.StyleRange("Range4", rgbColor[4]);

                progressBar.Value = 15;

                if (latIndex == 0 && lonIndex== 0) 
                { 
                    MessageBox.Show("Select latitude and longitude value"); 
                }
                else
                {
                    FileKml.PlaceMark(refIndex, latIndex, lonIndex, colList, rngValues);
                    this.progressBar.Value = 80;
                }
                FileKml.End();

                this.progressBar.Value = 100;
                
                Notification.NotiCreated();
                Notification.Dispose();

            }

            catch (Exception ex)
            {
                //doing nothing
                Console.WriteLine("Error de {0}", ex);
            }
        }
    }
}
