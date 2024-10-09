using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation1 World!");

        List<Video> videoList = new List<Video>();

        Video video1 = new Video("How to play the ukulele?", "Alice Johnson", 3000);
        video1.AddComment(new Comment("John", "Great explanation!"));
        video1.AddComment(new Comment("Sara", "Very helpful, thank you."));
        video1.AddComment(new Comment("Mike", "Wow! You're so talented."));

        Video video2 = new Video("Advanced C# Features", "Bob Smith", 450);
        video2.AddComment(new Comment("Anna", "I learned a lot about delegates!"));
        video2.AddComment(new Comment("Eve", "Thanks for covering async/await."));
        video2.AddComment(new Comment("James", "Not sure I understand LINQ yet."));
        video2.AddComment(new Comment("Rachel", "Fantastic video, looking forward to the next one."));

        Video video3 = new Video("Baking a cake blindfolded", "Charlie Brown", 4220);
        video3.AddComment(new Comment("Tom", "Hilarious!!"));
        video3.AddComment(new Comment("Linda", "Man, I couldn't have done it that well!"));
        video3.AddComment(new Comment("Robert", "Great video! Please make pizza next time!"));

        videoList.Add(video1);
        videoList.Add(video2);
        videoList.Add(video3);

        foreach (var video in videoList)
        {
            Console.WriteLine($"Video Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length: {video._length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");

            Console.WriteLine("Comments:");
            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"- {comment._name}: {comment._text}");
            }

            Console.WriteLine(new string('-', 50));
        }
    }
}