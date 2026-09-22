using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // EXCEEDING REQUIREMENTS:
        // 1. The program loads a library of multiple scriptures and selects one at random to present to the user.
        // 2. The HideRandomWords method in the Scripture class only selects from words that are not already hidden. 

        List<Scripture> scriptures = new List<Scripture>
        {
            new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths."),
            new Scripture(new Reference("John", 3, 16), "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."),
            new Scripture(new Reference("Philippians", 4, 13), "I can do all things through Christ which strengtheneth me.")
        };

        // Select a random scripture from the library
        Random random = new Random();
        int index = random.Next(scriptures.Count);
        Scripture scripture = scriptures[index];

        while (true)
        {
            // Clear the console and display the text (Requirements 3 & 6)
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();

            // When all words are hidden, the program should end (Requirement 8)
            if (scripture.IsCompletelyHidden())
            {
                break;
            }

            // Prompt user for input (Requirement 4)
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            string input = Console.ReadLine();

            // End if the user types 'quit' (Requirement 5)
            if (input.ToLower() == "quit")
            {
                break;
            }

            // Hide 3 words at a time (Requirement 6)
            scripture.HideRandomWords(3);
        }
    }
}