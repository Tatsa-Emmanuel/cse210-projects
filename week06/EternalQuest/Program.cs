using System;

// EXCEEDING REQUIREMENTS:
// To exceed requirements, a "Level Up" rank system has been added to the GoalManager[cite: 8].
// As the user earns points by recording events, their rank dynamically changes 
// (e.g., Novice, Apprentice, Master) when viewing the player info in the main menu.
class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}