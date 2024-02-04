using System;

namespace ScriptureMemorizer
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define the scripture1
            var scripture1 = new Scripture("John 3:16", "For God so loved the world that he gave his one and only Son, \nthat whoever believes in him shall not perish but have eternal life.");

            // Display the full scripture1
            Console.WriteLine(scripture1);

            // Loop until the words are hidden for scripture1
            while (!scripture1.AllWordsHidden())
            {
                Console.WriteLine("\nPress Enter to hide more words or type 'quit' to finish:");
                string input = Console.ReadLine().ToLower();

                if (input == "quit")
                    break;

                scripture1.HideRandomWord();

                // Clear console & display the scripture1
                Console.Clear();
                Console.WriteLine(scripture1);
            }

            Console.WriteLine("\nAll words have been hidden for scripture1. Press any key to continue...");
            Console.ReadKey();

            // Define the scripture2
            var scripture2 = new Scripture("Proverbs 3:5-6", "Trust in the LORD with all thine heart, and lean not thine own understanding, \nin all thy ways acknowledge him, and he shall direct thy paths.");

            // Display the full scripture2
            Console.WriteLine(scripture2);

            // Loop until the words are hidden for scripture2
            while (!scripture2.AllWordsHidden())
            {
                Console.WriteLine("\nPress Enter to hide more words or type 'quit' to finish:");
                string input = Console.ReadLine().ToLower();

                if (input == "quit")
                    break;

                scripture2.HideRandomWord();

                // Clear console & display the scripture2
                Console.Clear();
                Console.WriteLine(scripture2);
            }

            Console.WriteLine("\nAll words have been hidden for scripture2. Press any key to exit...");
            Console.ReadKey();
        }
    }
}
