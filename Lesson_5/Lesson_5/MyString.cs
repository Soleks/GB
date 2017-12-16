using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5
{
    class MyString
    {
        public MyString()
        {
            words_ = new List<string>();
        }

        public static implicit operator MyString(string v)
        {
            return new MyString
            {
                str_ = v
            };
        }

        public void Show() => Console.WriteLine(str_);

        public void NSimbolsInWord(int n)
        {
            string[] tmp = str_.Split(' ');

            foreach (string s in tmp)
            {
                if (s.Length <= n)
                {
                    Console.WriteLine(s);
                }
            }
        }

        public void RemoveWord(string ch)
        {
            string regex = "[";
            regex += ch;
            regex += "$]";
            Regex reg = new Regex(regex, RegexOptions.Multiline);
            Console.WriteLine(reg.Replace(str_, ""));
        }

        public void MaxLengthWord()
        {
            string[] tmp = str_.Split(' ');

            if (tmp.Length == 0)
            {
                return;
            }

            string max = tmp[0];

            for (int i = 1; i < tmp.Length; i++)
            {
                if (max.Length < tmp[i].Length)
                {
                    max = tmp[i];
                }
            }

            Console.WriteLine("long word: " + max);
        }

        public void MaxLengthWords()
        {
            string[] tmp = str_.Split(' ');

            if (tmp.Length == 0)
            {
                return;
            }

            Array.Sort(tmp);

            string max = tmp[tmp.Length - 1];
            words_.Add(max);

            for (int i = tmp.Length - 2; i > 0; i--)
            {
                if (max.Length <= tmp[i].Length)
                {
                    max = tmp[i];
                    words_.Add(max);
                }
            }
        }

        public void ShowMaxWords()
        {
            if (words_.Count == 0)
            {
                Console.WriteLine("words not found");

                return;
            }

            foreach (string s in words_)
            {
                Console.WriteLine("all long words:" + s);
            }
        }

        private string str_;
        private List<string> words_;
    }
}
