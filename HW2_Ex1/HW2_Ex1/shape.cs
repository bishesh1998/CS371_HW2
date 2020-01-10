using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_Ex1
{
    //Parent class
    class Shape
    {
        private string color;
        private int parameters;

        //Default Constructor
       public Shape()
        {
            color = "White";
        }

        //Constructor
        public Shape(string c)
        {
            color = c;
        }

        //Property of Color
        public string color_value
        {
            get { return color; }
            set { color = value; }
        }

        //Virtual Method to get the parameter of the shape
        public virtual double getparameter()
        {
            Console.WriteLine("Generic Shapes don't have a valid parameter!");
            return 0.0;
        } 

    }
}
