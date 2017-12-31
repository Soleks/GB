using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6
{
    class Minimum
    {
        public delegate double Handler(double a, double b);

        public event Handler Func;
        public event Handler FuncSin;

        public Minimum(string path)
        {
            path_ = path;
        }

        public void SaveFunc(double a, double b, bool mode)
        {
            FileStream fs = new FileStream(path_, FileMode.Create, FileAccess.Write);
            StreamWriter wr = new StreamWriter(fs);

            if (Func == null)
            {
                return;
            }

            if (mode)
            {
                wr.Write(Func(a, b));

            } else
            {
                wr.Write(FuncSin(a, b));
            }

            wr.Close();
            fs.Close();
        }

        public double Load()
        {
            FileStream fs = new FileStream(path_, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            double min = double.MaxValue;
            double d;

            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                // Считываем значение и переходим к следующему
                d = bw.ReadDouble();
                if (d < min) min = d;
            }

            bw.Close();
            fs.Close();
            return min;
        }

        private string path_;
    }
}
