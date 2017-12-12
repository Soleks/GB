using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                1. Дан целочисленный массив из 20 элементов.Элементы массива могут 
                принимать целые значения от –10 000 до 10 000 включительно.
                Написать программу, позволяющую найти и вывести количество 
                пар элементов массива, в которых хотя бы одно число делится на 3.
                В данной задаче под парой подразумевается два подряд идущих элемента массива.
                Например, для массива из пяти элементов: 6; 2; 9; –3; 6 – ответ: 4.
            */

            Console.WriteLine("Case 1");
            Console.WriteLine();
            Case1 case1 = new Case1(20, -1000, 1000);

            case1.ShowArray();
            case1.NumberOfPairs();

            /*
                 2. а) Дописать класс для работы с одномерным массивом. Реализовать конструктор, 
                 создающий массив заданной размерности и заполняющий массив числами от начального 
                 значения с заданным шагом. Создать свойство Sum, которые возвращают сумму элементов
                 массива, метод Inverse, меняющий знаки у всех элементов массива, Метод Multi, 
                 умножающий каждый элемент массива на определенное число, 
                 свойство MaxCount, возвращающее количество максимальных элементов.
                 В Main продемонстрировать работу класса.
             */

            Case2 case2 = new Case2(10, 2);
            Console.WriteLine();
            Console.WriteLine("Case 2");

            Console.WriteLine("array: " + case2.ToString());
            Console.WriteLine("Sum elements: " + case2.Sum);

            case2.Multiplication(10);
            Console.WriteLine("Multiplication: " + case2.ToString());

            case2.Inverse();
            Console.WriteLine("Inverse: " + case2.ToString());

            Console.WriteLine("Max: " + case2.Max);
            Console.WriteLine("MaxCount: " + case2.MaxCount);

            Console.ReadKey();
        }
    }
}
