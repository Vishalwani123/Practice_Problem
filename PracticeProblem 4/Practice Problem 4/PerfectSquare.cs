using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Problem_4
{
    internal class PerfectSquare
    {
        public bool PerSqu(int number)
        {
            if (number < 0)
            {
                return false;

            }

            int sqrt = (int)Math.Sqrt(number); 
            return sqrt * sqrt == number; 
        }
    }
}
