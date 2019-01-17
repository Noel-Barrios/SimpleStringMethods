using System;

namespace SimpleStringMethods
{
    class Program
    {
        static void Main(string[] args)
        {

            string greeting = "     Hello World!     ";
            Console.WriteLine($"[{greeting}]");

            //Now trim the spaces at the beginning of the greeting string
            string trimmedGreeting = greeting.TrimStart();
            Console.WriteLine($"[{trimmedGreeting}]");

            //now trim the spaces at the end of the greeting string
            trimmedGreeting = trimmedGreeting.TrimEnd();
            Console.WriteLine($"[{trimmedGreeting}]");




            // using the Trim() method would essentially do the same thing.
            trimmedGreeting = greeting.Trim();
            Console.WriteLine($"[{trimmedGreeting}]");



        }
    }
}
