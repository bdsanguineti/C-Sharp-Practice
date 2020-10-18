using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args) 
        {
            var book = new Book("Bruce's Grade Book");
            book.GradeAdded += OnGradeAdded;

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
                catch(ArgumentException ex)                
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

            // Const is Static. 
            Console.WriteLine(Book.Category); 

            Console.WriteLine($"For the book named {book.Name}");
            Console.WriteLine($"The lowest grade is {stats.LowValue}");
            Console.WriteLine($"The highest grade is {stats.HighValue}");
            Console.WriteLine($"The average grade is {stats.Average:N1}");
            Console.WriteLine($"The Letter grade is {stats.Letter}");

        }

        static void OnGradeAdded(object sender, EventArgs e)
        {
            Console.WriteLine("A grade was Added");
        }

    }
    
}
