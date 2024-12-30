using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Problem_6
{
    internal class CommonElements
    {
        public string[] CommonElementsArray(string[] str1, string[] str2)
        {
            string[] common = new string[Math.Min(str1.Length, str2.Length)];
            int count = 0;

            for (int i = 0; i < str1.Length; i++)
            {
                bool duplicate = false;

                for (int j = 0; j < str2.Length; j++)
                {
                    if (str1[i] == str2[j])
                    {
                        duplicate = true;
                        break;
                    }
                }
                if (duplicate)
                {
                    common[count] = str1[i];
                    count++;
                }
            }
            return common;
        }
            
        public void Basics()
        {
            Console.WriteLine("Enter the size of an First array");
            int s1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the size of an Second array");
            int s2 = Convert.ToInt32(Console.ReadLine());

            string[] str1 = new string[s1];
            string[] str2 = new string[s2];

            Console.WriteLine();
            Console.WriteLine("Enter the elements of an First array");
            for (int i = 0; i < s1; i++)
            {
                str1[i] = Console.ReadLine();
            }

            Console.WriteLine();
            Console.WriteLine("Enter the elements of an Second array");
            for (int i = 0; i < s2; i++)
            {
                str2[i] = Console.ReadLine();
            }

            Console.WriteLine();
            Console.WriteLine("The elements of an First array are : ");
            foreach (string s in str1)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();
            Console.WriteLine("The elements of an Second array are : ");
            foreach (string s in str2)
            {
                Console.WriteLine(s);
            }

            string[] common = CommonElementsArray(str1, str2);

            Console.WriteLine();
            Console.WriteLine("The Common Elements from an Two array are : ");
            foreach (string s in common)
            {
                Console.WriteLine(s);
            }
        }
    }
}
