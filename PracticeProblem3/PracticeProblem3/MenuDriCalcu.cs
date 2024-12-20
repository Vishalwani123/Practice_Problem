using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PracticeProblem3;

namespace PracticeProblem3
{
    internal class MenuDriCalcu
    {
        bool continueCalculation = true;

        public void Display()
        {
            while (continueCalculation)
            {
                Console.WriteLine("Menu-Driven Calculator");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Exit");

                Console.Write("Enter your choice (1-5): ");
                string choice = Console.ReadLine();

                if (choice == "5")
                {
                    Console.WriteLine("Exiting the calculator. Goodbye!");
                    continueCalculation = false;
                    break;
                }

                Console.Write("Enter the first number: ");
                bool b1 = double.TryParse(Console.ReadLine(), out double num1);
                if (b1 == false)
                {
                    Console.WriteLine("Invalid input. Please enter a valid first number.");
                    continueCalculation = false;
                    continue;
                }

                Console.Write("Enter the second number: ");
                bool b2 = double.TryParse(Console.ReadLine(), out double num2);
                if (b2 == false)
                {
                    Console.WriteLine("Invalid input. Please enter a valid Second number.");
                    continueCalculation = false;
                    continue;
                }

                MenuDriCalcu cal = new MenuDriCalcu();
                double result;

                switch (choice)
                {
                    case "1":
                        result = Add(num1, num2);
                        Console.WriteLine($"Result: {num1} + {num2} = {result}");
                        break;
                    case "2":
                        result = Subtract(num1, num2);
                        Console.WriteLine($"Result: {num1} - {num2} = {result}");
                        break;
                    case "3":
                        result = Multiply(num1, num2);
                        Console.WriteLine($"Result: {num1} * {num2} = {result}");
                        break;
                    case "4":
                        if (num2 == 0)
                        {
                            Console.WriteLine("Division by zero is not allowed.");
                        }
                        else
                        {
                            result = cal.Divide(num1, num2);
                            Console.WriteLine($"Result: {num1} / {num2} = {result}");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please select a valid option.");
                        break;
                }


            }
        }


        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }


        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Divide(double a, double b)
        {
            return a / b;
        }
    }
     
}

    //internal class Menudriven
    //{
                //bool continueCalculation = true;

                //while(continueCalculation)
                //{
                //        Console.WriteLine("Menu-Driven Calculator");
                //        Console.WriteLine("1. Addition");
                //        Console.WriteLine("2. Subtraction");
                //        Console.WriteLine("3. Multiplication");
                //        Console.WriteLine("4. Division");
                //        Console.WriteLine("5. Exit");

                //        Console.Write("Enter your choice (1-5): ");
                //        string choice = Console.ReadLine();

                //        if(choice == "5")
                //        {
                //            Console.WriteLine("Exiting the calculator. Goodbye!");
                //            continueCalculation = false;
                //            break;
                //        }

                //        Console.Write("Enter the first number: ");
                //        bool b1 = double.TryParse(Console.ReadLine(), out double num1);
                //        if (b1 == false)
                //        {
                //            Console.WriteLine("Invalid input. Please enter a valid first number.");

                //        }

                //        Console.Write("Enter the second number: ");
                //        bool b2 = double.TryParse(Console.ReadLine(), out double num2);
                //        if (b2 == false)
                //        {
                //            Console.WriteLine("Invalid input. Please enter a valid Second number.");

                //        }

                //        MenuDriCalcu cal = new MenuDriCalcu();
                //        double result;

                //        switch (choice)
                //        {
                //            case "1":
                //                result = MenuDriCalcu.Add(num1, num2);
                //                Console.WriteLine($"Result: {num1} + {num2} = {result}");
                //                break;
                //            case "2":
                //                result = MenuDriCalcu.Subtract(num1, num2);
                //                Console.WriteLine($"Result: {num1} - {num2} = {result}");
                //                break;
                //            case "3":
                //                result = MenuDriCalcu.Multiply(num1, num2);
                //                Console.WriteLine($"Result: {num1} * {num2} = {result}");
                //                break;
                //            case "4":
                //                if (num2 == 0)
                //                {
                //                    Console.WriteLine("Division by zero is not allowed.");
                //                }
                //                else
                //                {
                //                    result = cal.Divide(num1, num2);
                //                    Console.WriteLine($"Result: {num1} / {num2} = {result}");
                //                }
                //                break;
                //            default:
                //                Console.WriteLine("Invalid choice. Please select a valid option.");
                //                break;
                //        }
                //    }
       //}
        
 

