using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloYou
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string name;
            Console.Write("What is your name? ");
            name = Console.ReadLine();
            Console.WriteLine("Hello " + name);

            //  // string interpolation looks like this in CSharp
            //  Console.WriteLine(string.Format("Hello, {0}", name));
            Console.ReadLine();
        }
    }
}
