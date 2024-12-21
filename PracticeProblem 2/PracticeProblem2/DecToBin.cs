using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem2
{
    internal class DecToBin
    {
        public static string ConvertToBinary(int number)
        {
            if (number == 0)
                return "0";

            string binary = string.Empty;
            int absNumber = Math.Abs(number);

            
            while (absNumber > 0)
            {
                binary = (absNumber % 2) + binary; 
                absNumber /= 2;                   
            }

            
            if (number < 0)
                binary = "-" + binary;

            return binary;
        }
    }
}
