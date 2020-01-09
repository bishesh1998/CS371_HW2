using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_Ex4
{
    class Temperature
    {
        private double cel;
        private double fah;
        private double kel;

        public Temperature()
        {
            kel = 0;
            cel = -273.15;
            fah = -459.67;
        }

        public void baseKel(double n)
        {
            kel = n;
            fah = (n * (9 / 5)) - 459.67;
            cel = n - 273.15;
        }

        public void baseCel(double n)
        {
            cel = n;
            kel = n + 273.15;
            fah = (n * (9 / 5)) + 32;
        }

        public void baseFah(double n)
        {
            fah = n;
            cel = (n - 32) * (5 / 9);
            kel = (n + 459.67) * (5 / 9);
        }
    }
}
