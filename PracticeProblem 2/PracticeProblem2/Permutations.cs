using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem2
{
    internal class Permutations
    {
        public static void GeneratePermutations(string str, int left, int right)
        {
            if (left == right)
            {
                Console.WriteLine(str);
                return;
            }

            for (int i = left; i <= right; i++)
            {
                str = Swap(str, left, i);                 
                GeneratePermutations(str, left + 1, right); 
                str = Swap(str, left, i);                  
            }
        }
        static string Swap(string str, int i, int j)
        {
            char[] charArray = str.ToCharArray();
            char temp = charArray[i];
            charArray[i] = charArray[j];
            charArray[j] = temp;
            return new string(charArray);
        }
    }
}
