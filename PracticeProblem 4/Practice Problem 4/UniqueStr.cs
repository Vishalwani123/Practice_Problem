using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Problem_4
{
    internal class UniqueStr
    {
        public bool uni(string input)
        {
            if (input == null)
            {
                return true;

            }

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = i + 1; j < input.Length; j++)
                {
                    if (input[i] == input[j])
                    {
                        return false; 
                    }
                }
            }

            return true; 
        }
    }
}
