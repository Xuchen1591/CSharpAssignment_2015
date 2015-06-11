using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CourseAssignment
{
    public class Shape
    {
        public const double PI = 3.14;
        protected double x, y;
        public string type;

        public Shape()
        { }

        public Shape(double _x, double _y)
        {
            x = _x;
            y = _y;
        }

        public virtual double myArea()
        {
            return x * y;
        }
        public virtual void printSelfInfo()
        {
            Console.Write("and my area is {0}",this.myArea());
        }

        public virtual Shape clone()
        {
            return new Shape(x,y);
        }
    }

    public class Ellipse : Shape
    {
        private double semi_major_axis, semi_minor_axis;
        private new string type = "Ellipse";

        public double Semi_major_axis { set; get; }
        public double Semi_minor_axis { set; get; }

        public Ellipse(double _semi_major_axis, double _semi_minor_axis):
            base(_semi_major_axis,_semi_minor_axis)
        {
            semi_major_axis = _semi_major_axis;
            semi_minor_axis = _semi_minor_axis;
        }

        public override double myArea()
        {
            return base.myArea()*PI;
            //return PI * semi_minor_axis * semi_major_axis;
        }

        public override void printSelfInfo()
        {
            Console.WriteLine("I am a {0} with major axis:{1}, minor axis:{2}", this.type,semi_major_axis,semi_minor_axis);
            Console.WriteLine("my area is {0}",this.myArea());
            Console.WriteLine();
        }

        public override Shape clone()
        {
            //return base.clone();
            return new Ellipse(semi_major_axis,semi_minor_axis);
        }
    }

    public class Rectangle : Shape
    {
        private double length, width;
        private new string type = "Rectangle";

        public double Length { set; get; }
        public double Width { set; get; }

        public Rectangle(double _length, double _width) :
            base(_length, _width)
        {
            length = _length;
            width = _width;
        }

        public override double myArea()
        {
            return base.myArea();
            //return PI * semi_minor_axis * semi_major_axis;
        }

        public override void printSelfInfo()
        {
            Console.WriteLine("I am a {0} with length:{1}, width:{2}", this.type, length,width);
            Console.WriteLine("my area is {0}", this.myArea());
            Console.WriteLine();
        }

        public override Shape clone()
        {
            //return base.clone();
            return new Rectangle(length,width);
        }
    }

    public class Triangle : Shape
    {
        private double altitude, length_of_base;
        private new string type = "Triangle";

        public double Altitude { set; get; }
        public double Length_of_base { set; get; }

        public Triangle(double _altitude, double _length_of_base) :
            base(_altitude, _length_of_base)
        {
            altitude = _altitude;
            length_of_base = _length_of_base;
        }

        public override double myArea()
        {
            return base.myArea()/2;
            //return PI * semi_minor_axis * semi_major_axis;
        }

        public override void printSelfInfo()
        {
            Console.WriteLine("I am a {0} with altitude:{1}, length of base:{2}", this.type, altitude,length_of_base);
            Console.WriteLine("my area is {0}", this.myArea());
            Console.WriteLine();
        }

        public override Shape clone()
        {
            //return base.clone();
            return new Triangle(altitude, length_of_base);
        }
    }

    public class Circle:Ellipse
    {
        private double radius;
        private new string type = "Circle";
        public double Radius { set; get; }

        public Circle(double _radius):base(_radius,_radius)
        {
            radius = _radius;
        }

        public override double myArea()
        {
            return base.myArea();
            //return PI * radius * radius;
        }

        public override void printSelfInfo()
        {
            //base.printSelfInfo();
            Console.WriteLine("I am a {0} with radius:{1}", this.type,this.radius);
            Console.WriteLine("my area is {0}", this.myArea());
            Console.WriteLine();
        }

        public override Shape clone()
        {
            //return base.clone();
            return new Circle(radius);
        }
    }

    public class Square : Shape
    {
        private double edge;
        private new string type = "Square";
        public double Edge { set; get; }

        public Square(double _edge):base(_edge,_edge)
        {
            edge = _edge;
        }

        public override double myArea()
        {
            return base.myArea();
            //return PI * edge * edge;
        }

        public override void printSelfInfo()
        {
            //base.printSelfInfo();
            Console.WriteLine("I am a {0} with edge:{1}", this.type,this.edge);
            Console.WriteLine("my area is {0}", this.myArea());
            Console.WriteLine();
        }

        public override Shape clone()
        {
            //return base.clone();
            return new Square(edge);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Shape elps = new Ellipse(3, 4);
            Shape ckl = new Circle(3);
            Shape rktg = new Rectangle(3, 5);
            Shape tri = new Triangle(4,4);
            Square skl = new Square(5);

            elps.printSelfInfo();
            ckl.printSelfInfo();
            rktg.printSelfInfo();
            tri.printSelfInfo();
            skl.printSelfInfo();
        }
    }
}
