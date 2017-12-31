using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6
{
    class HandlerBigData
    {
        private int bakalav_ = 0;
        private int magistr_ = 0;
        private string path_;
        private BigDataStudents bigDataStudents_;
        private List<BigDataStudents> list_;
        private StreamReader sr_;

        public HandlerBigData(string path)
        {
            path_ = path;
            list_ = new List<BigDataStudents>();
        }

        int StudentCompare(BigDataStudents st1, BigDataStudents st2)
        {
            if (st1.Course > st2.Course) return 1;
            if (st1.Course < st2.Course) return -1;

            return 0;
        }

        public void CreateList()
        {
            sr_ = new StreamReader(path_);

            while (!sr_.EndOfStream)
            {
                try
                {
                    string[] s = sr_.ReadLine().Split(';');

                    bigDataStudents_ = new BigDataStudents(
                        s[0], s[1], s[2], s[3], s[4], 
                        int.Parse(s[5]), 
                        Convert.ToInt32(s[6]), 
                        int.Parse(s[7]), s[8]);

                    list_.Add(bigDataStudents_);

                    if (bigDataStudents_.Course < 5)
                    {
                        bakalav_++;

                    } else
                    {
                        magistr_++;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            list_.Sort(StudentCompare);

            sr_.Close();
        }

        public void ShowListStudents()
        {
            foreach (var v in list_)
            {
                Console.WriteLine(v.ToString());
            }
        }

        public void ShowStatisticsOfStidents()
        {
            Console.WriteLine("Всего студентов:" + list_.Count);
            Console.WriteLine("Магистров:{0}", magistr_);
            Console.WriteLine("Бакалавров:{0}", bakalav_);
        }
    }
}
