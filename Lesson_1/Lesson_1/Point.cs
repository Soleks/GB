using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1
{
    class Point
    {
        public Point(double x , double y)
        {
            x_ = x;
            y_ = y;
        }

        public static double Distance(Point a , Point b)
        {
            //Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2))

             return Math.Sqrt(Math.Pow(b.x_ - a.x_, 2) + Math.Pow(b.y_ - a.y_, 2));
        }

        private double x_;
        private double y_;
    }
}
