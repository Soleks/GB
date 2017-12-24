using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    //С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
    class Case3
    {
        public Case3()
        {
        }

        public void Sum(int number)
        {
            if (number > 0 && number % 2 != 0)
            {
                sum_ += number;
            }
        }

        public int ShowResult()
        {
            return sum_;
        }

        private int sum_;
    }
}
