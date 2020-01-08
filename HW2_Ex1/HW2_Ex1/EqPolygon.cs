using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_Ex1
{
    class EqPolygon : Shape
    {
        private double SideLen;

        public EqPolygon()
        {
            SideLen = 1;
        }

        public EqPolygon(double n)
        {
            SideLen = n;
        }

        public EqPolygon(double n, string a) : base(a)
        {
            SideLen = n;
        }



        public double SideLen_value
        {
            get { return SideLen; }
            set { SideLen = value; }
        }
    }
}
