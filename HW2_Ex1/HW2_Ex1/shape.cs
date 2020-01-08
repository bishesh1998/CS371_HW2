using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_Ex1
{
    class Shape
    {
        private string color;
        private int parameters;

       public Shape()
        {
            color = "White";
        }

        public Shape(string c)
        {
            color = c;
        }

        public string color_value
        {
            get { return color; }
            set { color = value; }
        }

        public virtual double getparameter()
        {
            Console.WriteLine("Generic Shapes don't have a valid parameter!");
            return 0.0;
        } 

    }
}
