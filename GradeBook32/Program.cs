using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace GradeBook32
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<int, string> students = new Dictionary<int, string>();
            string newName;

            Console.WriteLine("Enter a student's info (or ENTER to finish):");
            do
            {
                Console.Write("name: ");
                newName = Console.ReadLine();
                if (newName != "")
                {
                    // Get the student's ID
                    Console.Write("ID: ");
                    int newID = int.Parse(Console.ReadLine());

                    students.Add(newID, newName);
                }
            }
            while (newName != "");

            StringBuilder sb = new StringBuilder("\nSchool Roster");
            // Console.WriteLine("\nSchool roster:");
            foreach (KeyValuePair<int, string> student in students.OrderBy(key => key.Value))
            {
                sb.Append(string.Format("\n{0} ({1})", student.Value, student.Key));
                // Console.WriteLine(string.Format("{0} ({1})", student.Value, student.Key));
            }
            Console.WriteLine(sb.ToString());
            Console.ReadLine();
        }
    }
}
