using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Point
    {
        private int firstPoint, secondPoint;
        private string stringValue; // Зачем нам строковое поле? 

        public Point(int firstPoint, int secondPoint, string stringValue)
        {
            this.firstPoint = firstPoint;
            this.secondPoint = secondPoint;
            this.stringValue = stringValue;
        }

        public int FirstPoint
        {
            get
            {
                return firstPoint;
            }
        }

        public int SecondPoint
        {
            get
            {
                return secondPoint;
            }
        }

        public string StringValue
        {
            get
            {
                return stringValue;
            }
        }

        
    }
}
