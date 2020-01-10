using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_Ex1
{
    //Square class inherit from Parent Class Triangle
    class Triangle : EqPolygon
    {
        //Default Constructor
        public Triangle() { }

        //Constructor
        public Triangle(double s) : base(s) { }

        //Constructor
        public Triangle(double s, string a) : base(s, a) { }

        //Method to calculate parameter
        public double getparameter()
        {
            double p = 3 * SideLen_value;
            return p;
        }
    }
}
