using System.Collections.Generic;

namespace GradeBook
{
    class Book
    {
        // Add Constructor for initializes grades. No return type. Has the same name that the Class.
        public Book()
        {
            grades = new List<double>();
        }

        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        // Field Declaration
        List<double> grades;    

    }
}