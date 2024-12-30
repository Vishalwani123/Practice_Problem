using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Problem_6
{
    internal class MissingNumber
    {
        public int FindMissingNumber(int[] Arr)
        {
            int n = Arr.Length + 1;
            int totalSum = n * (n + 1) / 2;
            int arraySum = 0;

            foreach (int i in Arr)
            {
                arraySum += i;
            }

            int missValue = totalSum - arraySum;
            return missValue;
        }
        public void Basics()
        {
            Console.WriteLine("Enter the size of an array");
            int s = Convert.ToInt32(Console.ReadLine());

            int[] Arr = new int[s];

            Console.WriteLine("Enter the elements of an array");
            for(int i = 0; i < s; i++)
            {
                Arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("The elements of an array are : ");
            foreach (int i in Arr)
            {
                Console.WriteLine(i);
            }

            int MissValue = FindMissingNumber(Arr);

            Console.WriteLine("The Missing value from an Array is : " + MissValue);
        }
    }
}
