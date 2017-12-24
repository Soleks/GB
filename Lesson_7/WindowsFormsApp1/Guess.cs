using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Guess
    {
        int guessNumber;
        int countTry;

        public Guess()
        {
            Random rnd = new Random();
            guessNumber = rnd.Next(1, 101);
            countTry = (int)Math.Log(100, 2) + 1;
        }


        public int CountTry
        {
            get { return countTry; }
        }

        public int GuessNumber
        {
            get { return guessNumber; }
        }

        public string Try(int tryN)
        {
            countTry--;
            if (tryN > guessNumber) return "Перелет";
            if (tryN < guessNumber) return "Недолет";
            return "Угадали!";
        }
    }
}
