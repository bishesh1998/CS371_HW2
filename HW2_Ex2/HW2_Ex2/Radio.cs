using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_Ex2
{
    public interface ISwitch
    {
        void toggle();
    }

    public interface ITunable
    {
        void tune(float s);
        void crank(int v);
    }

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

        public void tune(float s)
        {
            if (s > 88.5 && s < 107.9)
            {
                Station = s;
            }
        }

        public void crank(int v)
        {
            if (v >= 0 && v <= 12)
            {
                Volume = v;
            }
        }

        public bool On
        {
            get { return @on; }
            set { @on = value; }
        }

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
