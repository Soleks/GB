using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void SetZero(int A)
        {
            A = 0;
        }

        static void Main(string[] args)
        {

            int x = 10, y = 20, z = 30;
            SetZero(x);
            SetZero(y);
            SetZero(z);


            //Case1 low = new Case1(3, 2, 1);

            //Console.WriteLine("Наименьшее число из трёх заданных: " + low.LowValue());

            //Case2 cNum = new Case2(1000);

            //Console.WriteLine("Количество цифр в заданном числе: " + cNum.Count());

            //Case3 case3 = new Case3();

            //int num = 0;

            //do
            //{
            //    num = int.Parse(Console.ReadLine());
            //    case3.Sum(num);

            //} while (num != 0);

            //Console.WriteLine("Сумма нечётных чисел: " + case3.ShowResult());

            //Console.ReadKey();
        }
    }
}
