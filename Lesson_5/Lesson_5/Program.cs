using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Урок 5 
 Олексенко С.С
*/
namespace Lesson_5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1.Создать программу, которая будет проверять 
             корректность ввода логина. Корректным логином 
             будет строка от 2 - х до 10 - ти символов, 
             содержащая только буквы или цифры, и при этом 
             цифра не может быть первой.
             */

            Case1 case1 = new Case1();

            //а) без использования регулярных выражений;
            case1.CheckLogin("1qwert");
            case1.CheckLogin("qwert");

            //б) **с использованием регулярных выражений.

            case1.CheckLoginReg("1qwert");
            case1.CheckLoginReg("qwert");

            //2.Разработать методы для решения следующих задач.
            //Дано сообщение:


            Console.ReadKey();
        }
    }
}
