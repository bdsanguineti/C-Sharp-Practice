using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Book
    {
        // Add Constructor for initializes grades. No return type. Has the same name that the Class.
        public Book(string name)
        {
            this.grades = new List<double>();
            this.name = name;
        }

        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        

        // Fields Declaration
        private List<double> grades;
        private string name;

    }
}