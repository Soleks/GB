using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3
{
    class EvenNumb
    {
        public EvenNumb()
        {
            numbers_ = new List<int>();
        }

        public void Sum(int number)
        {
            if (number > 0)
            {
                if (number % 2 != 0)
                {
                    sum_ += number;
                }

                numbers_.Add(number);
            }
        }

        public int ShowSum()
        {
            return sum_;
        }

        public void ShowNumbers()
        {
            foreach (int numb in numbers_)
            {
                Console.WriteLine("Числа: " + numb);
            }
        }

        private int sum_;
        private List<int> numbers_;
    }

}
