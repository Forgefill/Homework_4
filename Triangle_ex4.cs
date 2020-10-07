using System;
using System.Collections.Generic;
using System.Text;

namespace Trg
{
        class Triangle
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
            public double GetPerimeter()     //отримати периметр трикутника
            {
                return side1 + side2 + side3;
            }
            public void SetS1(double s1)    //зміна значеннь сторін
            {
                side1 = s1;
            }
            public void SetS2(double s2)
            {
                side2 = s2;
            }
            public void SetS3(double s3)
            {
                side3 = s3;
            }
            //методи для визначення кутів між відповідними сторонами
            public double GetAngleS12()
            {
                return Angle(side1, side2, side3);
            }
            public double GetAngleS23()
            {
                return Angle(side2, side3, side1);
            }
            public double GetAngleS13()
            {
                return Angle(side1, side3, side2);
            }
            private double Angle(double a, double b, double c)
            {

                return Math.Acos((a * a + b * b - c * c) / (2 * a * b)) * 180 / Math.PI;
            }

        }

        class EquilateralTriangle : Triangle
        {
            private double area;
            public EquilateralTriangle(double a) : base(a, a, a)
            {
                area = a * a * Math.Sqrt(3) / 4;
            }

            public double GetArea()
            {
                return area;
            }

        }
}
