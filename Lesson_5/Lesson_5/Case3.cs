using System;

namespace Lesson_5
{
    class Case3
    {
        public void Permutation(string firstWord, string secondWord)
        {
            if (firstWord.Length != secondWord.Length)
            {
                Console.WriteLine("it's not permutation");

                return;
            }

            int countSimbols = 0;

            var chArrA = firstWord.ToLower().ToCharArray();
            var chArrB = secondWord.ToLower().ToCharArray();

            Array.Sort(chArrA);
            Array.Sort(chArrB);

            foreach (char cha in chArrA)
            {
                foreach(char chb in chArrB)
                {
                    if (cha == chb)
                    {
                        countSimbols++;
                    }
                }
            }

            if (countSimbols == firstWord.Length)
            {
                Console.WriteLine("it's permutation");
            }
        }

        public bool Anagramma(string firstWord, string secondWord)
        {
            if (firstWord.Length != secondWord.Length)
            {
                Console.WriteLine("it's not anagramma");

                return false;
            }

            char[] firstWordArr = firstWord.ToLower().ToCharArray();
            char[] secondWordArr = secondWord.ToLower().ToCharArray();

            Array.Sort(firstWordArr);
            Array.Sort(secondWordArr);

            firstWord = new string(firstWordArr);
            secondWord = new string(secondWordArr);

            return (firstWord == secondWord ? true : false);
        }
    }
}
