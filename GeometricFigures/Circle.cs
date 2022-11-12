using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricShapes
{
    public class Circle : Figure
    {
        public Circle(double m1, double m2 = 0, double m3 = 0) : base(m1, m2, m3) { }

        public override double GetArea()
        {
            return Math.PI * m1 * m1;
        }
    }
}
