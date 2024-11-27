using System;

class Program
{
    static void Main(string[] args)
    {
        Video video = new Video("Learning C# in 10 minutes", "John Smith", 600);
        video.AddComment(new Comment("Mary Smith", "Great video!"));
        video.AddComment(new Comment("Katherine Gilbert", "Could give more examples"));

        video.DisplayInfo();
        Console.WriteLine($"Comments Number: {video.GetCommentCount()}");

        Console.WriteLine("Comments:");
        video.DisplayComments();

    }
}