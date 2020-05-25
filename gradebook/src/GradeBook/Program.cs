using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args) 
        {
            var book = new Book("Bruce's Grade Book");
            book.AddGrade(8.75);

            // List<double> grades = new List<double>();
            var grades = new List<double>() {2.4, 5.5, 6.0, 7.5, 3.5};
            grades.Add(8.5);
            
            var acum = 0.0;
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

            // I Cant Use a method without instance "Greeting.GreetingPublicVoidMethod();" dont work without a new instance
            // But work generating a new instance first
            Greeting SaludoNewObject = new Greeting();
            SaludoNewObject.GreetingPublicVoidMethod();

            //A static method can be called without instance
            Greeting.GreetingPublicStaticMethod();

        }

    }
    
}
