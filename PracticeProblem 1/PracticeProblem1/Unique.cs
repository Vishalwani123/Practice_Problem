//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Security.Cryptography;
//using System.Text;
//using System.Threading.Tasks;

//namespace PracticeProblem
//{
//    internal class Unique
//    {
//        static bool UniqueString(string str)
//        {
//            if (str == null)
//            {
//                Console.WriteLine("Please Enter String to check it has Unique Character");
//            }
            
//            for(int i = 0; i < str.Length - 1;i++)
//            {
//                for(int j = i+1; j < str.Length; j++)
//                {
//                    if(str[i] == str[j])
//                    {
//                        return false;
//                    }
//                }
//            }
//            return true;
//        }
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter the String : ");
//            String s = Console.ReadLine();
            
//            if (UniqueString(s))
//            {
//                Console.WriteLine("The String has Unique Characters. ");

//            }
//            else
//            {
//                Console.WriteLine("The String does not have Unique Characters. ");

//            }
//        }
//    }
//}
