using System;

// EXCEEDING REQUIREMENTS:
// 1. Activity Log: The program keeps track of how many times each activity was performed 
//    during the session and displays a summary log when the user chooses to quit.
// 2. No Repeats: In the ReflectingActivity, the program tracks which questions have already 
//    been asked. It only resets the available questions list when all questions have been 
//    used, ensuring no duplicates within a single activity run.

class Program
{
    static void Main(string[] args)
    {
        int breathingCount = 0;
        int reflectingCount = 0;
        int listingCount = 0;
        
        string choice = "";

        while (choice != "4")
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            
            choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity breathing = new BreathingActivity();
                breathing.Run();
                breathingCount++;
            }
            else if (choice == "2")
            {
                ReflectingActivity reflecting = new ReflectingActivity();
                reflecting.Run();
                reflectingCount++;
            }
            else if (choice == "3")
            {
                ListingActivity listing = new ListingActivity();
                listing.Run();
                listingCount++;
            }
            else if (choice == "4")
            {
                Console.Clear();
                Console.WriteLine("Session Activity Log:");
                Console.WriteLine($"Breathing Activities completed: {breathingCount}");
                Console.WriteLine($"Reflecting Activities completed: {reflectingCount}");
                Console.WriteLine($"Listing Activities completed: {listingCount}");
                Console.WriteLine("\nThank you for taking time for yourself today. Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
                Thread.Sleep(2000);
            }
        }
    }
}