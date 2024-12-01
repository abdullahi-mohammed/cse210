using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create video instances
        Video video1 = new Video("Learn C#", "Code Academy", 600);
        Video video2 = new Video("Master JavaScript", "Tech Gurus", 720);
        Video video3 = new Video("Introduction to AI", "AI for Everyone", 900);

        // Add comments to video1
        video1.AddComment(new Comment("Alice", "Great explanation!"));
        video1.AddComment(new Comment("Bob", "Very helpful. Thanks!"));
        video1.AddComment(new Comment("Charlie", "Looking forward to more videos."));

        // Add comments to video2
        video2.AddComment(new Comment("Dave", "Love the clarity!"));
        video2.AddComment(new Comment("Eve", "Detailed and easy to understand."));
        video2.AddComment(new Comment("Frank", "Can you do an advanced series?"));

        // Add comments to video3
        video3.AddComment(new Comment("Grace", "Amazing insights on AI!"));
        video3.AddComment(new Comment("Heidi", "Best AI introduction I've seen."));
        video3.AddComment(new Comment("Ivan", "Informative and engaging."));

        // Store videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Display video details and comments
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"  - {comment.Name}: {comment.Text}");
            }
            Console.WriteLine(new string('-', 40));
        }
    }
}
