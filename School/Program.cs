using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School
{
    public class Student
    {
        string name;
        int studentId;
        int numberOfCredits;
        double gpa;

        public string Name { get; set; }

        public int StudentId { get; set; }

        public int NumberOfCredits
        {
            get { return numberOfCredits; }
            internal set { numberOfCredits = value; }
        }

        public double Gpa
        {
            get { return gpa; }
            internal set { gpa = value; }
        }
    }


    public class Course
    {
        string name;
        int courseId;
        int numberOfCredits;
        string instructor;
        Student[] students;

        public string Name { get; set; }

        public int CourseId { get; set; }

        public int NumberOfCredits
        {
            get { return numberOfCredits; }
            internal set { numberOfCredits = value; }
        }

        public string Instructor { get; set; }

        public Student[] Students
        {
            get { return students; }
            internal set { students = value; }
        }
    }


    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("just checking to see if it compiles.");
            Console.WriteLine("but that doesn't mean much.");

            Console.ReadLine();
        }
    }
}
