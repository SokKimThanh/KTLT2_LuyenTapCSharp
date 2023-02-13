using KTLT2_TAODOITUONG.src;
using System;
using System.Collections.Generic;
using static System.Console;
namespace KTLT2_TAODOITUONG
{
    class B_Book
    {
        public B_Book(string name)
        {
            grades = new List<double>();
            this.name = name;
        }

        /// <summary>
        /// cai gi la static deu khong lien quan den lap trinh huong doi tuong
        /// </summary>
        /// <param name="grade"></param>
        public void AddGrade(double grade)// no encapsulation 
        {
            if (grade >= 0 && grade <= 100)
            {
                grades.Add(grade);
            }
            else
            {
                throw new ArgumentException($"{nameof(grade)}");
            }
        }
        public List<double> GetGrade()
        {
            return grades;
        }
        public B_Statics ShowStatics()
        {
            var result = new B_Statics();
            foreach (var number in grades)
            {
                result.lowGrade = Math.Min(number, result.lowGrade);
                result.highGrade = Math.Max(number, result.highGrade);
                result.average += number;
            }
            return result;
        }
        private List<double> grades;// static is mean variable memory no encapsulation 
        private string name;
    }
}
