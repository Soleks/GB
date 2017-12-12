using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4
{
    class Case1
    {
        public Case1(int n, int min, int max)
        {
            array_ = new int[n];

            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                array_[i] = rnd.Next(min, max);
            }
        }

        public void NumberOfPairs()
        {
            for (int i = 0; i < array_.Length; i++)
            {
                if ( i < (array_.Length - 1) && (array_[i] % 3 == 0 || array_[i+1] % 3 == 0))
                {
                    count_++;
                }
            }

            Console.WriteLine("Number of pairs: " + count_);
        }

        public void ShowArray()
        {
            for (int i = 0; i < array_.Length; i++)
            {
                Console.WriteLine("array: [{0}] {1}", i, array_[i]);
            }
        }

        private int[] array_;
        private int count_;
    }
}
