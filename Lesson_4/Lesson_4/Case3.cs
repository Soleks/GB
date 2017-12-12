using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4
{
    class Case3
    {
        public Case3()
        {
            array_ = new string[2];
        }

        public bool Login(string login, string password)
        {
            return (login == login_ && password == password_);
        }

        public bool Login(string path)
        {
            try
            {
                StreamReader sr = new StreamReader(path, System.Text.Encoding.Default);
                int i = 0;
                string str = null;

                while ((str = sr.ReadLine()) != null)
                {
                    array_[i] = str;
                    i++;
                }

                if (i == 1)
                {
                    array_ = array_[0].Split(' ');
                }

                for (int j = 0; j < array_.Length; j++)
                {
                    array_[j] = array_[j].Trim();
                }

                if (array_[0] == login_ && array_[1] == password_)
                {
                    return true;
                }

                sr.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }

            return false;
        }

        private readonly string login_ = "root";
        private readonly string password_ = "GeekBrains";
        private string[] array_;
    }
}
