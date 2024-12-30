using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Problem_6
{
   
    internal class SecondLargest
    {

        public int FindingSecLargest(int[] Arr)
        {
            if(Arr == null)
            {
                Console.WriteLine("Array is empty");
            }

            int largest = int.MinValue;
            int secondLargest = int.MinValue;

            foreach(int i in Arr)
            {
               if(i > largest)
                { 
                    secondLargest = largest;
                    largest = i;
                }
                else if (i > secondLargest && i<largest)
                {
                    secondLargest = i;
                }
            }
            if(secondLargest == int.MinValue)
            { 
                Console.WriteLine("There is no second largest element.");
                return -1;
            }
            else
            {
                return secondLargest;

            }

        }
        public void SecondLargestElement()
        {
            Console.WriteLine("Enter the size of an array");
            int s  = Convert.ToInt32(Console.ReadLine());

            int[] Arr = new int[s];

            Console.WriteLine("Enter the elements of an array");

            for(int i = 0; i < s; i++)
            {
                Arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            int secondLargests= FindingSecLargest(Arr);
            Console.WriteLine("Second Largest element in an array is: " + secondLargests);
        }

    }
}
