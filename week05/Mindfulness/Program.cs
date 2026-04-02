using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");
        BreathingActivity breathingActivity = new BreathingActivity("Breathing Activity", "This activity will help you relax by guiding you through slow breathing exercises. Focus on your breath and let go of any tension in your body.", 30);
        breathingActivity.DisplayStartingMessage();
        breathingActivity.Run(); // Run the breathing activity for 30 seconds
        breathingActivity.DisplayEndingMessage();

    }
}