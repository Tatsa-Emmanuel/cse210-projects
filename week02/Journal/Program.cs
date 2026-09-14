using System;

/*
 * EXCEEDING REQUIREMENTS:
 * 1. Added a Mood/Energy tracking field to the Entry class and file persistence.
 *    This addresses the journal-keeping obstacle of reflecting on emotional states.
 * 2. Implemented a robust multi-character delimiter ("~|~") for file I/O to prevent
 *    formatting corruptions from standard user punctuation.
 * 3. Added file existence checks in LoadFromFile to prevent application crashes on invalid filenames.
 */

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        bool isRunning = true;

        Console.WriteLine("Welcome to the Journal Program!");

        while (isRunning)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            string choice = Console.ReadLine()?.Trim();

            switch (choice)
            {
                case "1":
                    // Generate prompt
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine(prompt);
                    Console.Write("> ");
                    string response = Console.ReadLine();

                    // Collect mood/energy level
                    Console.Write("What is your current mood/energy level? ");
                    string mood = Console.ReadLine();

                    // Get formatted current date
                    string dateText = DateTime.Now.ToShortDateString();

                    // Construct and save entry
                    Entry newEntry = new Entry
                    {
                        _date = dateText,
                        _promptText = prompt,
                        _entryText = response,
                        _mood = mood
                    };

                    journal.AddEntry(newEntry);
                    Console.WriteLine();
                    break;

                case "2":
                    journal.DisplayAll();
                    break;

                case "3":
                    Console.Write("What is the filename? ");
                    string loadFileName = Console.ReadLine();
                    journal.LoadFromFile(loadFileName);
                    break;

                case "4":
                    Console.Write("What is the filename? ");
                    string saveFileName = Console.ReadLine();
                    journal.SaveToFile(saveFileName);
                    break;

                case "5":
                    isRunning = false;
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please enter a number from 1 to 5.\n");
                    break;
            }
        }
    }
}