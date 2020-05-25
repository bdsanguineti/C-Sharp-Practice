using System;
// Example for Static

namespace GradeBook
{
    class Greeting
    {
        public void GreetingPublicVoidMethod()
        {
            Console.WriteLine("Only greeting if exist Class instance");
        }
        
        public static void GreetingPublicStaticMethod()
        {
            Console.WriteLine("I can greeting without Class Instance");
        }
    }
}