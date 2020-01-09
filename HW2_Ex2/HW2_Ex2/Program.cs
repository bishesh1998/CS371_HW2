using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Radio R1 = new Radio();
            R1.RadioStatus();

            bool on = false;
            string power;

            Console.Write("Would you like to turn the radio on? (Y/N): ");
            power = Console.ReadLine();
            if (power == "Y" || power == "y")
            {
                on = true;
            }

            if (on == false)
            {
                R1.RadioStatus();
            }
            else
            {
                R1.toggle();
                Console.Beep();
                R1.RadioStatus();
            }

            while (on)
            {
                Console.WriteLine("*************** Radio Options *********************** ");
                Console.WriteLine("1. Volume Change");
                Console.WriteLine("2. Station Change");
                Console.WriteLine("3. Turn off");
                Console.Write("Would you like to do? (1, 2, or 3): ");
                string user_input = Console.ReadLine();
                int input = Convert.ToInt32(user_input);

                if (input == 1 )
                {
                    Console.Write("What would you like to change the volume to? (Between 0 and 12): ");
                    int vol = Convert.ToInt32(Console.ReadLine());
                    R1.crank(vol);
                }
                else if (input == 2)
                {
                    Console.Write("What would you like to change the station to? (Any decimal number from 88.5 to 107.9): ");
                    float stat = float.Parse(Console.ReadLine());
                    R1.tune(stat);
                }
                else if (input == 3)
                {
                    on = false;
                    R1.toggle();
                    Console.Beep();
                }

                R1.RadioStatus();
            }

            Console.ReadLine();
        }
    }
}
