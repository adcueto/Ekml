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
        public string PathFile,dSource;
        public int iSource, iLatitude, iLongitude, DataSource;
        public string hexOPA = "cc";
        public string[] hexBGR = { "ff", "ff", "ff", "ff","ff" };
        public string sizePoint = "0.6";
        public string[] textValues= { "0", "0", "0", "0", "0", "0","0","0","0","0"};
        public bool checkNameEnabled = true;


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

            PathFile = CsvFile.Path;

            this.comboBox1.Items.Clear();
            this.comboBox2.Items.Clear();
            this.comboBox3.Items.Clear();

            //Does the route exist?
            if (!String.IsNullOrEmpty(PathFile))
            {
                CsvFile.ReadColumn();
                ColumnList = CsvFile.ColList;

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
            string hexR, hexG, hexB;
            // Show the color dialog.
            DialogResult result = colorDialog1.ShowDialog();
            // See if user pressed ok.
            if (result == DialogResult.OK)
            {
                // Set form background to 
                btnRng1.BackColor = colorDialog1.Color;
                hexR = this.colorDialog1.Color.R.ToString("x2");
                hexG = this.colorDialog1.Color.G.ToString("x2");
                hexB = this.colorDialog1.Color.B.ToString("x2");
                hexBGR[0] = hexB + hexG + hexR;
            }

        }
        private void btnRng2_Click(object sender, EventArgs e)
        {
            string hexR, hexG, hexB;
            // Show the color dialog.
            DialogResult result = colorDialog1.ShowDialog();
            // See if user pressed ok.
            if (result == DialogResult.OK)
            {
                // Set form background to 
                btnRng2.BackColor = colorDialog1.Color;
                hexR = this.colorDialog1.Color.R.ToString("x2");
                hexG = this.colorDialog1.Color.G.ToString("x2");
                hexB = this.colorDialog1.Color.B.ToString("x2");
                hexBGR[1] = hexB + hexG + hexR;
            }
        }

        private void btnRng3_Click(object sender, EventArgs e)
        {
            string hexR, hexG, hexB;
            // Show the color dialog.
            DialogResult result = colorDialog1.ShowDialog();
            // See if user pressed ok.
            if (result == DialogResult.OK)
            {
                // Set form background to 
                btnRng3.BackColor = colorDialog1.Color;
                hexR = this.colorDialog1.Color.R.ToString("x2");
                hexG = this.colorDialog1.Color.G.ToString("x2");
                hexB = this.colorDialog1.Color.B.ToString("x2");
                hexBGR[2] = hexB + hexG + hexR;
            }
        }

        private void btnRng4_Click(object sender, EventArgs e)
        {
            string hexR, hexG, hexB;
            // Show the color dialog.
            DialogResult result = colorDialog1.ShowDialog();
            // See if user pressed ok.
            if (result == DialogResult.OK)
            {
                // Set form background to 
                btnRng4.BackColor = colorDialog1.Color;
                hexR = this.colorDialog1.Color.R.ToString("x2");
                hexG = this.colorDialog1.Color.G.ToString("x2");
                hexB = this.colorDialog1.Color.B.ToString("x2");
                hexBGR[3] = hexB + hexG + hexR;
            }
        }

        private void btnRng5_Click(object sender, EventArgs e)
        {
            string hexR, hexG, hexB;
            // Show the color dialog.
            DialogResult result = colorDialog1.ShowDialog();
            // See if user pressed ok.
            if (result == DialogResult.OK)
            {
                // Set form background to 
                btnRng5.BackColor = colorDialog1.Color;
                hexR = this.colorDialog1.Color.R.ToString("x2");
                hexG = this.colorDialog1.Color.G.ToString("x2");
                hexB = this.colorDialog1.Color.B.ToString("x2");
                hexBGR[4] = hexB + hexG + hexR;
                
            }
        }

        private void export_Click(object sender, EventArgs e)
        {
            plotter();

        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            plotter();
        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            iSource = this.comboBox1.SelectedIndex;
        }

        private void textVal0_TextChanged(object sender, EventArgs e)
        {
            textValues[0]= textVal0.Text;
        }

        private void textVal1_TextChanged(object sender, EventArgs e)
        {
            textValues[1] = textVal1.Text;
        }

        private void textVal2_TextChanged(object sender, EventArgs e)
        {
            textValues[2] = textVal2.Text;
        }

        private void textVal3_TextChanged(object sender, EventArgs e)
        {
            textValues[3] = textVal3.Text;
        }

        private void textVal4_TextChanged(object sender, EventArgs e)
        {
            textValues[4] = textVal4.Text;
        }

        private void textVal5_TextChanged(object sender, EventArgs e)
        {
            textValues[5] = textVal5.Text;
        }

        private void textVal6_TextChanged(object sender, EventArgs e)
        {
            textValues[6] = textVal6.Text;
        }

        private void textVal7_TextChanged(object sender, EventArgs e)
        {
            textValues[7] = textVal7.Text;
        }

        private void textVal8_TextChanged(object sender, EventArgs e)
        {
            textValues[8] = textVal8.Text;
        }

        private void textVal9_TextChanged(object sender, EventArgs e)
        {
            textValues[9] = textVal9.Text;
        }

        private void cmbOpacity_SelectedIndexChanged(object sender, EventArgs e)
        {
            int vaOpa= (Int32.Parse(cmbOpacity.Text)*255)/100;
            hexOPA = vaOpa.ToString("x2");
        }

        private void cmbSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            sizePoint = cmbSize.Text;
        }

        private void checkName_CheckedChanged(object sender, EventArgs e)
        {
            if (checkName.Enabled) { checkNameEnabled = false; }
            else { checkNameEnabled = true; }
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            iLatitude = this.comboBox2.SelectedIndex;
            string Data1 = this.comboBox2.SelectedItem.ToString();
            
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            iLongitude = this.comboBox3.SelectedIndex;
            string Data2 = this.comboBox3.SelectedItem.ToString();
        }

        private void plotter()
        {
            try
            {
                Kml FileKml = new Kml();
                Notify Notification = new Notify();

                FileKml.Create(ColumnList[iSource]);
                FileKml.Header(ColumnList[iSource]);
                FileKml.FileRead = PathFile;
                FileKml.labelNameEnabled = checkNameEnabled;
                
                this.progressBar.Value = 10;
                
                FileKml.StyleRange("Range0", hexOPA + hexBGR[0], sizePoint);
                FileKml.StyleRange("Range1", hexOPA + hexBGR[1], sizePoint);
                FileKml.StyleRange("Range2", hexOPA + hexBGR[2], sizePoint);
                FileKml.StyleRange("Range3", hexOPA + hexBGR[3], sizePoint);
                FileKml.StyleRange("Range4", hexOPA + hexBGR[4], sizePoint);


                progressBar.Value = 15;
                if (iLatitude == 0) { MessageBox.Show("Select latitude and longitude value"); }
                else
                {
                    FileKml.PlaceMark(iSource, iLatitude, iLongitude, ColumnList, textValues);
                    this.progressBar.Value = 80;
                }
                FileKml.End();
                this.progressBar.Value = 100;
                Notification.NotiCreated();
                
            }

            catch (Exception ex)
            {
                //doing nothing
                Console.WriteLine("Error de {0}", ex);
            }
        }
    }
}
