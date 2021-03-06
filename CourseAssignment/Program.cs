﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CourseAssignment
{
    public class Shape
    {
        //properties for all shapes
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

        //calculate shape area use custimized parameters
        public virtual double myArea()
        {
            return x * y;
        }

        //print shape information
        public virtual void printSelfInfo()
        {
            Console.Write("and my area is {0}",this.myArea());
        }

        //clone Shape classes 
        //return a <Shape> type Object
        public virtual Shape clone()
        {
            return new Shape(x,y);
        }
    }

    //sub class inherit from base class: Shape
    public class Ellipse : Shape
    {
        //ellipse's own properties
        private double semi_major_axis, semi_minor_axis;
        private new string type = "Ellipse";

        //attribute methods for operating private properties
        public double Semi_major_axis { set; get; }
        public double Semi_minor_axis { set; get; }

        //construct method use base construct method
        public Ellipse(double _semi_major_axis, double _semi_minor_axis):
            base(_semi_major_axis,_semi_minor_axis)
        {
            semi_major_axis = _semi_major_axis;
            semi_minor_axis = _semi_minor_axis;
        }

        //calculate area using base myArea() method
        public override double myArea()
        {
            return base.myArea()*PI;
            //return PI * semi_minor_axis * semi_major_axis;
        }

        //print self information using base printSelfInfo() method
        public override void printSelfInfo()
        {
            Console.WriteLine("I am a {0} with major axis:{1}, minor axis:{2}", this.type,semi_major_axis,semi_minor_axis);
            Console.WriteLine("my area is {0}",this.myArea());
            Console.WriteLine();
        }

        //clone Ellipse object
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

        //attribute methods for operating private properties
        public double Length { set; get; }
        public double Width { set; get; }

        //construct method use base construct method
        public Rectangle(double _length, double _width) :
            base(_length, _width)
        {
            length = _length;
            width = _width;
        }

        //calculate area using base myArea() method
        public override double myArea()
        {
            return base.myArea();
            //return PI * semi_minor_axis * semi_major_axis;
        }

        //print self information using base printSelfInfo() method
        public override void printSelfInfo()
        {
            Console.WriteLine("I am a {0} with length:{1}, width:{2}", this.type, length,width);
            Console.WriteLine("my area is {0}", this.myArea());
            Console.WriteLine();
        }

        //clone Rectangle object
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

        //attribute methods for operating private properties
        public double Altitude { set; get; }
        public double Length_of_base { set; get; }

        //construct method use base construct method
        public Triangle(double _altitude, double _length_of_base) :
            base(_altitude, _length_of_base)
        {
            altitude = _altitude;
            length_of_base = _length_of_base;
        }

        //calculate area using base myArea() method
        public override double myArea()
        {
            return base.myArea()/2;
            //return PI * semi_minor_axis * semi_major_axis;
        }

        //print self information using base printSelfInfo() method
        public override void printSelfInfo()
        {
            Console.WriteLine("I am a {0} with altitude:{1}, length of base:{2}", this.type, altitude,length_of_base);
            Console.WriteLine("my area is {0}", this.myArea());
            Console.WriteLine();
        }

        //clone Triangle object
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

        //attribute methods for operating private properties
        public double Radius { set; get; }

        //construct method use base construct method
        public Circle(double _radius):base(_radius,_radius)
        {
            radius = _radius;
        }

        //calculate area using base myArea() method
        public override double myArea()
        {
            return base.myArea();
            //return PI * radius * radius;
        }

        //print self information using base printSelfInfo() method
        public override void printSelfInfo()
        {
            //base.printSelfInfo();
            Console.WriteLine("I am a {0} with radius:{1}", this.type,this.radius);
            Console.WriteLine("my area is {0}", this.myArea());
            Console.WriteLine();
        }

        //clone Circle object
        public override Shape clone()
        {
            //return base.clone();
            return new Circle(radius);
        }
    }

    public class Square : Rectangle
    {
        private double edge;
        private new string type = "Square";

        //attribute methods for operating private properties
        public double Edge { set; get; }

        //construct method use base construct method
        public Square(double _edge):base(_edge,_edge)
        {
            edge = _edge;
        }

        //calculate area using base myArea() method
        public override double myArea()
        {
            return base.myArea();
            //return PI * edge * edge;
        }

        //print self information using base printSelfInfo() method
        public override void printSelfInfo()
        {
            //base.printSelfInfo();
            Console.WriteLine("I am a {0} with edge:{1}", this.type,this.edge);
            Console.WriteLine("my area is {0}", this.myArea());
            Console.WriteLine();
        }
          
        //clone Square obkect
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
            /*
             * class test
             * 
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
             * */

            //reflection type test
            /*
            Shape xuchen = new Circle(3);
            System.Type type = xuchen.GetType();
            Console.WriteLine(type);
            */

            //new List<Shape> to store all user shapes
            List<Shape> shapeList = new List<Shape>();

            while(true)
            {
                //user guide
                Console.WriteLine("input the Shape you want, choose one from below:");
                Console.WriteLine("1 for CIRCLE");
                Console.WriteLine("2 for ELLIPSE");
                Console.WriteLine("3 for RECTANGLE");
                Console.WriteLine("4 for TRIANGLE");
                Console.WriteLine("5 for SQUARE");
                Console.WriteLine(">>>input '110' to exit<<<");
                string userShape = Console.ReadLine();

                //input loop
                switch (userShape)
                {
                    //input as Circle
                    case "1":
                        Console.WriteLine("please input RADIUS of your circle:");
                        string userStringRadius = Console.ReadLine();
                        double radius = System.Convert.ToDouble(userStringRadius);
                        Shape userCircle = new Circle(radius);
                        shapeList.Add(userCircle.clone());
                        Console.WriteLine();
                        Console.WriteLine();
                        break;

                    //input as Ellipse
                    case "2":
                        Console.WriteLine("please input SEMI_MAJOR_AXIS of your ellipse:");
                        string userStringMajor = Console.ReadLine();
                        Console.WriteLine("please input SEMI_MINOR_AXIS of your ellipse:");
                        string userStringMinor = Console.ReadLine();
                        double semi_major_axis = System.Convert.ToDouble(userStringMajor);
                        double semi_minor_axis = System.Convert.ToDouble(userStringMinor);
                        Shape userEllipse = new Ellipse(semi_major_axis, semi_minor_axis);
                        shapeList.Add(userEllipse.clone());
                        Console.WriteLine();
                        Console.WriteLine();
                        break;

                    //input as rectangle
                    case "3":
                        Console.WriteLine("please input LENGTH of your rectangle:");
                        string userStringLength = Console.ReadLine();
                        Console.WriteLine("please input WIDTH of your rectangle:");
                        string userStringWidth = Console.ReadLine();
                        double length = System.Convert.ToDouble(userStringLength);
                        double width = System.Convert.ToDouble(userStringWidth);
                        Shape userRectangle = new Rectangle(length, width);
                        shapeList.Add(userRectangle.clone());
                        Console.WriteLine();
                        Console.WriteLine();
                        break;

                    //input as triangle
                    case "4":
                        Console.WriteLine("please input ALTITUDE of your triangle:");
                        string userStringAltitude = Console.ReadLine();
                        Console.WriteLine("please input LENGTH_OF_BASE of your triangle:");
                        string userStringBase = Console.ReadLine();
                        double altitude = System.Convert.ToDouble(userStringAltitude);
                        double lengthOfBase = System.Convert.ToDouble(userStringBase);
                        Shape userTriangle = new Triangle(altitude, lengthOfBase);
                        shapeList.Add(userTriangle.clone());
                        Console.WriteLine();
                        Console.WriteLine();
                        break;

                    //input as quare
                    case "5":
                        Console.WriteLine("please input EDGE of your square:");
                        string userStringEdge = Console.ReadLine();
                        double edge = System.Convert.ToDouble(userStringEdge);
                        Shape userSquare = new Square(edge);
                        shapeList.Add(userSquare.clone());
                        Console.WriteLine();
                        Console.WriteLine();
                        break;

                    //stop input 
                    case "110":
                        goto outofWhile;

                    //remind message
                    default:
                        Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
                        Console.WriteLine("    Remind: must input shape from shape list!    ");
                        Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
                        Console.WriteLine();
                        Console.WriteLine();
                        break;

                }
            }

        //stop input goes to here
        outofWhile:
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(">>>All shape you added self description:");
            foreach (Shape s in shapeList)
            {
                //reflection to check type
                //Console.WriteLine(s.GetType());
                if(s.GetType() == typeof(Circle)
                    || s.GetType() == typeof(Ellipse)
                    || s.GetType() == typeof(Rectangle)
                    || s.GetType() == typeof(Triangle)
                    || s.GetType() == typeof(Square))
                    //output all shape info
                    s.printSelfInfo();
            }
        }
    }
}
