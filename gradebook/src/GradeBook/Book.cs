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
            Name = name;
        }

        public void addGrade(double grade)
        {
            grades.Add(grade);
        }

        public Stadistics getStadistics()
        {
            var result = new Stadistics();
            result.average = 0.0;
            result.highValue = double.MinValue;
            result.lowValue = double.MaxValue;            

            foreach(var grade in grades)
            {
                // if (number > highGrade) highGrade = number;
                result.highValue = Math.Max(grade, result.highValue);
                result.lowValue = Math.Min(grade, result.lowValue);
                result.average+= grade;
            }
            result.average/=grades.Count; 
            Console.WriteLine($"The min value is {lowerGrade}, The max Value is {highGrade}, and the Average is {acum}");
            return result;
            //result /= grades.Count;
            //Console.WriteLine($"The Average grade is: {result:N3}"); // result:N3 -> 3 digits after decimal place.            
        }

        // Fields Declaration
        private List<double> grades;
        public string Name; // UperCase Convention: Public Name, Method
    }
}