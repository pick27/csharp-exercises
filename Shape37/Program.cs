using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shapes37
{
    public class AbstractEntity
    {
        private int id;
        private static int nextUniqueId = 1;

        public int Id
        {
            get { return id; }
        }

        public AbstractEntity()
        {
            id = nextUniqueId;
            nextUniqueId++;
        }
    }

    public class Shape:AbstractEntity
    {
        // didn't want to make a point type too
        private string location;

        public string Location
        {
            get { return this.location; }
            set { this.location = value; }
        }

        public Shape(string location)
        {
            Location = location;
        }

        //  public virtual double area() { }
        //  public virtual double perimeter() { }
    }

    public class Circle : Shape
    {
        private double radius;

        public double Radius
        {
            get { return this.radius; }
            set { this.radius = value; }
        }

        public Circle(string location, double radius) : base(location)
        {
            Radius = radius;
        }

        public double area()
        {
            return (Math.PI * Radius * Radius);
        }

        //  public double perimeter()
        //  {
        //      return (2 * Math.PI * Radius);
        //  }

        public override string ToString()
        {
            return "Type: Circle; Radius: " + Radius;
        }
    }



    public class Rectangle : Shape
    {
        private double length;
        private double width;

        public double Length
        {
            get { return this.length; }
            set { this.length = value; }
        }

        public double Width
        {
            get { return this.width; }
            set { this.width = value; }
        }

        public Rectangle(string location, double length, double width) : base(location)
        {
            Length = length;
            Width = width;
        }

        public virtual double area()
        {
            return (Length * Width);
        }

        //  public double perimeter()
        //  {
        //      return (2 * (Length + Width));
        //  }

        public override string ToString()
        {
            return "Type: Rectangle; Length: " + Length + "; Width: " + Width;
        }
    }

    public class Square : Rectangle
    {
        public Square(string location, double side) : base(location, side, side)
        {
            // base class will enter values
        }

        public override double area()
        {
            return (Length * Width);
        }

        //  public double perimeter()
        //  {
        //      return (4 * Length);
        //  }

        public override string ToString()
        {
            return "Type: Square; Side: " + Length;
        }
    }


    public class Program
    {
        public static void Main(string[] args)
        {
            Circle a = new Circle("0,0", 3.14);
            Console.WriteLine(a.ToString());
            Console.WriteLine("My unique Id is: " + a.Id + ";  My type is:" + a.GetType());
            Console.WriteLine("area of circle: " + a.area());

            Rectangle b = new Rectangle("1,1", 3.14, 4.13);
            Console.WriteLine(b.ToString());
            Console.WriteLine("My unique Id is: " + b.Id + ";  My type is:" + b.GetType());
            Console.WriteLine("area of rectangle: " + b.area());

            Square c = new Square("2,2", 4.13);
            Console.WriteLine(c.ToString());
            Console.WriteLine("My unique Id is: " + c.Id + ";  My type is:" + c.GetType());
            Console.WriteLine("area of square: " + c.area());

            Console.ReadLine();
        }
    }
}
