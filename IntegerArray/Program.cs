using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntegerArray
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] fib = { 1, 1, 2, 3, 5, 8 };
            for (int i = 0; i < fib.Length; i++)
            {
                Console.WriteLine(fib[i]);
            }
            Console.ReadLine();
        }
    }
}
