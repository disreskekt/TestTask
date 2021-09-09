using System;
using System.Collections.Generic;
using System.Text;

namespace TestTask
{
    public class TriangleArea : AbstractFigureArea
    {

        public double CathetusA { get; set; }
        public double CathetusB { get; set; }
        public double Hypotenuse { get; set; }
        public bool IsRight { get; set; }
        public TriangleArea(double a, double b, double c)
        {
            if (a > b)
            {
                if (a > c)
                {
                    Hypotenuse = a;
                    CathetusA = b;
                    CathetusB = c;
                }
            }
            else if (b > c)
            {
                Hypotenuse = b;
                CathetusA = a;
                CathetusB = c;
            }
            else
            {
                Hypotenuse = c;
                CathetusA = a;
                CathetusB = b;
            }

            IsRight = CalculateIsRight();
        }

        public override double CalculateArea()
        {
            double area;
            if (IsRight)
            {
                area = (CathetusA * CathetusB) / 2;
            }
            else
            {
                var semiPerimeter = (CathetusA + CathetusB + Hypotenuse) / 2;

                area = Math.Sqrt(semiPerimeter * (semiPerimeter - CathetusA) * (semiPerimeter - CathetusB) * (semiPerimeter - Hypotenuse));
            }

            return area;
        }

        public bool CalculateIsRight()
        {
            if (Math.Pow(Hypotenuse, 2) == Math.Pow(CathetusA, 2) + Math.Pow(CathetusB, 2))
            {
                return true;
            }
            return false;
        }
    }
}
