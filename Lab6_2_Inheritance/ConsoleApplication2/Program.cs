using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_2_Inheritance
{
    public class Shade
    {
        public int x;
        public int y;
        public double Per, Sq, angle;

        public virtual void Square(int x, int y, double angle)
        {
            Sq = x * y;
            Console.WriteLine("Shade square is equal: {0}", Sq);
        }
        public virtual void Perymeter(int x, int y)
        {
            Per = 2 * x + 2 * y;
            Console.WriteLine("Shade perymeter is equal: {0}", Per);
        }
    }
    public class Square1 : Shade
    {
        public override void Square(int x, int y, double angle)
        {
        }
        public override void Perymeter(int x, int y)
        {
        }
    }
    public class Circle : Shade
    {
        public override void Square(int x, int y, double angle)
        {
            Console.WriteLine("Set dimension x as radius");
            Sq = 3.14 * x * x;
            Console.WriteLine("Circle square is equal: {0}", Sq);
        }
        public override void Perymeter(int x, int y)
        {
            Console.WriteLine("Set dimension x as radius");
            Per = 3.14 * 2 * x;
            Console.WriteLine("Circle perymeter is equal: {0}", Per);
        }
    }

    public class Ellipse : Circle
    {
        public override void Square(int x, int y, double angle)
        {
            Sq = 3.14 * x * y;
            Console.WriteLine("Ellipse square is equal to {0}", Sq);
        }
        public override void Perymeter(int x, int y)
        {
            Per = 4 * (3.14 * x * y + (y - x)) / (x + y);
            Console.WriteLine("Ellipse perymeter is equal: {0}", Per);
        }
    }

    public class Triangle : Shade
    {
        public override void Square(int x, int y, double angle)
        {
            Console.WriteLine("Set as triangle altitude x dimension and y dimension as hypotenuse");

            Sq = 0.5 * x * y;
            Console.WriteLine("Triangle square is equal to {0}", Sq);
        }
        public override void Perymeter(int x, int y)
        {
            Console.WriteLine("Set as triangle altitude x dimension and y dimension as hypotenuse");
            Per = y + y * angle + y * Math.Sqrt(1 - angle * angle);
            Console.WriteLine("Triangle perymeter is equal: {0}", Per);
        }
    }
    public class Square2 : Square1
    {
        public override void Square(int x, int y, double angle)
        {
            Console.WriteLine("Set as triangle altitude x dimension and y dimension as hypotenuse");

            Sq = 0.5 * x * y;
            Console.WriteLine("Square square is equal to {0}", Sq);
        }
        public override void Perymeter(int x, int y)
        {
            Console.WriteLine("Set as triangle altitude x dimension and y dimension as hypotenuse");
            Per = y + y * angle + y * Math.Sqrt(1 - angle * angle);
            Console.WriteLine("Square perymeter is equal: {0}", Per);
        }
    }
    public class Rhomb : Square1
    {
        public override void Square(int x, int y, double angle)
        {
            Console.WriteLine("Set x and y dimensions as diagonal lines");

            Sq = 0.5 * x * y;
            Console.WriteLine("Rhomb square is equal to {0}", Sq);
        }
        public override void Perymeter(int x, int y)
        {
            Console.WriteLine("Set angle as is situated near the x diagonal");
            Per = 4 * 0.5 * x / 0.5;
            Console.WriteLine("Rhomb perymeter is equal: {0}", Per);
        }
    }
    public class Rectangle : Square1
    {
        public override void Square(int x, int y, double angle)
        {
            Sq = x * y;
            Console.WriteLine("Rectangle square is equal to {0}", Sq);
        }
        public override void Perymeter(int x, int y)
        {
            Per = 2 * x + 2 * y;
            Console.WriteLine("Rectangle perymeter is equal: {0}", Per);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Circle MyCircle = new Circle();
            MyCircle.Square(5, 10, 0);
            MyCircle.Perymeter(5, 10);
            Ellipse MyEllipse = new Ellipse();
            MyEllipse.Square(5, 10, 0);
            MyEllipse.Perymeter(5, 10);
            Triangle MyTriangle = new Triangle();
            MyTriangle.Square(5, 10, 0.707);
            MyTriangle.Perymeter(5, 10);
            Square2 MySquare = new Square2();
            MySquare.Square(10, 10, 0);
            MySquare.Perymeter(10, 10);
            Rhomb MyRhomb = new Rhomb();
            MyRhomb.Square(10, 17, 0.5);
            MyRhomb.Perymeter(10, 10);
            Rectangle MyRectangle = new Rectangle();
            MyRectangle.Square(5, 10, 0);
            MyRectangle.Perymeter(10, 10);

            Console.ReadLine();
        }
    }
}
