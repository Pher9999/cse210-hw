using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        // Create some videos
        Video video1 = new Video("C# Encapsulation", "Scott Burton", 391);
        Video video2 = new Video("Principle Review: Abstraction", "Bro Burton", 748);
        Video video3 = new Video("JavaScript Basics", "Alice Johnson", 450);
        // Create some comments for video1
        video1.AddComment(new Comment("User1", "Great video! Very helpful."));
        video1.AddComment(new Comment("User2", "I have a question about encapsulation."));
        video1.AddComment(new Comment("User3", "Can you explain abstraction in more detail?"));

        Console.WriteLine(video1.displayVideo());



        video2.AddComment(new Comment("User1", "Great video! Very helpful."));
        video2.AddComment(new Comment("User2", "I have a question about encapsulation."));
        video2.AddComment(new Comment("User3", "Can you explain abstraction in more detail?"));

        Console.WriteLine(video2.displayVideo());



        video3.AddComment(new Comment("User1", "Great video! Very helpful."));
        video3.AddComment(new Comment("User2", "I have a question about encapsulation."));
        video3.AddComment(new Comment("User3", "Can you explain abstraction in more detail?"));
        Console.WriteLine(video3.displayVideo());
        // Create some comments for video3





    }
}