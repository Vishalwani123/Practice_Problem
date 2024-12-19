//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace PracticeProblem
//{
//    internal class PrimeNum
//    {
//        static bool Prime(int num)
//        {
//            if(num == 0 || num == 1)
//            {
//                return false;
//            }
//            for(int i=2; i<num; i++)
//            {
//                if(num%i == 0)
//                {
//                    return false;
//                }
//            }
//            return true;
//        }
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter the Number : ");
//            int N = Convert.ToInt32(Console.ReadLine());

//            for(int i = 0; i<N; i++)
//            {
//                if (Prime(i))
//                {
//                    Console.Write(i + " ");
//                }
//            }
//        }
//    }
//}
