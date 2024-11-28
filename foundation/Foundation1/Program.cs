using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Learning C# in 10 minutes", "John Smith", 600);
        video1.AddComment(new Comment("Mary Smith", "Great video!"));
        video1.AddComment(new Comment("Katherine Gilbert", "Could give more examples"));
        video1.AddComment(new Comment("Peter Johnson", "Very informative."));


        Video video2 = new Video("Learning Python", "Anna Snow", 800);
        video2.AddComment(new Comment("Hanna Forbes", "Help me a lot!"));
        video2.AddComment(new Comment("Caroline Smith", "Perfect explanation."));
        video2.AddComment(new Comment("Taylor Bloom", "I didn´t uderstand so well, you will make a part 2?"));

        Video video3 = new Video("Start programming in 10 minutes", "Justin Denvers", 600);
        video3.AddComment(new Comment("Alex Denvers", "The examples helped a lot!"));
        video3.AddComment(new Comment("Charlie Lewis", "Great job!"));
        video3.AddComment(new Comment("Edward Black", "What it´s the best language to start?"));

        List<Video> videos = new List<Video> { video1, video2, video3 };

        foreach (Video video in videos)
        {
            video.DisplayInfo();
            Console.WriteLine($"Comments Number: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");
            video.DisplayComments();
            Console.WriteLine();

        }

    }
}