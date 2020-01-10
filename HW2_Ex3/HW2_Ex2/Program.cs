//////////////////////////////////////////////////////////////////////////////////
// HW 2 : EX 03
// CS371 - Whitworth University
// Originally outlined by: Bishesh Tuladhar
// Worked With : Sabin Sapkota & Novel Poudel
/////////////////////////////////////////////////////////////////////////////

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
            Radio R1 = new Radio(); //generating new class of radio
            R1.RadioStatus();

            bool on = false;
            string power;

            Console.Write("Would you like to turn the radio on? (Y/N): "); //prompting the user to turn on or off the radio
            power = Console.ReadLine();
            if (power == "Y" || power == "y")
            {
                on = true;
            }

            if (on == false)
            {
                R1.RadioStatus(); //printing the radio status
            }
            else
            {
                R1.toggle(); //turning on the radio
                Console.Beep();
                R1.RadioStatus(); //printing the radio status
            }

            while (on) //loop until the radio is turned off
            {
                Console.WriteLine("*************** Radio Options *********************** ");
                Console.WriteLine("1. Volume Change");
                Console.WriteLine("2. Station Change");
                Console.WriteLine("3. Turn off");
                Console.Write("Would you like to do? (1, 2, or 3): ");
                string user_input = Console.ReadLine(); //prompting the user for an action
                int input = Convert.ToInt32(user_input);

                if (input == 1 ) //condition of volume tune
                {
                    Console.Write("What would you like to change the volume to? (Between 0 and 12): ");
                    int vol = Convert.ToInt32(Console.ReadLine());
                    R1.crank(vol); //volume interface
                } 
                else if (input == 2) //condition of station tune
                {
                    Console.Write("What would you like to change the station to? (Any decimal number from 88.5 to 107.9): ");
                    float stat = float.Parse(Console.ReadLine());
                    R1.tune(stat); //station interface
                } 
                else if (input == 3)
                {
                    on = false;
                    R1.toggle(); //turning off the radio
                    Console.Beep();
                }

                R1.RadioStatus(); //printing the radio status
            }

            Console.ReadLine();
        }
    }
}
