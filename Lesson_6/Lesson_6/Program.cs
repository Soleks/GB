using System;
using System.IO;

namespace Lesson_6
{
    class Program
    {
        /*1. Изменить программу вывода функции так, чтобы можно было передавать функции типа double (double, double). 
             Продемонстрировать работу на функции с функцией a* x^2 и функцией a* sin(x).
        2.   Модифицировать программу нахождения минимума функции так, чтобы можно было передавать 
             функцию в виде делегата.Сделать меню с различными функциями и представьте пользователю выбор для 
             какой функции и на каком отрезке находить минимум.Используйте массив делегатов.
        */

        public static double OnF(double a, double x)
        {
            return a * (x * x);
        }

        public static double OnF1(double a, double x)
        {
            return a * Math.Sin(x);
        }

        static void Main(string[] args)
        {
            //Minimum minimum = new Minimum("file.txt");
            
            //minimum.Func += new Minimum.Handler(OnF);
            //minimum.FuncSin += new Minimum.Handler(OnF1);

            //Console.WriteLine("Выберети функцию 1 или 2 ");
            //int i;
            //int.TryParse(Console.ReadLine(), out i);

            //if (i == 1)
            //{
            //    minimum.SaveFunc(10, 10, true);

            //} else if(i == 2)
            //{
            //    minimum.SaveFunc(10, 10, false);
            //}


            /*
                3.Подсчитать количество студентов:
                а) учащихся на 5 и 6 курсах;
                б)подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся(частотный массив);
                в) отсортировать список по возрасту студента;
                г) *отсортировать список по курсу и возрасту студента
            */

            HandlerBigData handler = new HandlerBigData("students_1.csv");

            handler.CreateList();
            handler.ShowStatisticsOfStidents();

            Console.ReadKey();
        }
    }
}
