using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace CTX
{
    class HandlerBigData
    {
        private string path_;
        private BigDataStudents bigDataStudents_;
        private List<BigDataStudents> list_;
        private StreamReader sr_;
        private bool load_ = false;

        public bool Load
        {
            get
            {
                return load_;
            }
        }

        public HandlerBigData(string path)
        {
            path_ = path;
            list_ = new List<BigDataStudents>();
        }

        private int StudentCompare(BigDataStudents st1, BigDataStudents st2)
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

                } catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            load_ = true;

            sr_.Close();
        }

        public void ShowStatisticsOfStidents()
        {
            Console.WriteLine("Total students:" + list_.Count);
            Console.WriteLine("Age:{0}", list_[0].Age);
            Console.WriteLine("Course:{0}", list_[0].Course);
        }

        public bool CsvToXml()
        {
            SaveFileDialog dialog = new SaveFileDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                XmlSerializer xmlFormat = new XmlSerializer(typeof(List<BigDataStudents>));
                Stream fStream = new FileStream(dialog.FileName, FileMode.Create, FileAccess.Write);
                xmlFormat.Serialize(fStream, list_);
                fStream.Close();

                return true;
            }

            return false;
        }
    }
}
