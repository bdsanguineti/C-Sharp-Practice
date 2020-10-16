using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        //Add Constructor for initializes grades. No return type. Has the same name that the Class.
        public Book(string name)
        {
            this.grades = new List<double>();
            this.name = name;
        }

        public void addGrade(double grade)
        {
            grades.Add(grade);
        }

        public Stadistics getStadistics()
        {
            var result = new Stadistics();            
            var highGrade = double.MinValue;
            var lowerGrade = double.MaxValue;

            foreach(var number in grades)
            {
                // if (number > highGrade) highGrade = number;
                highGrade = Math.Max(number, highGrade);
                lowerGrade = Math.Min(number, lowerGrade);
                acum+= number;
            }
            acum/=grades.Count; 
            Console.WriteLine($"The min value is {lowerGrade}, The max Value is {highGrade}, and the Average is {acum}");
            //result /= grades.Count;
            //Console.WriteLine($"The Average grade is: {result:N3}"); // result:N3 -> 3 digits after decimal place.
        }

        // Fields Declaration
        private List<double> grades;
        private string name;
    }
}