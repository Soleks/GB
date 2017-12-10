using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Lesson_3
{
    class Program
    {

        //1. 

        //а) Дописать структуру Complex, добавив метод вычитания комплексных чисел.Продемонстрировать работу структуры;

        struct ComplexS
        {
            public ComplexS(double re, double im )
            {
                re_ = re;
                im_ = im;
            }

            public ComplexS Addition(ComplexS number)
            {
                ComplexS res;

                res.re_ = re_ + number.re_;
                res.im_ = im_ + number.im_;

                return res;
            }

            public ComplexS Subtraction(ComplexS number)
            {
                ComplexS res;

                if (re_ > number.re_ && im_ > number.im_)
                {
                    res.re_ = re_ - number.re_;
                    res.im_ = im_ - number.im_;

                    return res;
                }

                res.re_ = number.re_ - re_;
                res.im_ = number.im_ - im_;

                return res;
            }

            public override string ToString()
            {
                return re_ + " + " + im_ + "i";
            }

            private double re_;
            private double im_;
        }

        static void Main(string[] args)
        {
            string a = "1+1i+2+2i";

            string[] b = a.Split('+');

            for (int i = 0; i < b.Length; i++)
            {
                if (b[i].Length == 2)
                {
                    b[i] = b[i].Remove(1);
                }
            }

            ComplexS comp = new ComplexS(double.Parse(b[0]), double.Parse(b[1]));
            ComplexS comp2 = new ComplexS(double.Parse(b[2]), double.Parse(b[3]));

            Console.WriteLine("Структура");
            Console.WriteLine("Сложение: " + comp.Addition(comp2).ToString());
            Console.WriteLine("Вычитание: " + comp.Subtraction(comp2).ToString());

            //б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса;

            Complex comp3 = new Complex(double.Parse(b[0]), double.Parse(b[1]));
            Complex comp4 = new Complex(double.Parse(b[2]), double.Parse(b[3]));

            Console.WriteLine("Класс");
            Console.WriteLine("Умножение: " + comp3.Multiplication(comp4).ToString());
            Console.WriteLine("Вычитание: " + comp3.Subtraction(comp4).ToString());


            //2.
            //С клавиатуры вводятся числа, пока не будет введен 0(каждое число в новой строке).
            //Требуется подсчитать сумму всех нечетных положительных чисел. 
            //Сами числа и сумму вывести на экран; Используя tryParse;

            EvenNumb eNumb = new EvenNumb();
            string s = "";
            int num = 0;

            Console.WriteLine("Введите числа чтобы узнать сумму нечётных чисел");

            do
            {
                s = Console.ReadLine();

                if (int.TryParse(s, out num))
                {
                    eNumb.Sum(num);

                } else
                {
                    Console.WriteLine("Ошибка, введите число!");
                }
            } while (num != 0);

            Console.WriteLine("Сумма нечётных чисел: " + eNumb.ShowSum());
            eNumb.ShowNumbers();

            Console.ReadKey();
        }
    }
}
