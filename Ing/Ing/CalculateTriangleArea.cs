using System;

namespace Ing
{
    public class CalculateTriangleArea
    {      
        public double calculateTriangleArea(double a, double b, double c)
        {
            double s = (a + b + c) / 2;

            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

            return Math.Round(area, 3);
        }
    }
}