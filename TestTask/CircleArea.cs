using System;
using System.Collections.Generic;
using System.Text;

namespace TestTask
{
    public class CircleArea : AbstractFigureArea
    {
        public double Radius { get; set; }

        public CircleArea(double radius)
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            var area = Math.PI * Math.Pow(Radius, 2);

            return area;
        }
    }
}
