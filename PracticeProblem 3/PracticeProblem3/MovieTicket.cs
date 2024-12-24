using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem3
{
    internal class MovieTicket
    {

        public void CalculateTicketPrice()
        {
            Console.WriteLine("Welcome to the Movie Ticket System!");

            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Enter the time of the movie (e.g., 14 for 2 PM): ");
            int time = int.Parse(Console.ReadLine());

            double price;
            if (age < 12)
            {
                price = time < 17 ? 150 : 200;
            }
            else if (age >= 65)
            {
                price = time < 17 ? 100 : 150;
            }
            else
            {
                price = time < 17 ? 250 : 300;
            }

            Console.WriteLine($"The ticket price is : {price:0} Rupees");
        }

        public bool ValidateLogin()
        {
            Console.WriteLine("Login System");

            string correctUsername = "user123";
            string correctPassword = "pass123";

            Console.Write("Enter username: ");
            string username = Console.ReadLine();

            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            if (username != correctUsername)
            {
                Console.WriteLine("Incorrect username.");
                Console.ReadKey();
                return false;
            }
            else if (password != correctPassword)
            {
                Console.WriteLine("Incorrect password.");
                Console.ReadKey();
                return false;

            }
            else
            {
                Console.WriteLine("Login successful!");
                return true;

            }
        }
    }
}
