using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle C1 = new Circle(7, "Green"); //generating new Circle
            Square S1 = new Square(10); //generating new Square
            Triangle T1 = new Triangle(24,"Red"); //generating new Triangle
            Pentagon P1 = new Pentagon(12,"Blue"); //generating new Pentagon

            Console.Write("Parameter of the Cirlce : ");
            Console.WriteLine(C1.getparameter()); //calculating the parameter of Cirlce
            Console.Write("Parameter of the Square : ");
            Console.WriteLine(S1.getparameter()); //calculating the parameter of Square
            Console.Write("Parameter of the Triangle : ");
            Console.WriteLine(T1.getparameter()); //calculating the parameter of Triangle
            Console.Write("Parameter of the Pentagon : ");
            Console.WriteLine(P1.getparameter()); //calculating the parameter of Pentagon
        }
    }
}
