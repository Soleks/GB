using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5
{
    class Case1
    {
        public void CheckLogin(string login)
        {
            if (Char.IsNumber(login[0]) || 
                (login.Length < 1 || login.Length > 10))
            {
                Console.WriteLine("Wrong login");

                return;
            }

            Console.WriteLine("login success");
        }

        public void CheckLoginReg(string login)
        {
            Regex reg = new Regex(regex_);

            Console.WriteLine((reg.IsMatch(login) ? "login success" : "Wrong login"));
        }

        private readonly string regex_ = "^[a-zA-Z]{2,10}";
    }
}
