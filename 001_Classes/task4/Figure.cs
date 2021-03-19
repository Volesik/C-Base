using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Figure
    {
        // Должны ли мы создавать Поля типа Point в начале? Если да, то 3, 4 или 5, т.к. по условию нужно разные конструкторы создавать.
        //Да, 5 штук, что бы можно было присвоить им значения через конструктор и использовать их в методах.
        private Point a;
        private Point b;
        private Point c;
        private Point d;
        private Point e;
        private double perimeter; 
        public Figure(Point a, Point b, Point c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public Figure(Point a, Point b, Point c, Point d) // Почему я не могу сделать перезагрузку таким способом? :this(Point a, Point b, Point c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }

        public Figure(Point a, Point b, Point c, Point d, Point e)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            this.e = e;
        }

        private double LengthSide(Point a, Point b)
        {
            double side = Math.Pow((b.FirstPoint - a.FirstPoint), 2) + Math.Pow((b.SecondPoint - b.FirstPoint), 2);
            return Math.Sqrt(side);
        }

        public void PerimeterCalculator()
        {
            if (a != null && b != null && c != null && d != null && e != null)
            {
                perimeter = LengthSide(a, b) + LengthSide(b, c) + LengthSide(c, d) + LengthSide(d, e) + LengthSide(e, a);
            }
            else if(a != null && b != null && c != null && d != null )
            {
                perimeter = LengthSide(a, b) + LengthSide(b, c) + LengthSide(c, d) + LengthSide(a, d);
            }
            else
            {
                perimeter = LengthSide(a, b) + LengthSide(a, c) + LengthSide(b, c);
            }
            
            Console.WriteLine($"Периметр многоульника {perimeter}");
        }
    }
}
