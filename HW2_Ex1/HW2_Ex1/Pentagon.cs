using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_Ex1
{
    class Pentagon : EqPolygon
    {
        public Pentagon() { }

        public Pentagon(double s) : base(s) { }

        public Pentagon(double s, string a) : base(s, a) { }

        public double getparameter()
        {
            double p = 5 * SideLen_value;
            return p;
        }
    }
}
