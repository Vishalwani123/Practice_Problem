using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem2
{
    internal class ComInt
    {
        public static double CalculateComInt(double principal, double rate, int time, int n)
        {
            double amount = principal * Math.Pow(1 + (rate / 100) / n, n * time);
            return amount - principal; 
        }
    }
}
