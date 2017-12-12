using System;
using System.IO;

namespace Lesson_4
{
    class Case2
    {
        // Создание массива и заполнение его значениями с шагом step
        public Case2(int n, int step)
        {
            array_ = new int[n];
            for (int i = 0; i < n; i++)
                array_[i] = i * step;
        }
        // Создание массива и заполнение его случайными числами от min до max
        public Case2(int n, int min, int max)
        {
            array_ = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
                array_[i] = rnd.Next(min, max);
        }

        public void Read(string path)
        {
            try
            {
                StreamReader sr = new StreamReader(path);
                int i = 0;
                string str = null;

                while ((str = sr.ReadLine()) != null)
                {
                    int result;

                    if (!int.TryParse(str, out result))
                    {
                        Console.WriteLine("can't to parse value");

                        return;
                    }
                    else
                    {
                        array_[i] = result;
                        i++;
                    }
                }

                sr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void Write(string path)
        {
            if (array_.Length == 0)
            {
                Console.WriteLine("the array is empty");

                return;
            }

            try
            {
                StreamWriter sw = new StreamWriter(path);

                for (int i = 0; i < array_.Length; i++)
                {
                    sw.WriteLine(array_[i].ToString());
                }

                sw.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public int Sum
        {
            get
            {
                int sum = 0;

                if (array_.Length == 0)
                {
                    return sum;
                }

                for (int i = 0; i < array_.Length; i++)
                {
                    sum += array_[i];
                }

                return sum;
            }
        }

        public void Inverse()
        {
            for (int i = 0; i < array_.Length; i++)
            {
                array_[i] *= -1;
            }
        }

        public void Multiplication(int multiplier)
        {
            for (int i = 0; i < array_.Length; i++)
            {
                array_[i] *= multiplier;
            }
        }

        public int MaxCount
        {
            get
            {
                int count = 0;

                for (int i = 0; i < array_.Length; i++)
                {
                    if (array_[i] == Max)
                    {
                        count++;
                    }
                }

                return count;
            }
        }

        public int Max
        {
            get
            {
                int max = array_[0];
                for (int i = 1; i < array_.Length; i++)
                    if (array_[i] > max) max = array_[i];
                return max;
            }
        }
        public int Min
        {
            get
            {
                int min = array_[0];
                for (int i = 1; i < array_.Length; i++)
                    if (array_[i] < min) min = array_[i];
                return min;
            }
        }
        public int CountPositiv
        {
            get
            {
                int count = 0;

            for (int i = 0; i < array_.Length; i++)
                    if (array_[i] > 0) count++;
                return count;
            }
        }
        public override string ToString()
        {
            string s = "";
            foreach (int v in array_)
                s = s + v + " ";
            return s;
        }

        private int[] array_;
    }
}
