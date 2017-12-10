using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3
{
    class Complex
    {
        public Complex()
        {
            im_ = 0;
            re_ = 0;
        }

        public Complex(double im, double re)
        {
            im_ = im;
            re_ = re;
        }

        public Complex Addition(Complex number)
        {
            Complex res = new Complex();

            res.im_ = number.im_ + im_;
            res.re_ = number.re_ + re_;

            return res;
        }

        public Complex Subtraction(Complex number)
        {
            Complex res = new Complex();

            if (re_ > number.re_ && im_ > number.im_)
            {
                res.re_ = re_ - number.re_;
                res.im_ = im_ - number.im_;

                return res;
            }

            res.re_ = number.re_ - re_;
            res.im_ = number.im_ - im_;

            return res;
        }

        public Complex Multiplication(Complex number)
        {
            Complex res = new Complex();

            res.re_ = re_ * number.re_ - im_ * number.im_;
            res.im_ = re_ * number.im_ + number.re_ * im_;

            return res;
        }

        public double Im
        {
            get { return im_; }
            set
            {
                if (value >= 0) im_ = value;
            }
        }

        public override string ToString()
        {
            return re_ + "+" + im_ + "i";
        }

        private double im_;
        private double re_;
    }
}
