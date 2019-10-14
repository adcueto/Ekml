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
        
        public Form()
        {
            InitializeComponent();
        }

        private void openExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Excel excel = new Excel();
            excel.LoadFile();
            string pathLocal = excel.Path;
            if (pathLocal.Length != 0)
            {
                MessageBox.Show(pathLocal);
            }
            
        }

        private void export_Click(object sender, EventArgs e)
        {

            Kml kmlFile = new Kml();
            kmlFile.Create("Rssi");
            kmlFile.Write("hola");
            kmlFile.Write("{0}hola{1}","'RSSI'",20);
            MessageBox.Show("file created");



        }
    }
}
