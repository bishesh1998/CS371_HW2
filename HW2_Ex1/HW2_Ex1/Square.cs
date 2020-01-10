using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_Ex1
{
    //Square class inherit from Parent Class EqPolygon
    class Square : EqPolygon
    {
        //Default Constructor
        public Square(){}

        //Constructor
        public Square(double s) : base(s){}

        //Constructor
        public Square(double s, string a) : base (s,a){}

        //Method to calculate parameter
        public double getparameter()
        {
            double p = 4 * SideLen_value;
            return p;
        }

    }
}
