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
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
            Console.WriteLine("Hello " + name);
            Console.ReadLine();
        }
    }
}
