using System;

namespace SimpleStringMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //trimmingStrings();
            //ReplacingStrings();
            //WorkingWithUpperAndLowerCase();
            SearchingStrings();
        }


        public static void TrimmingStrings()
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


        public static void ReplacingStrings () 
        {
            // the replace method searches for a substring and replaces it with different text.
            // the replace method takes two parameters.  The first parameter is the string to search for.
            // The second parameter is the text to replace it with. 
            string sayHello = "Hello World!";
            Console.WriteLine(sayHello);
            sayHello = sayHello.Replace("Hello", "Greetings");
            Console.WriteLine(sayHello);
        }

        public static void WorkingWithUpperAndLowerCase()
        {
            string hello = "Hello World!";
            Console.WriteLine(hello.ToUpper());
            Console.WriteLine(hello.ToLower());
        }



        public static void SearchingStrings()
        {
            string songLyrics = "You say goodbye, and I say hello";

            // the contains method returns a boolean value which tells you if the string you were searching for was found.
            Console.WriteLine(songLyrics.Contains("goodbye"));
            Console.WriteLine(songLyrics.Contains("greetings"));

            // the StartsWith and EndsWith methods are two similar methods to Contain.  
            // these find a substring at the beginning or the end of the string. 
            Console.WriteLine("\n" + songLyrics.StartsWith("You"));
            Console.WriteLine(songLyrics.StartsWith("goodbye"));
            Console.WriteLine("\n" + songLyrics.EndsWith("hello"));
            Console.WriteLine(songLyrics.EndsWith("goodbye"));
        }

    }
}
