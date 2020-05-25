using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args) 
        {
            var book = new Book("Bruce's Grade Book");
            book.AddGrade(8.5);
            book.AddGrade(8.75);
            book.AddGrade(3.75);
            book.ShowStadistics();

            // I Cant Use a method without instance "Greeting.GreetingPublicVoidMethod();" dont work without a new instance
            // But work generating a new instance first
            Greeting SaludoNewObject = new Greeting();
            SaludoNewObject.GreetingPublicVoidMethod();

            //A static method can be called without instance
            Greeting.GreetingPublicStaticMethod();

        }

    }
    
}
