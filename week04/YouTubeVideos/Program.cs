using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create video 1
        Videos video1 = new Videos();
        video1._name = "Introduction to C#";
        video1._author = "Mpho";
        video1._length = 300;

        video1.AddComment(new Comments("John", "Great video!"));
        video1.AddComment(new Comments("Mary", "Very helpful explanation."));
        video1.AddComment(new Comments("Peter", "I learned something new."));


        // Create video 2
        Videos video2 = new Videos();
        video2._name = "Learning Object-Oriented Programming";
        video2._author = "Sarah";
        video2._length = 450;

        video2.AddComment(new Comments("David", "I understand classes better now."));
        video2.AddComment(new Comments("Lisa", "Excellent tutorial."));
        video2.AddComment(new Comments("James", "Please make more videos like this."));


        // Create video 3
        Videos video3 = new Videos();
        video3._name = "Introduction to Python";
        video3._author = "Michael";
        video3._length = 600;

        video3.AddComment(new Comments("Thabo", "Python is interesting."));
        video3.AddComment(new Comments("Anna", "This helped me with my assignment."));
        video3.AddComment(new Comments("Sam", "Easy to follow."));


        // Create video 4
        Videos video4 = new Videos();
        video4._name = "Understanding C# Lists";
        video4._author = "Emily";
        video4._length = 380;

        video4.AddComment(new Comments("Chris", "I finally understand lists."));
        video4.AddComment(new Comments("Daniel", "Very informative."));
        video4.AddComment(new Comments("Sophia", "Thank you for this lesson."));


        // Put all videos in a list
        List<Videos> videos = new List<Videos>();

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);


        // Display all videos and their comments
        foreach (Videos video in videos)
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine($"Title: {video._name}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length: {video._length} seconds");
            Console.WriteLine($"Number of comments: {video.NumberOfComments()}");

            Console.WriteLine("Comments:");

            foreach (Comments comment in video._comments)
            {
                Console.WriteLine($"{comment._name}: {comment._text}");
            }

            Console.WriteLine();
        }
    }
}