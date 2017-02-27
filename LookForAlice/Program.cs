using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LookForAlice
{
    public class Program
    {

        public static Boolean CaseSensitive(String find, String bigString)
        {
            if (bigString.IndexOf(find,StringComparison.Ordinal) >= 0) 
                return true;
            else
                return false;
        }

        public static Boolean CaseInsensitive(String find, String bigString)
        {
            if (bigString.IndexOf(find, StringComparison.OrdinalIgnoreCase) >= 0)
                return true;
            else
                return false;
        }

        public static void Main(string[] args)
        {
            string firstSentence = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";
            string lookForAlice;

            Console.WriteLine("What string would you like to look for?");
            lookForAlice = Console.ReadLine();

            Console.WriteLine("Case sensitive answer: " + CaseSensitive(lookForAlice, firstSentence));
            Console.WriteLine("Case insensitive answer: " + CaseInsensitive(lookForAlice, firstSentence));
            Console.ReadLine();
        }
    }
}
