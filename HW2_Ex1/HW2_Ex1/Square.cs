using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_Ex1
{
    class Square : EqPolygon
    {
        public Square(){}

        public Square(double s) : base(s){}

        public Square(double s, string a) : base (s,a){}

        public double getparameter()
        {
            double p = 4 * SideLen_value;
            return p;
        }

    }
}
