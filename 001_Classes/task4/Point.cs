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
        private string pointName; // Уже понял, с математикой плохо, особенно с координатами, вот это я изначально и не мог понять, что за задача и что за поинты. Но опять же таки можно вроде и без буквы обойтись в данном разрезе 

        public Point(int firstPoint, int secondPoint, string pointName)
        {
            this.firstPoint = firstPoint;
            this.secondPoint = secondPoint;
            this.pointName = pointName;
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

        public string PointName
        {
            get
            {
                return pointName;
            }
        }

        
    }
}
