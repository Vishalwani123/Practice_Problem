//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace PracticeProblem
//{
//    internal class ReverseWords
//    {
//        static string ReverseStr(string str)
//        {
//            string[] word = str.Split(' ');
//            for(int i = 0; i<word.Length; i++)
//            {
//                word[i] = Reverse(word[i]);
//            }
//            return string.Join(" ", word);
            
//        }
//        static string Reverse(string s)
//        {
//            char[] charArray = s.ToCharArray();
//            Array.Reverse(charArray);
//            return new string (charArray);
//        }
//        static void Main(string[] args)
//        {
//            Console.WriteLine();
//            Console.WriteLine("Enter the Sentence : ");
//            string str = Console.ReadLine();

//            string reversestr = ReverseStr(str);
//            Console.WriteLine();
//            Console.WriteLine("The Reverse of the words in Sentence are : ");
//            Console.WriteLine(reversestr);

//        }
//    }
//}
