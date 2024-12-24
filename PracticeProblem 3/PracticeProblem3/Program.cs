using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Menu Driven Calculator
            //MenuDriCalcu md = new MenuDriCalcu();
            //md.Display();
            //Console.WriteLine("Press any key to Exits the windows. ");
            //Console.ReadKey();


            // Movie Ticket Problem
            MovieTicket MovTic = new MovieTicket();
            bool b = MovTic.ValidateLogin();
            if (b == true)
            {
                MovTic.CalculateTicketPrice();
            }
            else
            {
                return;
            }
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
