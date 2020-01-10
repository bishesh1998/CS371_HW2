using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_Ex4
{
    //Temperature class
    class Temperature
    {
        private double cel;
        private double fah;
        private double kel;

        //Default Constructor
        public Temperature()
        {
            //all the value of absolute zero temperature
            kel = 0;
            cel = -273.15;
            fah = -459.67;
        }

        //Base input is Kelvin method
        public void baseKel(double n)
        {
            //condition for below absolute zero
            if (n < 0)
            {
                throw (new TemperatureException("Kelvin value cannot be less than absolute zero(Less than 0)."));
                return;
            }

            kel = n;
            fah = (n * (9 / 5)) - 459.67;
            cel = n - 273.15;
        }

        //Base input is Celsius method
        public void baseCel(double n)
        {
            //condition for below absolute zero
            if (n < -273.15)
            {
                throw (new TemperatureException("Celsius value cannot be less than absolute zero(Less than -273.15)."));
                return;
            }


            cel = n;
            kel = n + 273.15;
            fah = (n * 9.0) / 5.0 + 32;
        }

        //Base input is Fahrenheit method
        public void baseFah(double n)
        {
            //condition for below absolute zero
            if (n < -459.67)
            {
                throw (new TemperatureException("Fahrenheit value cannot be less than absolute zero(Less than -459.67)."));
                return;
            }

            fah = n;
            cel = (n - 32) * 5.0 / 9.0;
            kel = (5.0 / 9.0) * (n -32) + 273.15
                ;
        }

        //method to print all the temperature 
        public void print()
        {
            Console.WriteLine("****** TEMPERATURE STATS *********** ");
            Console.WriteLine("Kelvin : "+ kel);
            Console.WriteLine("Fahrenheit : "+ fah);
            Console.WriteLine("Celcius : "+ cel);
        }
    }
}
