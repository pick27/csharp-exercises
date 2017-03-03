using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiveLetterWords
{
    public class Program
    {
        public static void PrintEm(List<string> them)
        {
            foreach (string word in them)
            {
                if (word.Length == 5)
                {
                    Console.WriteLine(word);
                }
            }
        }
        public static void Main(string[] args)
        {
            List<string> test = new List<string>();
            test.Add("first");
            test.Add("second");
            test.Add("Third");
            test.Add("fourth");
            test.Add("fifth");
            test.Add("sixth");
            test.Add("seventh");
            PrintEm(test);

            Console.ReadLine();
        }
    }
}
