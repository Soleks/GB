using System;
using System.Collections.Generic;
using System.IO;
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

            MyString myString = "1 22 333 4444 555555 666666 666666 55555";

            //а) Вывести только те слова сообщения, которые содержат не более чем n букв;
            myString.NSimbolsInWord(5);

            //б) Удалить из сообщения все слова, которые заканчиваются на заданный символ;
            myString.RemoveWord("4");

            //в) Найти самое длинное слово сообщения;
            myString.MaxLengthWord();

            //г) Найти все самые длинные слова сообщения.

            myString.MaxLengthWords();
            myString.ShowMaxWords();

            /*3.  Для двух строк написать метод, определяющий, 
                    является ли одна строка перестановкой другой.
                    Регистр можно не учитывать.

                а) с использованием методов C#
                б) *разработав собственный алгоритм
                Например:
                badc являются перестановкой abcd
            */

            Case3 case3 = new Case3();

            case3.Permutation("badc", "abcd");

            Console.WriteLine((case3.Anagramma("badc", "abcd") ? "Anagramma" : "Not Anagramma"));

            Console.ReadKey();
        }
    }
}
