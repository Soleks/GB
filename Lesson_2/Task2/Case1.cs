using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Case1
    {
        //Case 1  Написать метод возвращающий минимальное из трех чисел.

        public Case1(int a, int b, int c)
        {
            a_ = a;
            b_ = b;
            c_ = c;
        }

        public int LowValue()
        {
            int min = a_;

            if (b_ < min)
            {
                min = b_;
            }

            if (c_ < min)
            {
                min = c_;
            }

            return min;
        }

        private int a_;
        private int b_;
        private int c_;
    }
}
