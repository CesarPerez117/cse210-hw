using System;
using System.Diagnostics.Tracing;
using System.Security.Cryptography.X509Certificates;

class Program
{   // I took usernames from real youtube videos, hope that is not bad.
    static void Main(string[] args)
    {
        
        Video videoManager = new Video();

        // Intro Message
        Console.WriteLine();
        Console.WriteLine("Welcome to Youtube Video Manager");
        Console.WriteLine("This allows you to track and see comments from videos.\nLet's see some examples.");
        Console.WriteLine();

        // Values for 1st Video
        Video video1 = new Video();
        video1.GetTitle("A year living in Iceland");
        video1.GetAuthor("DimitriLifeStyle01");
        video1.GetLength(1097);
        // comments
        // add comments with get set methods was unefective and confused. I changed to constructors usage.
        //Comment comment1_1 = new Comment();
        //comment1_1.GetName("Commentator 1_1");
        //comment1_1.GetText("Commentator text 1_1");
        video1.AddCommentToList("Jonnijuro","Is amazing how beatiful is this country, not matters the cold weather");
        video1.AddCommentToList("Hero-kb96","I will never live in a place were I don't feel the time pass through the day");
        video1.AddCommentToList("Mekaizer","I believe this can be just a one year experience, just to try it and understand it");
        
        

        // Values for 2nd Video
        Video video2 = new Video();
        video2.GetTitle("The future of IA");
        video2.GetAuthor("Nathan Gentile");
        video2.GetLength(1562);
        // comments
        //video2.AddCommentToList("wizzyxy","With wath IA are doing, humanity will go next level now");
        video2.AddCommentToList("jarekDRWAL","I love how you can easily explain how IA's works, very helpful for me");
        video2.AddCommentToList("josMan101","I am honestly scare of what IAs can do when they have enough knowledge and access. Bro that can be the start of Skynet");
        

        // Values for 3rd Video
        Video video3 = new Video();
        video3.GetTitle("What happened to the Need For Speed franchise?");
        video3.GetAuthor("AutoMotor Player");
        video3.GetLength(702);
        // comments
        video3.AddCommentToList("TIM_5554","We understand that EA has some guilty, but community is not helping either");
        video3.AddCommentToList("josh-m3-gtr","the last good game was most wanted!");
        video3.AddCommentToList("Mark-Munch","Community is really divided there. EA tried innovation, but users wants to be in the past always");
        

        // Video values managment
        videoManager._videoList.Add(video1);
        videoManager._videoList.Add(video2);
        videoManager._videoList.Add(video3);

        // Display of videos 
        foreach (var video in videoManager._videoList)
        {
            Console.WriteLine();
            video.DisplayVideoInfo();
        }


    }
}