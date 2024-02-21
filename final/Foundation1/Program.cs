using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Creating videos
        var videos = new List<Video>
        {
            new Video("Title 1", "Author 1", 150),
            new Video("Title 2", "Author 2", 200),
            new Video("Title 3", "Author 3", 350)
        };

        // Adding comments to videos
        videos[0].AddComment("Timothy Williams", "Wonderful video!");
        videos[0].AddComment("Ayomide Paul", "wow cool topic.");
        videos[0].AddComment("Samson Ope", "I learned so many things.");

        videos[1].AddComment("Joseph Cole", "great work!");
        videos[1].AddComment("Victor Dav", "Wow Educative.");
        videos[1].AddComment("Elizabeth Queen", "please explain more ");

        videos[2].AddComment("Kolawole Adigun", "Imperesive.");
        videos[2].AddComment("Esther James", "Interesting.");
        videos[2].AddComment("john Mercy", "Keep it up ");

        // Displaying video information
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");

            foreach (var comment in video.Comments)
            {
                Console.WriteLine($"{comment.Name}: {comment.Text}");
            }

            Console.WriteLine();
        }
    }
}