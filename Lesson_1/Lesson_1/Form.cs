using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1
{
    class Form
    {
        public string Name
        {
            get { return name_; }
            set { name_ = value;}
        }

        public string Surname
        {
            get { return surname_; }
            set { surname_ = value; }
        }

        public int Age
        {
            get { return age_; }
            set { age_ = value; }
        }

        public double Growth
        {
            get { return growth_; }
            set { growth_ = value; }
        }

        public double Weight
        {
            get { return weight_; }
            set { weight_ = value; }
        }

        public double BodyMassIndex()
        {
            //I = m / (h * h)
            return weight_ / (growth_ * growth_);
        }

        private string name_;
        private string surname_;
        private int age_;
        private double growth_;
        private double weight_;
    }
}
