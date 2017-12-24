using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_7
{
    class Doubler
    {
        public enum Win
        {
            win = 0,
            fail = 1,
            continueGame = 2
        };

        public Doubler()
        {
            lastMove_ = "";
            Random rnd = new Random();
            number_ = rnd.Next(5, 100);
        }

        public int Max
        {
            get
            {
                return 100;
            }
        }

        public int Number
        {
            get
            {
                return number_;
            }
        }

        public Win CheckWin(int numb, string eventMove)
        {
            lastMove_ = eventMove;
            currentNumber_ = numb;

            if (currentNumber_ < number_)
            {
                return Win.continueGame;

            } else if (currentNumber_ == number_)
            {
                return Win.win;
            }

            return Win.fail;
        }

        public string LastMove
        {
            get
            {
                return lastMove_;
            }
        }

        public int CurrentNumber
        {
            get
            {
                return currentNumber_;
            }
            set
            {
                currentNumber_ = value;
            }
        }

        private string lastMove_;
        private int currentNumber_;
        private int number_;
    }
}
