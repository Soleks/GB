using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    // Case 2 Написать метод подсчета количества цифр числа.

    class Case2
    {
        public Case2(int number)
        {
            number_ = number;
        }

        public int Count()
        {
            return number_.ToString().Count();
        }

        private int number_;
    }
}
