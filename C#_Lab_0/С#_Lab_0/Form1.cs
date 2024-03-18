using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace С__Lab_0
{
    public partial class Form1 : Form
    {
        Triangle triangle;
        Rectangle rectangle;
        Circle circle;
        Square square;
        public Form1()
        {
            InitializeComponent();
        }

        public void error(string figur)
        {
            string message = "There is no such " + figur + '.';
            string caption = "Error";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons);
        }

        public void error()
        {
            string message = "Data entry error.";
            string caption = "Error";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons);
        }

        private bool init()
        {
            bool flag = false;

            switch (listBox1.SelectedIndex)
            {
                case 0:
                    if (int.TryParse(x1.Text, out int _x1) && int.TryParse(y1.Text, out int _y1) && int.TryParse(x2.Text, out int _x2) &&
                    int.TryParse(y2.Text, out int _y2) && int.TryParse(x3.Text, out int _x3) && int.TryParse(y3.Text, out int _y3))
                    {
                        flag = true;
                        triangle = new Triangle(_x1, _x2, _x3, _y1, _y2, _y3);
                        if (!triangle.Check_triangle())
                        {
                            triangle.Reset();
                            error("triangle");
                        }
                    }
                    else error();

                    break;
                case 1:
                    if (int.TryParse(x1.Text, out int _x1_2))
                    {
                        flag = true;
                        circle = new Circle(0, 0, _x1_2);
                        if (!circle.Check_circle())
                        {
                            circle.Reset();
                            error("circle");
                        }
                    }
                    else error();

                    break;
                case 2:
                    if (int.TryParse(x1.Text, out int _x1_3))
                    {
                        flag = true;
                        square = new Square(0, 0, _x1_3);
                        if (!square.Check_square())
                        {
                            square.Reset();
                            error("square");
                        }

                    }
                    else error();
                    break;
                case 3:
                    if (int.TryParse(x1.Text, out int _x1_4) && int.TryParse(x2.Text, out int _x2_4))
                    {
                        flag = true;
                        rectangle = new Rectangle(0, 0, _x1_4, _x2_4);
                        if (!rectangle.Check_rectangle())
                        {
                            rectangle.Reset();
                            error("rectangle");
                        }
                    }
                    else error();
                    break;
            }
            return flag;
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            Result.Visible = true;



            X.Visible = false;
            Y.Visible = false;
            Point2.Visible = false;
            Point3.Visible = false;
            x2.Visible = false;
            x3.Visible = false;
            y1.Visible = false;
            y2.Visible = false;
            y3.Visible = false;

            x1.Text = "";
            x2.Text = "";

            switch (index)
            {
                case 0:
                    X.Visible = true;
                    Y.Visible = true;
                    Point2.Visible = true;
                    Point3.Visible = true;
                    x2.Visible = true;
                    x3.Visible = true;
                    y1.Visible = true;
                    y2.Visible = true;
                    y3.Visible = true;

                    label2.Text = "Triangle";
                    Point1.Text = "Point 1";
                    Point2.Text = "Point 2";

                    break;
                case 1:

                    label2.Text = "Circle";
                    Point1.Text = "Radius";

                    break;
                case 2:
                    label2.Text = "Square";
                    Point1.Text = "Hight";

                    break;
                case 3:
                    x2.Visible = true;
                    Point2.Visible = true;
                    label2.Text = "Rectangle";
                    Point1.Text = "Hight";
                    Point2.Text = "Weight";

                    break;
            }
            Figure.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (init())
                switch (listBox1.SelectedIndex)
                {
                    case 0:
                        Perimeter.Text = triangle.Perimeter().ToString();
                        break;
                    case 1:
                        Perimeter.Text = circle.Perimeter().ToString();
                        break;
                    case 2:
                        Perimeter.Text = square.Perimeter().ToString();
                        break;
                    case 3:
                        Perimeter.Text = rectangle.Perimeter().ToString();
                        break;
                }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (init())
                switch (listBox1.SelectedIndex)
                {
                    case 0:
                        Squar.Text = triangle.Square_area().ToString();
                        break;
                    case 1:
                        Squar.Text = circle.Square_area().ToString();
                        break;
                    case 2:
                        Squar.Text = square.Square_area().ToString();
                        break;
                    case 3:
                        Squar.Text = rectangle.Square_area().ToString();
                        break;
                }
        }
        private void Draw_Click(object sender, EventArgs e)
        {
            System.Drawing.Pen myPen = new System.Drawing.Pen(System.Drawing.Color.Red);
            System.Drawing.Graphics formGraphics = pictureBox1.CreateGraphics();
            formGraphics.Clear(System.Drawing.Color.White);
            const int coefficient = 5;

            if (init())
                switch (listBox1.SelectedIndex)
                {

                    case 0:
                        Point point1 = new Point(triangle.x1 * coefficient, triangle.y1 * coefficient);
                        Point point2 = new Point(triangle.x2 * coefficient, triangle.y2 * coefficient);
                        Point point3 = new Point(triangle.x3 * coefficient, triangle.y3 * coefficient);
                        Point[] a = { point1, point2, point3 };
                        formGraphics.DrawPolygon(myPen, a);
                        break;
                    case 1:
                        formGraphics.DrawEllipse(myPen, RectangleF.FromLTRB(circle.X, circle.Y, circle.radius * coefficient, circle.radius * coefficient));
                        break;
                    case 2:
                        formGraphics.DrawRectangle(myPen, new System.Drawing.Rectangle(circle.X, circle.Y, square.Hight * coefficient, square.Hight * coefficient));
                        break;
                    case 3:
                        formGraphics.DrawRectangle(myPen, new System.Drawing.Rectangle(circle.X, circle.Y, rectangle.Width * coefficient, rectangle.Hight * coefficient));
                        break;
                }

            myPen.Dispose();
            formGraphics.Dispose();
        }
    }
}
