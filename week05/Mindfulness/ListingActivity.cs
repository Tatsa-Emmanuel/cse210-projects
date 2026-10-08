using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }

    public void Run()
    {
        DisplayStartingMessage();
        GetRandomPrompt();
        List<string> userList = GetListFromUser();
        _count = userList.Count;
        
        Console.WriteLine($"You listed {_count} items!");
        DisplayEndingMessage();
    }

    public void GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        
        Console.WriteLine("\nList as many responses you can to the following prompt:");
        Console.WriteLine($" --- {_prompts[index]} --- ");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();
    }

    public List<string> GetListFromUser()
    {
        List<string> items = new List<string>();
        
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < futureTime)
        {
            Console.Write("> ");
            string item = Console.ReadLine();
            
            // Ensures empty inputs aren't counted
            if (!string.IsNullOrWhiteSpace(item))
            {
                items.Add(item);
            }
        }

        return items;
    }
}