using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1
{
    //Олексенко С.С.
    class Program
    {
        /*1. Написать программу “Анкета”. 
         Последовательно задаются вопросы(имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку.
         */

        static void Main(string[] args)
        {
            Form form = new Form();

            Console.WriteLine("Введите имя");
            form.Name = Console.ReadLine();
            Console.WriteLine("Введите фамилию");
            form.Surname = Console.ReadLine();
            Console.WriteLine("Введите возраст");
            form.Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите рост");
            form.Growth = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите вес");
            form.Weight = double.Parse(Console.ReadLine());

            //а) используя склеивание;
            Console.WriteLine("Имя " + form.Name +
                              " Фамилия " + form.Surname +
                              " Возраст " + form.Age +
                              " Рост " + form.Growth +
                              " Вес " + form.Weight);

            //б) используя форматированный вывод;
            Console.WriteLine("Имя {0}" +
                              " Фамилия {1}" +
                              " Возраст {2}" +
                              " Рост {3}" +
                              " Вес {4}",
                               form.Name,
                               form.Surname,
                               form.Age,
                               form.Growth,
                               form.Weight);

            //в) *используя вывод со знаком $.
            Console.WriteLine($"Имя {form.Name}" +
                              $" Фамилия {form.Surname}" +
                              $" Возраст {form.Age}" +
                              $" Рост {form.Growth}" +
                              $" Вес {form.Weight}");


            /*2.Ввести вес и рост человека. Рассчитать и вывести индекс массы тела(ИМТ) по 
                формуле I = m / (h * h); где m-масса тела в килограммах, h - рост в метрах*/

            Console.WriteLine($"Вес {form.Weight}" +
                              $" Рост {form.Growth}" +
                              $" ИМТ {form.BodyMassIndex()}");

            /*3.
                а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 
                по формуле r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2).
                Вывести результат используя спецификатор формата .2f(с двумя знаками после запятой);

                б) *Выполните предыдущее задание оформив вычисления расстояния между точками в виде метода;
            */

            Point pointA = new Point(1, 1);
            Point pointB = new Point(2, 2);
          
            Console.WriteLine($"Distance: {Point.Distance(pointA, pointB).ToString("F2")}");

            Console.ReadKey();
        }
    }
}
