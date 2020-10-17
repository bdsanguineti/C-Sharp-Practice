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

        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public Stadistics GetStadistics()
        {
            var result = new Stadistics();
            result.Average = 0.0;
            result.HighValue = double.MinValue;
            result.LowValue = double.MaxValue;            

            var index = 0;
            
            do                         
            {                
                result.HighValue = Math.Max(grades[index], result.HighValue);
                result.LowValue = Math.Min(grades[index], result.LowValue);
                result.Average+= grades[index];
                index++;
            } while (index < grades.Count);

            result.Average/=grades.Count; 
            return result;
        }

        // Fields Declaration
        private List<double> grades;
        public string Name; // UperCase Convention: Public Name, Method
    }
}