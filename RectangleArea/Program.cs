using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RectangleArea
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Single length, width, perimeter;
            Double area;

            Console.WriteLine("Area of Rectangle (beyond the integer)");
            Console.WriteLine("What is the length?");
            length = Single.Parse( Console.ReadLine() );
            Console.WriteLine("What is the width?");
            width = Single.Parse(Console.ReadLine());

            area = length * width;
            perimeter = (width * 2) + (length * 2);

            Console.WriteLine("The area of the rectangle is: " + area);
            Console.WriteLine("Bonus: The perimeter is: " + perimeter);
            Console.ReadLine();
        }
    }
}
