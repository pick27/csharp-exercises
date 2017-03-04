using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace studio32
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("starting");
            string lookAt = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";

            // try reading from a file
            string path = "Test.txt";
            if (File.Exists(path))
            { 
                lookAt = File.ReadAllText(path);
                Console.WriteLine("read from file");
            }
            else
            {
                Console.WriteLine("could not read from file.");
                Console.WriteLine(path);
            }

            // make counts case insensitive
            lookAt = lookAt.ToLower();

            Dictionary<char, int> counts = new Dictionary<char, int>();

            Console.WriteLine("start reading");
            foreach(char ch in lookAt)
            {
                if (!('A' <= ch && ch <= 'Z' || 'a' <= ch && ch <= 'z'))
                {
                    // exclude non-alphabetic characters 
                }
                else if (counts.ContainsKey(ch))
                {
                    counts[ch] += 1;
                }
                else
                {
                    counts.Add(ch,1);
                }
            }

            Console.WriteLine("try displaying counts");
            foreach(KeyValuePair<char,int> row in counts.OrderBy(key => key.Key))
                {
                Console.WriteLine(string.Format("{0}: {1}", row.Key, row.Value));
            }
            Console.WriteLine("done. press return to exit program.");
            Console.ReadLine();
        }
    }
}
