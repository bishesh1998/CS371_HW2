using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_Ex1
{
    class Triangle : EqPolygon
    {
        public Triangle() { }

        public Triangle(double s) : base(s) { }

        public Triangle(double s, string a) : base(s, a) { }

        public double getparameter()
        {
            double p = 3 * SideLen_value;
            return p;
        }
    }
}
