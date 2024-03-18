using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace С__Lab_0
{
    abstract class Figure
    {
        abstract public double Perimeter();
        abstract public double Square_area();
        abstract public void Reset();
        abstract public void Print();
    }
    class Square : Figure
    {
        public int Hight { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public Square(int x = 0, int y = 0, int hight = 0)
        {
            X = x;
            Y = y;
            Hight = hight;
        }
        public bool Check_square()
        {
            return Hight > 0;
        }
        public override void Reset()
        {
            X = 0;
            Y = 0;
            Hight = 0;
        }
        public override double Perimeter() { return 4 * Hight; }
        public override double Square_area() { return Hight * Hight; }
        public override void Print() { Console.WriteLine("Perimeter: " + Perimeter() + " Square: " + Square_area()); }
    }
    class Rectangle : Square
    {
        public int Width { get; set; }

        public Rectangle(int x = 0, int y = 0, int hight = 0, int width = 0)
            : base(x, y, hight)
        {
            Width = width;
        }

        public bool Check_rectangle()
        {
            return Width > 0 && Hight > 0;
        }
        public override void Reset()
        {
            base.Reset();
            Width = 0;
        }
        public override double Perimeter() { return (Hight + Width) * 2; }
        public override double Square_area() { return Hight * Width; }


    }
    class Triangle : Figure
    {
        public int x1 { get; set; }
        public int x2 { get; set; }
        public int x3 { get; set; }
        public int y1 { get; set; }
        public int y2 { get; set; }
        public int y3 { get; set; }


        public Triangle(int _x1 = 0, int _x2 = 0, int _x3 = 0, int _y1 = 0, int _y2 = 0, int _y3 = 0)
        {
            x1 = _x1;
            x2 = _x2;
            x3 = _x3;
            y1 = _y1;
            y2 = _y2;
            y3 = _y3;
        }

      
        public bool Check_triangle()
        {
            double a, b, c, e = 1e-8;

            a = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            b = Math.Sqrt((x3 - x1) * (x3 - x1) + (y3 - y1) * (y3 - y1));
            c = Math.Sqrt((x2 - x3) * (x2 - x3) + (y2 - y3) * (y2 - y3));

            return a - b - c < -e && b - c - a < -e && c - a - b < -e;
        }
        public override void Reset()
        {
            x1 = x2 = x3 = y1 = y2 = y3 = 0;
        }
        public override double Perimeter()
        {
            return Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1)) + Math.Sqrt((x3 - x1) * (x3 - x1) + (y3 - y1) * (y3 - y1)) + Math.Sqrt((x2 - x3) * (x2 - x3) + (y2 - y3) * (y2 - y3));
        }

        public override double Square_area()
        {
            return Math.Abs(0.5 * (x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2)));
        }
        public override void Print()
        {
            Console.WriteLine("Perimeter: " + Perimeter() + " Square: " + Square_area());
        }

    }
    class Circle : Figure
    {
        public int radius { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public Circle(int x = 0, int y = 0, int _radius = 0)
        {
            radius = _radius;
            X = x;
            Y = y;
        }
        public override void Reset()
        {
            X = 0;
            Y = 0;
            radius = 0;
        }
        public bool Check_circle()
        {
            return radius > 0;
        }
        public override double Perimeter()
        {
            return 2 * radius * Math.PI;
        }

        public override void Print()
        {
            Console.WriteLine("Perimeter: " + Perimeter() + " Square: " + Square_area());
        }

        public override double Square_area()
        {
            return Math.PI * radius * radius;
        }
    }


}
