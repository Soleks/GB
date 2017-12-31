using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6
{
    class BigDataStudents
    {
        private string lastName_;
        private string firstName_;
        private string univercity_;
        private string faculty_;
        private int course_;
        private string department_;
        private int group_;
        private string city_;
        private int age_;

        public BigDataStudents(
            string firstName,
            string lastName,
            string univercity,
            string faculty,
            string department,
            int age,
            int course,
            int group,
            string city)
        {
            lastName_ = lastName;
            firstName_ = firstName;
            univercity_ = univercity;
            faculty_ = faculty;
            department_ = department;
            course_ = course;
            age_ = age;
            group_ = group;
            city_ = city;
        }

        public  int Course
        {
            get
            {
                return course_;
            }
        }

        public override string ToString()
        {
            return String.Format(
                "{0,15}" +
                "{1,15}" +
                "{2,15}" +
                "{3,15}" +
                "{4,15}" +
                "{5,15}" +
                "{6,15}" +
                "{7,5}" +
                "{8,10}",
                firstName_,
                lastName_,
                univercity_,
                faculty_,
                department_,
                age_,
                course_,
                group_,
                city_);
        }
    }
}