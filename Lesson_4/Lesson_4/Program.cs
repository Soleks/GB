﻿using System;
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
            Case1 case1 = new Case1(20, -1000, 1000);

            case1.ShowArray();
            case1.NumberOfPairs();

            Console.ReadKey();
        }
    }
}