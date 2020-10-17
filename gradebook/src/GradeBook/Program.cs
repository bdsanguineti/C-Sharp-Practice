using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args) 
        {
            var book = new Book("Bruce's Grade Book");
            
            while(true)
            {
                Console.WriteLine("Enter a grade or 'q' to quit");
                var input = Console.ReadLine();

                if (input == "q")
                {
                    break;
                }

                try
                {
                    var grade = double.Parse(input);
                    book.AddGrade(grade);
                }
                catch(ArgumentException ex)                // Exception ex
                {
                    Console.WriteLine(ex.Message); 
                }
                catch(FormatException ex)
                {
                    Console.WriteLine(ex.Message); 
                }
                finally
                {
                    //.. Something you want to run every time the try statements its running.
                    Console.WriteLine("**");
                }
            }

            var stats = book.GetStadistics();

            book.name = "";

            Console.WriteLine($"For the book named {book.Name}");
            Console.WriteLine($"The lowest grade is {stats.LowValue}");
            Console.WriteLine($"The highest grade is {stats.HighValue}");
            Console.WriteLine($"The average grade is {stats.Average:N1}");
            Console.WriteLine($"The Letter grade is {stats.Letter}");
            //book.showStadistics();

            // I Cant Use a method without instance "Greeting.GreetingPublicVoidMethod();" dont work without a new instance
            // But work generating a new instance first
            // Greeting SaludoNewObject = new Greeting();
            // SaludoNewObject.GreetingPublicVoidMethod();

            // A static method can be called without instance
            // Greeting.GreetingPublicStaticMethod();

        }

    }
    
}
