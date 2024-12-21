using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Sum of digit of given String 
            //Console.Write("Enter an integer: ");
            //string input = Console.ReadLine();

            //if (int.TryParse(input, out int number))
            //{   

            //    int sum = SumDigit.Calculate(Math.Abs(number)); 
            //    Console.WriteLine($"The sum of the digits of {number} is: {sum}");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid integer.");
            //}

            // Decimal to Binary 
            //Console.Write("Enter a decimal number: ");
            //string input = Console.ReadLine();

            //// Validate input
            //if (int.TryParse(input, out int decimalNumber))
            //{
            //    string binaryEquivalent = DecToBin.ConvertToBinary(decimalNumber);
            //    Console.WriteLine($"The binary equivalent of {decimalNumber} is: {binaryEquivalent}");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid integer.");
            //}


            // Permutations 
            //Console.Write("Enter a string to generate permutations: ");
            //string input = Console.ReadLine();

            //Console.WriteLine("Permutations of the string are:");
            //Permutations.GeneratePermutations(input, 0, input.Length - 1);

            // Remove Vowels from String
            //Console.Write("Enter a string: ");
            //string input = Console.ReadLine();

            //string result = RemVowels.RemoveVowels(input);
            //Console.WriteLine($"String after removing vowels: {result}");


            // Compound Interest
            Console.Write("Enter the principal amount: ");
            if (!double.TryParse(Console.ReadLine(), out double principal) || principal < 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive number for the principal.");
                return;
            }

            Console.Write("Enter the annual interest rate in Percentage : ");
            if (!double.TryParse(Console.ReadLine(), out double rate) || rate < 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive number for the interest rate.");
                return;
            }

            Console.Write("Enter the time period in Years : ");
            if (!int.TryParse(Console.ReadLine(), out int time) || time < 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive number for the time.");
                return;
            }

            Console.Write("Enter the number of times interest is compounded per year: ");
            if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive number for compounding frequency.");
                return;
            }

            double compoundInterest = ComInt.CalculateComInt(principal, rate, time, n);
            Console.WriteLine($"The compound interest is: {compoundInterest:C}");







        }
    }
}
