using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MilesPerGallon
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Single miles, gallons, mpg;

            Console.WriteLine("Miles per Gallon");
            Console.Write("Miles driven? ");
            miles = Single.Parse(Console.ReadLine());
            Console.Write("Gallons used? ");
            gallons = Single.Parse(Console.ReadLine());

            mpg = miles / gallons;

            Console.WriteLine("Your miles per gallon is: " + mpg);
            Console.ReadLine();
        }
    }
}
