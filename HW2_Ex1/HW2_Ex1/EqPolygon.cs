using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_Ex1
{
    //EqPolygon class inherit from Parent Class Shape
    class EqPolygon : Shape
    {
        private double SideLen;

        //Default Constructor
        public EqPolygon()
        {
            SideLen = 1;
        }

        //Constructor
        public EqPolygon(double n)
        {
            SideLen = n;
        }

        public EqPolygon(double n, string a) : base(a)
        {
            SideLen = n;
        }

        //Property of SideLen
        public double SideLen_value
        {
            get { return SideLen; }
            set { SideLen = value; }
        }
    }
}
