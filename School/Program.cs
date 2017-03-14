using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School
{
    public class Student
    {
        private string name;
        private readonly int studentId;
        private int numberOfCredits;
        private double gpa;

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

        public override string ToString()
        {
            return string.Format("{0} ({1})", Name, StudentId);
        }
    }


    public class Course
    {
        private string name;
        private readonly int courseId;
        private int numberOfCredits;
        private string instructor;
        private Student[] students;

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

        public override string ToString()
        {
            return string.Format("{0} ({1})", Name, CourseId);
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
