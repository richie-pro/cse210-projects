using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        List<Video> videos = new List<Video>();

        Video video1 = new Video("C# Basics", "John Doe", 300);
        video1.AddComment(new Comment("User1", "Great tutorial!"));
        video1.AddComment(new Comment("User2", "Very helpful, thanks!"));
        video1.AddComment(new Comment("User3", "Clear and easy to follow."));
        videos.Add(video1);

        Video video2 = new Video("Advanced C#", "Jane Smith", 450);
        video2.AddComment(new Comment("User4", "I learned a lot from this."));
        video2.AddComment(new Comment("User5", "Can you explain more about delegates?"));
        video2.AddComment(new Comment("User6", "The examples really helped."));
        videos.Add(video2);

        Video video3 = new Video("C# Design Patterns", "Alice Johnson", 600);
        video3.AddComment(new Comment("User7", "Design patterns are so useful!"));
        video3.AddComment(new Comment("User8", "Thanks for the clear explanations."));
        video3.AddComment(new Comment("User9", "Bookmarked for future projects."));
        videos.Add(video3);

        foreach (Video video in videos)
        {
            video.DisplayVideoInfo();
            Console.WriteLine();
        }
    }
}