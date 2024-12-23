using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Problem_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Cartesian System 
            Console.WriteLine("Enter coordinates for the first point (x1, y1):");
            Console.Write("x1: ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y1: ");
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter coordinates for the second point (x2, y2):");
            Console.Write("x2: ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y2: ");
            double y2 = Convert.ToDouble(Console.ReadLine());


            CartesianSys cs = new CartesianSys(x1, y1, x2, y2);


            double length = cs.CalculateLength();
            Console.WriteLine("The length of the line is: " + length);


            // Line are Equal, Greater, or Lesser
            Console.WriteLine("Enter coordinates for Line 1:");
            Console.Write("x1: ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y1: ");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("x2: ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y2: ");
            double y2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter coordinates for Line 2:");
            Console.Write("x3: ");
            double x3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y3: ");
            double y3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("x4: ");
            double x4 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y4: ");
            double y4 = Convert.ToDouble(Console.ReadLine());

            EqualGreatLess line1 = new EqualGreatLess(x1, y1, x2, y2);
            EqualGreatLess line2 = new EqualGreatLess(x3, y3, x4, y4);

            double l1 = line1.CalculateLength();
            double l2 = line2.CalculateLength();

            int status = l1.CompareTo(l2);

            if (status > 0)
            {
                Console.WriteLine("Line 1 is greater than Line 2.");
            }
            else if (status < 0)
            {
                Console.WriteLine("Line 1 is less than Line 2.");
            }
            else
            {
                Console.WriteLine("The two lines are equal.");
            }
        }
    }
}
