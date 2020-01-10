using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_Ex1
{
    //Circle class inherit from Parent Class Shape
    class Circle : Shape
    {
        private double radius;

        //Default Constructor
        public Circle()
        {
            radius = 1;

        }

        //Constrcutor
        public Circle(double n)
        {
            radius = n;
        }

        public Circle(double n, string a) : base(a)
        {
            radius = n;
        }

        //Property of Radius
        public double radius_value
        {
            get { return radius; }
            set { radius = value; }
        }

        //Method to calculate parameter
        public double getparameter()
        {
            double p = 2 * 3.14159 * radius;
            return p;
        }
    }
}
