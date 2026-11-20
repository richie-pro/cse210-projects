using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

    List<Video> videos = new List<Video>();

        // Create Video objects
        Video video1 = new Video("C# Basics", "John Doe", 300);
        Video video2 = new Video("Advanced C#", "Jane Smith", 450);
        Video video3 = new Video("C# Design Patterns", "Alice Johnson", 600);

        // Add videos to the list
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        // Create Comment objects and attach them to videos
        video1.AddComment(new Comment("User1", "Great tutorial!"));
        video1.AddComment(new Comment("User2", "Very helpful, thanks!"));
        video1.AddComment(new Comment("User3", "I learned a lot from this."));
        video1.AddComment(new Comment("User4", "Can you explain more about OOP?"));

        video2.AddComment(new Comment("User3", "I learned a lot from this."));
        video2.AddComment(new Comment("User4", "Can you explain more about delegates?"));
        video2.AddComment(new Comment("User5", "This was a bit too fast-paced for me."));

        video3.AddComment(new Comment("User5", "Design patterns are so useful!"));
        video3.AddComment(new Comment("User6", "Thanks for the clear explanations."));
        video3.AddComment(new Comment("User7", "I appreciate the real-world examples."));

        // Loop and display video information
        foreach (var video in videos)
        {
            video.DisplayVideoInfo();
            Console.WriteLine(); // Blank line for spacing between videos
        }
    }
}