using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Problem_4
{
    internal class SumEvenOdd
    {
        public void cal1(int number,  out int evenSum,  out int oddSum)
        {
            evenSum = 0;
            oddSum = 0;

            
            while (number != 0)
            {
                int digit = number % 10; 
                if (digit % 2 == 0)
                {
                    evenSum += digit;
                    
                }
                else
                {
                    oddSum += digit; 
                }
                number /= 10;
                
            }
        }
    }
}
