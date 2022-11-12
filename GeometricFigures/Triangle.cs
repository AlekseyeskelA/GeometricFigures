using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricShapes
{
    public class Triangle : Figure
    {
        public Triangle(double m1, double m2, double m3) : base(m1, m2, m3) { }

        public bool IsTriangleRight
        {
            get { return DetermineTriangleRight(); }
        }

        public override double GetArea()
        {
            double hp = (m1 + m2 + m3) / 2;
            return Math.Sqrt(hp * (hp - m1) * (hp - m2) * (hp - m3));
        }

        public bool DetermineTriangleRight()
        {
            if ((m1 * m1 + m2 * m2 == m3 * m3)
                || (m1 * m1 + m3 * m3 == m2 * m2)
                || (m2 * m2 + m3 * m3 == m1 * m1))
                return true;
            else return false;
        }
    }
}
