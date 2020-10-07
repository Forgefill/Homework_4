using System;
using System.Collections.Generic;
using System.Text;

namespace Triangles
{
  
        abstract class Triangle
        {

            protected double side1;
            protected double side2;
            protected double angle;
            public abstract double Perimeter();
            public abstract double Area();
        public abstract string GetTriangleName();
        }

        class RightTriangle : Triangle
        {
            private double side3;
            public RightTriangle(double a, double b, double angleAB)
            {
                side1 = a;
                side2 = b;
                angle = angleAB;
                side3 = Math.Sqrt(a * a + b * b - 2 * a * b * Math.Cos(angle*Math.PI/180));
            }

        public override string GetTriangleName()
        {
            return "Прямокутний трикутник";
        }


        public override double Area()
            {
                if (angle == 90)
                {
                    return side1 * side2 / 2;
                }
                else if (side1 < side2)
                {
                    return side3 * side1 / 2;
                }
                else
                {
                    return side3 * side2 / 2;
                }
            }

            public override double Perimeter()
            {
                return side1 + side2 + side3;
            }
        }
        class IsoscelesTriangle : Triangle
        {
            private double side3;
            public IsoscelesTriangle(double a, double b, double angleAB)
            {
                side1 = a;
                side2 = b;
                angle = angleAB;
                side3 = Math.Sqrt(a * a + b * b - 2 * a * b * Math.Cos(angleAB*Math.PI/180));
            }

            public override string GetTriangleName()
        {
            return "Рівнобедренний трикутник";
        }
            public override double Area()
            {
                double p = Perimeter() / 2;
                return Math.Sqrt(p * (p - side1) * (p - side2) * (p - side3));
            }

            public override double Perimeter()
            {
                return side1 + side2 + side3;
            }

        
    
     }
}
