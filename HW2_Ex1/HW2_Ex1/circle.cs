using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_Ex1
{
    class Circle : Shape
    {
        private double radius;

        public Circle()
        {
            radius = 1;

        }

        public Circle(double n)
        {
            radius = n;
        }

        public Circle(double n, string a) : base(a)
        {
            radius = n;
        }

        public double radius_value
        {
            get { return radius; }
            set { radius = value; }
        }

        public double getparameter()
        {
            double p = 2 * 3.14159 * radius;
            return p;
        }
    }
}
