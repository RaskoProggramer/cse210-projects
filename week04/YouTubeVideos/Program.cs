using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create video 1
        Video video1 = new Video();
        video1._name = "Introduction to C#";
        video1._author = "Mpho";
        video1._length = 300;

        video1.AddComment(new Comment("John", "Great video!"));
        video1.AddComment(new Comment("Mary", "Very helpful explanation."));
        video1.AddComment(new Comment("Peter", "I learned something new."));


        // Create video 2
        Video video2 = new Video();
        video2._name = "Learning Object-Oriented Programming";
        video2._author = "Sarah";
        video2._length = 450;

        video2.AddComment(new Comment("David", "I understand classes better now."));
        video2.AddComment(new Comment("Lisa", "Excellent tutorial."));
        video2.AddComment(new Comment("James", "Please make more videos like this."));


        // Create video 3
        Video video3 = new Video();
        video3._name = "Introduction to Python";
        video3._author = "Michael";
        video3._length = 600;

        video3.AddComment(new Comment("Thabo", "Python is interesting."));
        video3.AddComment(new Comment("Anna", "This helped me with my assignment."));
        video3.AddComment(new Comment("Sam", "Easy to follow."));


        // Create video 4
        Video video4 = new Video();
        video4._name = "Understanding C# Lists";
        video4._author = "Emily";
        video4._length = 380;

        video4.AddComment(new Comment("Chris", "I finally understand lists."));
        video4.AddComment(new Comment("Daniel", "Very informative."));
        video4.AddComment(new Comment("Sophia", "Thank you for this lesson."));


        // Put all videos in a list
        List<Video> videos = new List<Video>();

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);


        // Display all videos and their comments
        foreach (Video video in videos)
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine($"Title: {video._name}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length: {video._length} seconds");
            Console.WriteLine($"Number of comments: {video.NumberOfComments()}");

            Console.WriteLine("Comments:");

            foreach (Comment comment in video._comment)
            {
                Console.WriteLine($"{comment._name}: {comment._text}");
            }

            Console.WriteLine();
        }
    }
}