using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args) 
        {
            var book = new Book();
            book.AddGrade(8.75);

            // List<double> grades = new List<double>();
            var grades = new List<double>() {2.4, 5.5, 6.0, 7.5, 3.5};
            grades.Add(8.5);
            
            var result = 0.0;
            foreach(var number in grades)
            {
                result += number;
            }
            result /= grades.Count;
            Console.WriteLine($"The Average grade is: {result:N3}"); // result:N3 -> 3 digits after decimal place.
            
        }

    }
    
}
