using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Book
    {
        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;
        }
        public void AddGrade(double grade)
        {
            grades.Add(grade);

        }
        public void ShowStatistics()
        {
            
        }
        private List<double> grades;

        

        private string name;
    }
}