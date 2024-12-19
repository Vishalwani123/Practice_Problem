using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem2
{
    internal class SumDigit
    {
        public static int Calculate(int num)
        {
            int sum = 0;

            while (num > 0)
            {
                sum += num % 10; 
                num /= 10;       
            }

            return sum;
        }
    }
}
