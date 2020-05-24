using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args) 
        {
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
