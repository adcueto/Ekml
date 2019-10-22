using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Ekml
{

    public class Point 
    {

        public string HexColor { get; set; }
        public Color ValColor { get; set; }

        public Point()
        {
            HexColor = string.Empty;
            ValColor = Color.Black;
        }

        public void GetColor(ColorDialog Dialog)
        {
            string hexR, hexG, hexB;
            // Show the color dialog.
            DialogResult result = Dialog.ShowDialog();
            // See if user pressed ok.
            if (result == DialogResult.OK)
            {
                //Color long to string converter
                hexR = Dialog.Color.R.ToString("x2");
                hexG = Dialog.Color.G.ToString("x2");
                hexB = Dialog.Color.B.ToString("x2");
                ValColor = Dialog.Color;
                HexColor = hexB + hexG + hexR;
            }
        }
        public bool Between(string rng1, string rng2, string val)
        {
            //String to Int coverter
            int range1 = Int32.Parse(rng1);
            int range2 = Int32.Parse(rng2);
            int value = Int32.Parse(val);
     
            if (value >= range1 && value <= range2){ return true;}
            return false;
                  
        }

    }
}
