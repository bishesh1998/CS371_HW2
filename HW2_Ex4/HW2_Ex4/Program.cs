using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Temperature T1 = new Temperature();//generating new class of temperature 
            int input = 5;
            string user;
            
            //User UI Menu
            Console.WriteLine("^^^^^^^^^^^ Temperature Calculator ^^^^^^^^^^^^^^^^^ ");
            Console.WriteLine("1. Kelvin");
            Console.WriteLine("2. Celcius");
            Console.WriteLine("3. Fahrenheit");
            Console.Write("Which temperature is the base ? (1/2/3) : ");
            user = Console.ReadLine();

            //Try catch for user valid input
            try
            {
                input = Convert.ToInt32(user);
            }
            catch
            {
                Console.WriteLine("Please enter a valid index number.");
            } 

            string in_temp; //user input temperature
            double t; //converter user input

            if (input == 1 ) //condition for kelvin
            {
                Console.Write("Enter the temperature in Kelvin : ");
                in_temp = Console.ReadLine();
                t = Convert.ToDouble(in_temp);

                //exception handling 
                try
                {
                    T1.baseKel(t);
                    T1.print();
                }
                catch (TemperatureException error)
                {
                    Console.WriteLine(error.Message);
                }
            }
            else if (input == 2) //condition for Celsius
            {
                Console.Write("Enter the temperature in Celsius : ");
                in_temp = Console.ReadLine();
                t = Convert.ToDouble(in_temp);

                //exception handling 
                try
                {
                    T1.baseCel(t);
                    T1.print();
                }
                catch (TemperatureException error)
                {
                    Console.WriteLine(error.Message);
                }
            }
            else if (input == 3) //condition for Fahrenhiet
            {
                Console.Write("Enter the temperature in Fahrenhiet : ");
                in_temp = Console.ReadLine();
                t = Convert.ToDouble(in_temp);

                //exception handling 
                try
                {
                    T1.baseFah(t);
                    T1.print();
                }
                catch (TemperatureException error)
                {
                    Console.WriteLine(error.Message);
                }              
            }
            else
            {
                Console.WriteLine("Please enter a valid input.");
            }


        }
    }
}
