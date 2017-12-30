using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_8
{
    class Believe
    {
        public Believe()
        {
            Init();
            check_ = 0;
        }

        public void RunGame(object sender)
        {
            Init();

            for (int i = 0; i < 4; i++)
            {
                if (str_[i] == str_[0])
                {
                    check_++;
                }
            }
        }

        public string Number
        {
            get
            {
                return str_.ToString();
            }
        }

        public string Value
        {
            get
            {
                return "четыре " + str_[0];
            }
        }

        public int CheckWin
        {
            get
            {
                return check_;
            }
        }

        private void Init()
        {
            str_ = new StringBuilder();
            rnd_ = new Random();

            for (int i = 0; i < 4; i++)
            {
                str_.Append(rnd_.Next(1, 10).ToString());
                str_.Append(" ");
            }
        }

        private int check_;
        private StringBuilder str_;
        private Random rnd_;
    }
}