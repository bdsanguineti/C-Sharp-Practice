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
            if (grade <= 100 && grade > 0)
            {
                grades.Add(grade);
            }
            else 
            {
                throw new ArgumentException($"The Grade is Invalid {nameof(grade)}.");
            }
        }

        public void AddGrade(char letter)
        {
            switch (letter)
            {
                case 'A':
                    AddGrade(90);
                    break;
                case 'B':
                    AddGrade(80);
                    break;
                case 'C':
                    AddGrade(70);
                break;
                default:
                    AddGrade(0);
                break;
            }
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
        public string Name // Defining a Property
        {
            get; // The backing field is generated automatically.
            private set; 
        }
    }
}