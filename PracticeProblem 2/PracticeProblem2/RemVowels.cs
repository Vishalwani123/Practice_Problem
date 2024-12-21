using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem2
{
    internal class RemVowels
    {
        public static string RemoveVowels(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            string vowels = "aeiouAEIOU";
            string result = string.Empty;

            foreach (char c in input)
            {
                if (!vowels.Contains(c))
                {
                    result += c;
                }
            }

            return result;
        }
    }
}
