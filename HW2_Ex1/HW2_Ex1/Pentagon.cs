using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_Ex1
{
    //EqPolygon class inherit from Parent Class EqPolygon
    class Pentagon : EqPolygon
    {
        //Default Constructor
        public Pentagon() { }

        //Constructor
        public Pentagon(double s) : base(s) { }

        //Constructor
        public Pentagon(double s, string a) : base(s, a) { }

        //Method to calculate parameter
        public double getparameter()
        {
            double p = 5 * SideLen_value;
            return p;
        }
    }
}
