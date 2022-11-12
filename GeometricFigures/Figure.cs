using System;

namespace GeometricShapes
{
    public abstract class Figure
    {
        internal double m1;
        internal double m2;
        internal double m3;

        internal Figure(double m1, double m2, double m3)
        {
            this.m1 = m1;
            this.m2 = m2;
            this.m3 = m3;
        }

        public abstract double GetArea();
    }
}
