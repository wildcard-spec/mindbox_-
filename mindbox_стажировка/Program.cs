using System;

namespace mindbox_стажировка
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle tri = new Triangle(6, 8, 10);
            Circle circ = new Circle(5);
            Console.WriteLine("Площадь круга = " + circ.Area);
            Console.WriteLine("Площадь треугольника = " + tri.Area);
            Console.Write("Является ли треугольник прямоугольным? " + tri.IsRight);
        }
    }
}
