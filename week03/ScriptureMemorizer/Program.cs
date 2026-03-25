using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        Reference reference = new Reference("2 Nephi", 28, 1, 3);
        Scripture scripture = new Scripture(reference, "And now, behold, my brethren, I have spoken unto you, according as the Spirit hath constrained me; wherefore, I know that they must surely come to pass. And the things which shall be written out of the book shall be of great worth unto the children of men, and especially unto our seed, which is a remnant of the house of Israel. For it shall come to pass in that day that the churches which are built up, and not unto the Lord, when the one shall say unto the other: Behold, I, I am the Lord’s; and the others shall say: I, I am the Lord’s; and thus shall every one say that hath built up churches, and not unto the Lord.");
    }
}