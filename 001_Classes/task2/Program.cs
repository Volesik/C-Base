using System;

namespace task2
{
    class Rectangle
    {
        private double side1, side2;

        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        /*
         * Ситуация с методами мне не совсем понятно, точнее сами методы то понятны, а конкретно в этом 
         * задании не понятно, так как они по идее возращают тоже самое что и геттеры по условию задания
         * поэтому модификатор доступа поставил private, и по идее можно было бы сразу в return get метода такое вписать без использования метода AreaCalculator и Perimeter Calculator
         * Возможно я не правильно понял суть конкретного задания. Прошу исправить если что то не так. Или это задание чисто на понимание как использовать различные конструкции классов?..
         */ 

        private double AreaCalculator() 
        {
            return side1 * side2;
        }

        private double PerimeterCalculator()
        {
            return (side1 + side2) * 2;
        }

        public double Area
        {
            get // не знаю корректно ли в геттере в return передавать метод.
            {
                return AreaCalculator();
            }
        }

        public double Perimeter
        {
            get // аналогичная ситуация как с верхним геттером.
            {
                return PerimeterCalculator();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first rectangle side > ");
            double firstSide = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second rectangle side > ");
            double secondSide = Convert.ToDouble(Console.ReadLine());


            Rectangle rectangle1 = new Rectangle(firstSide, secondSide);

            Console.WriteLine($"Area of rectangle is {rectangle1.Area}");
            Console.WriteLine($"Perimeter of rectangle is {rectangle1.Perimeter}");

            Console.ReadKey();
        }
    }
}
