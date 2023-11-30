using System;

namespace Shape
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes =
             {
            new Circle(4),
            new Triangle( 5, 4 ,7),
            new Quadrate( 5)
            };
            foreach (Shape shape in shapes)
            {
                shape.Info();
                Console.WriteLine("Периметр: {0}", shape.Perimeter());
                Console.WriteLine("Площадь: {0}", shape.Square());
                shape.Rotate();
                Console.WriteLine();
            }
        }
    }

    public abstract class Shape
    {
        public abstract void Info();
        public abstract double Perimeter();
        public abstract double Square();
        public virtual void Rotate()
        { }
    }
    class Circle : Shape
    {
        protected double r;

        public Circle(double r)
        {
            this.r = r;
        }
        public override void Info()
        {
            Console.WriteLine(" Окружность с радиусом  r = {0}", r);
        }
        public override double Perimeter()
        {
            return 2 * 3.14 * r;
        }
        public override double Square()
        {
            return 3.14 * r * r;
        }
    }
    class Triangle : Shape
    {
        protected double a, b, c;
        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public override void Info()
        {
            Console.WriteLine("Треугольник со сторонами а = {0}, b = {1}, c = {2}", a, b, c);
        }
        public override double Perimeter()
        {
            return a + b + c;
        }
        public override double Square()
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
        public override void Rotate() { Console.WriteLine("Фигура совершила вращение вокруг своего центра"); }

    }
    class Quadrate : Shape
    {
        protected double d;
        public Quadrate(double d)
        {
            this.d = d;
        }
        public override void Info()
        {
            Console.WriteLine("Квадрат со стороной d = {0}", d);
        }
        public override double Perimeter()
        {
            return d + d + d + d;
        }

        public override double Square()
        {
            return d * d;
        }
        public override void Rotate() { Console.WriteLine("Фигура совершила вращение вокруг своего центра"); }

    }
}
