using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Problem_6
{
    internal class SortedArrays
    {
        public string[]  MergeSortedArray(string[] str, string[] str1)
        {
            string[] merge = str.Concat(str1).ToArray();
            Array.Sort(merge);
            return merge;
        }
        public void SortingArray()
        {
            String[] str = {"Vishal", "Vatsal", "Vipul", "Dhiraj"};
            Array.Sort(str);

            string[] str1 = {"Harshal", "Shubham", "Anush"};
            Array.Sort(str1);

            string[] merge =  MergeSortedArray(str, str1);

            foreach (string s in merge)
            {
                Console.WriteLine(s);
            }
           
        }
    }
}
