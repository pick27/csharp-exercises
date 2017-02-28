using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Area
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double radius, area;
            double pi = 3.14;
            string temp;
            bool isNumeric;
            Console.Write("Enter a radius? ");
            temp = Console.ReadLine();
            isNumeric = double.TryParse(temp, out radius);

            while (radius < 0 |  !isNumeric)
            {
                Console.WriteLine("You gave a bad answer. Please try again.");
                Console.Write("Enter a radius? ");
                temp = Console.ReadLine();
                isNumeric = double.TryParse(temp, out radius);
            }
            area = pi * radius * radius;
            Console.WriteLine("The area of a circle of radius " + radius + " is: " + area);
            Console.ReadLine();
        }
    }
}
