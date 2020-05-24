using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args) 
        {
            // List<double> grades = new List<double>();
            var grades = new List<double>() {2.4, 5.5, 6.0, 7.5, 3.5};
            grades.Add(8.5);
            
            var result = 0.0;
            foreach(var number in grades)
            {
                result += number;
            }
            result = result / grades.Count;
            Console.WriteLine($"Average : {result}");
            
            if (args.Length > 0)
            {
                // Console.WriteLine("Hello " + args[0] + "!.");
                // Is equivalent. String Interpolation Example
                Console.WriteLine($"Hello, {args[0]} !.");
                // In this example if we run: "dotnet run -- Bruce", so the cmd returns Hello, Bruce!
            }
            else 
            {
                Console.WriteLine("Hello ");
            }
            
        }
    }
}
