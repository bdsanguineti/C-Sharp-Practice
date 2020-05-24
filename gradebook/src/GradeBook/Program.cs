using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello " + args[0] + "!.");
            // Is equivalent. String Interpolation Example
            Console.WriteLine($"Hello, {args[0]} !.");
        }
    }
}
