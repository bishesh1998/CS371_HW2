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
            Circle C1 = new Circle(7, "Green");
            Square S1 = new Square(10);
            Triangle T1 = new Triangle(24,"Red");
            Pentagon P1 = new Pentagon(12,"Blue");

            Console.Write("Parameter of the Cirlce : ");
            Console.WriteLine(C1.getparameter());
            Console.Write("Parameter of the Square : ");
            Console.WriteLine(S1.getparameter());
            Console.Write("Parameter of the Triangle : ");
            Console.WriteLine(T1.getparameter());
            Console.Write("Parameter of the Pentagon : ");
            Console.WriteLine(P1.getparameter());
        }
    }
}
