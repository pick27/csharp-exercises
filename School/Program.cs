using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School
{
    public class Student {
        private static int nextStudentId = 1;
        public string Name { get; set; }
        int StudentId { get; set; }
        public int NumberOfCredits { get; set; }
        public double Gpa { get; set; }

        public Student(string name, int studentId,
                int numberOfCredits, double gpa) { 
            Name = name;
            StudentId = studentId;
            NumberOfCredits = numberOfCredits;
            Gpa = gpa;
        }

        public Student(string name, int studentId)
            : this(name, studentId, 0, 0) { }

        public Student(string name)
            : this(name, nextStudentId) {
            nextStudentId++;
        }

        public void AddGrade(int courseCredits, double grade) {
            double totalQualityScore = Gpa * NumberOfCredits;
            NumberOfCredits += courseCredits;
            Gpa = totalQualityScore / totalQualityScore;
        }

        public string GetGradeLevel() {
            string gradeLevel = "";
            if (NumberOfCredits < 30) {
                gradeLevel = "Freshman";
            }
            else if (NumberOfCredits < 60) {
                gradeLevel = "Sophomore";
            }
            else if (NumberOfCredits < 90) {
                gradeLevel = "Junior";
            }
            else {
                gradeLevel = "Senior";
            }
            return gradeLevel;
        }

        public override string ToString() {
            return string.Format("{0} (Credits: {1}. GPA: {2})", Name, NumberOfCredits, Gpa);
        }

        public override bool Equals(object o)
        {
            Student studentObj = o as Student;
            return StudentId == studentObj.StudentId;
        }
    }


    public class Course {
        private static int nextInstanceId = 1;
        public string Name { get; set; }
        public int CourseId { get; set; }
        private int InstanceId { get; set; }
        public int NumberOfCredits { get; set; }
        public string Instructor { get; set; }
        public Student[] Students { get; set; }

        public Course(string name, int courseId,
        int numberOfCredits, string instructor) {
            Name = name;
            CourseId = courseId;
            NumberOfCredits = numberOfCredits;
            Instructor = instructor;
            InstanceId = nextInstanceId;
            nextInstanceId++;
        }

        public Course(string name, int courseId)
            : this(name, courseId, 0, "") { }

        public override string ToString()
        {
            return string.Format("{0} (CourseID: {1}. Instructor: {2})", Name, CourseId, Instructor);
        }

        public override bool Equals(object o)
        {
            Course courseObj = o as Course;
            return ((CourseId == courseObj.CourseId) && (InstanceId == courseObj.InstanceId));
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
