using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Video 1
        Video v1 = new Video("Learn C# in 10 Minutes", "Code Academy", 600);
        v1.AddComment(new Comment("Alice", "Great tutorial, very clear!"));
        v1.AddComment(new Comment("Bob", "This helped me pass my class."));
        v1.AddComment(new Comment("Charlie", "Could you do a video on interfaces next?"));
        videos.Add(v1);

        // Video 2
        Video v2 = new Video("Top 5 Programming Keyboards", "Tech Reviews", 450);
        v2.AddComment(new Comment("Dave", "I love the mechanical switches."));
        v2.AddComment(new Comment("Eve", "Too expensive for my budget."));
        v2.AddComment(new Comment("Frank", "What about ergonomic options?"));
        videos.Add(v2);

        // Video 3
        Video v3 = new Video("Day in the Life of a Software Engineer", "DevLife", 1200);
        v3.AddComment(new Comment("Grace", "So much coffee!"));
        v3.AddComment(new Comment("Heidi", "Do you work remotely everyday?"));
        v3.AddComment(new Comment("Ivan", "Thanks for sharing your routine."));
        v3.AddComment(new Comment("Judy", "Love the office setup."));
        videos.Add(v3);

        // Iterate through the list of videos and display them
        foreach (Video video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}