using System;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Point firstPoint = new Point(1, 2, "A");
            Point secondPoint = new Point(3, 5, "B");
            Point thirdPoint = new Point(4, 7, "C");

            Figure figure = new Figure(firstPoint, secondPoint, thirdPoint);
            figure.PerimeterCalculator();

            Console.ReadKey();
        }
    }
}
