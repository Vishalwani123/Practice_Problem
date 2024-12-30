using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Problem_6
{
    internal class RemoveDuplicate
    {
        public string[] RemoveDuplicateElements(string[] str)
        {
            string[] result = new string[str.Length];
            int count = 0;

            for (int i = 0; i < str.Length; i++)
            {
                bool duplicate = false;

                for (int j = 0; j < count; j++)
                {
                    if (str[i] == result[j])
                    {
                        duplicate = true;
                        break;
                    }
                }
                if (!duplicate)
                {
                    result[count] = str[i];
                    count++;
                }
            }
            return result;

        }
        public void Basics()
        {
            Console.WriteLine("Enter the size of an array");
            int s = Convert.ToInt32(Console.ReadLine());

            string[] str = new string[s];
           

            Console.WriteLine();
            Console.WriteLine("Enter the elements of an array");
            for (int i = 0; i < s; i++)
            {
                str[i] = Console.ReadLine();
            }
            Console.WriteLine();
            Console.WriteLine("The elements of an array are : ");
            foreach (string s1 in str)
            {
                Console.WriteLine(s1);
            }

            string[] resultArray = RemoveDuplicateElements(str);

            Console.WriteLine();
            Console.WriteLine("Array without duplicate elements are : ");
            foreach (string s2 in resultArray)
            {
                Console.WriteLine(s2);
            }

        }
    }
}
