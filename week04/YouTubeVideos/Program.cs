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

        // Display video information
        Console.WriteLine(video1.displayVideo());
        // Create some comments for video1
        Comment comment1 = new Comment("User1", "Great video! Very helpful.");
        Console.WriteLine(comment1.displayComment());
        Comment comment2 = new Comment("User2", "I have a question about encapsulation.");
        Console.WriteLine(comment2.displayComment());
        Comment comment3 = new Comment("User3", "Can you explain abstraction in more detail?");
        Console.WriteLine(comment3.displayComment());

        Console.WriteLine(video2.displayVideo());
        // Create some comments for video2
        Comment comment4 = new Comment("User1", "Great video! Very helpful.");
        Console.WriteLine(comment1.displayComment());
        Comment comment5 = new Comment("User2", "I have a question about encapsulation.");
        Console.WriteLine(comment2.displayComment());
        Comment comment6 = new Comment("User3", "Can you explain abstraction in more detail?");
        Console.WriteLine(comment3.displayComment());


        Console.WriteLine(video3.displayVideo());
        // Create some comments for video3
        Comment comment7 = new Comment("User1", "Great video! Very helpful.");
        Console.WriteLine(comment1.displayComment());
        Comment comment8 = new Comment("User2", "I have a question about encapsulation.");
        Console.WriteLine(comment2.displayComment());
        Comment comment9 = new Comment("User3", "Can you explain abstraction in more detail?");
        Console.WriteLine(comment3.displayComment());




    }
}