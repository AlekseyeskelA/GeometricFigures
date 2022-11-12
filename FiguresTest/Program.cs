using GeometricShapes;
using System;

namespace TestShapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Параметры круга:
            double _Radius = 3;

            // Параметры треугольника
            double _Side_1 = 3;
            double _Side_2 = 4;
            double _Side_3 = 5;

            Circle C = new Circle(_Radius);
            Triangle T = new Triangle(_Side_1, _Side_2, _Side_3);
            Console.WriteLine($"Площадь круга с радиусом {_Radius} = {C.GetArea()}");
            Console.WriteLine($"Площадь треугольника с длинами сторон {_Side_1}, {_Side_2}, {_Side_3} = {T.GetArea()}");
            Console.WriteLine($"Треугольник является приямоугольным: {T.IsTriangleRight}");
            Console.ReadLine();
        }
    }
}