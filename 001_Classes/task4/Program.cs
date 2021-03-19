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
            Point fourthPoint = new Point(2, 6, "C");
            Point fifthPoint = new Point(7, 1, "C");

            Figure figure = new Figure(firstPoint, secondPoint, thirdPoint, fourthPoint, fifthPoint);
            figure.PerimeterCalculator();

            Console.ReadKey();
        }
    }
}
