using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ekml
{
    class Plotter
    {
        //compare a value between two ranges
        public bool CompareRange(string rng1, string rng2, string val) 
        {
            bool result = false;
            int range1 = Int32.Parse(rng1);
            int range2= Int32.Parse(rng2);
            int value = Int32.Parse(val);

            if (value  >= range1 && value <= range2)
            {
                result = true;
            }
            else { result = false; } 
           

            return result;
        }



    }
}
