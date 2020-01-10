using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_Ex2
{
    //Interface class for toggling the switch of radio
    public interface ISwitch
    {
        void toggle();
    }

    //Interface class for tuning the station and volume of radio
    public interface ITunable
    {
        void tune(float s);
        void crank(int v);
    }

    //Radio class inherited from ISwtich and ITunable
    public class Radio : ISwitch, ITunable
    {
        private bool on;
        private float station;
        private int volume;

        public Radio()
        {
            @on = false;
            station = 91.7F;
            volume = 5;
        }

        //Method to toggle the switch
        public void toggle()
        {
            if (@on)
            {
                @on = false;
            }
            else
            {
                @on = true;
            }
        }

        //Method to tune the station
        public void tune(float s)
        {
            if (s > 88.5 && s < 107.9)
            {
                Station = s;
            }
        }

        //Method to tune the volume
        public void crank(int v)
        {
            if (v >= 0 && v <= 12)
            {
                Volume = v;
            }
        }
        
        //Property of on
        public bool On
        {
            get { return @on; }
            set { @on = value; }
        }

        //Property of Station
        public float Station
        {
            get { return station; }
            set
            {
                if (value >= 88.5 && value <= 107.9)
                {
                    station = value;
                }
            }
        }

        //Property of Volume
        public int Volume
        {
            get { return volume; }
            set
            {
                if (value >= 0 && value <= 12)
                {
                    volume = value;
                }
            }
        }

        //Method to print the status to the terminal
        public void RadioStatus()
        {
            if (On)
            {
                Console.WriteLine("The radio is turned on.");
                Console.WriteLine("Volume = {0}", Volume);
                Console.WriteLine("Station = {0}", Station);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine ("The radio is off.");

            }
        }
    }
}
