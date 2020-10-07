using System;
using System.Collections.Generic;
using System.Text;

namespace Figures
{
    abstract class Figure
    {
        public abstract double Perimeter();
        public abstract double Area();
        public abstract string GetFigureType();
    }

    class Triangle : Figure
    {
        private double side1;
        private double side2;
        private double side3;
        public Triangle(double a, double b, double c)
        {
            side1 = a;
            side2 = b;
            side3 = c;
        }
        public override double Perimeter()
        {
            return side1 + side2 + side3;
        }

        public override double Area()
        {
            double p = Perimeter() / 2;
            return Math.Sqrt(p * (p - side1) * (p - side2) * (p - side3));
        }
        public override string GetFigureType()
        {
            return "Трикутник";
        }
    }

    class Circle : Figure
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }
        public override double Perimeter()
        {
            return 2 * Math.PI * radius;
        }
        public override double Area()
        {
            return Math.PI * radius * radius;
        }
        public override string GetFigureType()
        {
            return "Коло";
        }
    }
    class Rectangle : Figure
    {
        double height;
        double width;
        public Rectangle(double a, double b)
        {
            height = a;
            width = b;
        }
        public override double Area()
        {
            return height * width;
        }
        public override double Perimeter()
        {
            return 2 * (height + width);
        }

        public override string GetFigureType()
        {
            return "Прямокутник";
        }
    }

    class Square : Figure
    {
        private double side;

        public Square(double a)
        {
            side = a;
        }
        public override double Area()
        {
            return side * side;
        }
        public override double Perimeter()
        {
            return 2 * (side + side);
        }

        public override string GetFigureType()
        {
            return "Квадрат";
        }
    }

    class Rhombus : Figure
    {
        private double side;
        private double angle;
        public Rhombus(double a, double angle)
        {
            side = a;
            this.angle = angle;
        }

        public override double Area()
        {
            return side * side * Math.Sin(angle);
        }

        public override double Perimeter()
        {
            return 4 * side;
        }

        public override string GetFigureType()
        {
            return "Ромб";
        }
    }
}
