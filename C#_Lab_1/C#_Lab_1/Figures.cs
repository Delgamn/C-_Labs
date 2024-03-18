using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Figur
{
    abstract class Figure
    {
        abstract public double Perimeter();
        abstract public double Square_area();
        abstract public void Reset();
        abstract public void Print();
        abstract public void Input();
        abstract public String GetString();
    }
    class Square(int x = 0, int y = 0, int hight = 0) : Figure
    {
        public int Hight { get; set; } = hight;
        public int X { get; set; } = x;
        public int Y { get; set; } = y;

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
        public override void Print() { Console.WriteLine(GetString()); }
        public override void Input()
        {
            Console.WriteLine("Введите высоту стороны:");
            Hight = Convert.ToInt32(Console.ReadLine());
        }
        public override string GetString()
        {
            return "Hight: " + Hight + " Perimeter: " + Perimeter() + " Square: " + Square_area();
        }
    }
    class Rectangle(int x = 0, int y = 0, int hight = 0, int width = 0) : Square(x, y, hight)
    {
        public int Width { get; set; } = width;

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
        public override void Input()
        {
            base.Input();
            Console.WriteLine("Введите ширину стороны:");
            Width = Convert.ToInt32(Console.ReadLine());
        }
        public override void Print()
        {
            Console.WriteLine(GetString());
        }
        public override string GetString()
        {
            return "Hight: " + Hight + " Width: " + Width + " Perimeter: " + Perimeter() + " Square: " + Square_area();
        }

    }
    class Triangle(int _x1 = 0, int _x2 = 0, int _x3 = 0, int _y1 = 0, int _y2 = 0, int _y3 = 0) : Figure
    {
        public int x1 { get; set; } = _x1;
        public int x2 { get; set; } = _x2;
        public int x3 { get; set; } = _x3;
        public int y1 { get; set; } = _y1;
        public int y2 { get; set; } = _y2;
        public int y3 { get; set; } = _y3;

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
            Console.WriteLine(GetString());
        }
        public override void Input()
        {
            Console.WriteLine("Введите три пары координат построчно:");
            string str;
            string[] str2;
            do
            {
                try
                {
                    str = Console.ReadLine();
                    str2 = str.Split(' ');
                    x1 = Convert.ToInt32(str2[0]);
                    y1 = Convert.ToInt32(str2[1]);

                    str = Console.ReadLine();
                    str2 = str.Split(' ');
                    x2 = Convert.ToInt32(str2[0]);
                    y2 = Convert.ToInt32(str2[1]);

                    str = Console.ReadLine();
                    str2 = str.Split(' ');
                    x3 = Convert.ToInt32(str2[0]);
                    y3 = Convert.ToInt32(str2[1]);
                    break;
                }
                catch (Exception e) { Console.WriteLine(e.Message); }
            } while (true);
        }
        public override string GetString()
        {
            return "Point№1(" + x1.ToString() + ", " + y1.ToString() + ")\n" +
                " Point№2(" + x2.ToString() + ", " + y2.ToString() + ")\n" +
                " Point№3(" + x3.ToString() + ", " + y3.ToString() + ")\n" +
                "Perimeter: " + Perimeter() + " Square: " + Square_area();
        }
    }
    class Circle(int x = 0, int y = 0, int radius = 0) : Figure
    {
        public int Radius { get; set; } = radius;
        public int X { get; set; } = x;
        public int Y { get; set; } = y;

        public override void Reset()
        {
            X = 0;
            Y = 0;
            Radius = 0;
        }
        public bool Check_circle()
        {
            return Radius > 0;
        }
        public override double Perimeter()
        {
            return 2 * Radius * Math.PI;
        }

        public override void Print()
        {
            Console.WriteLine();
        }

        public override double Square_area()
        {
            return Math.PI * Radius * Radius;
        }

        public override void Input()
        {
            Console.WriteLine("Введите радиус круга:");
            Radius = Convert.ToInt32(Console.ReadLine());
        }

        public override string GetString()
        {
            return "Radius: " + Radius + " Perimeter: " + Perimeter() + " Square: " + Square_area();
        }
    }
}
