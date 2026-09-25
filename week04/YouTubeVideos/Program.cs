using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Introduction to hybrid vehicles", "The Hybrid Specialist", 600);
        video1.AddComment(new Comment("BabyChiz", "Well explained no need to go to school")); 
        video1.AddComment(new Comment("Keith Size", "Can you also do another one on hydrogen cell"));
        video1.AddComment(new Comment("ByBit Mate", "I liked the way you compared the different types"));
        video1.AddComment(new Comment("Crispen Hail", "Short and precise"));
        videos.Add(video1);


        Video video2 = new Video("Four stroke cycle explained", "The Mechanic", 900);
        video2.AddComment(new Comment("Vehicle Enthusiast", "Simplest explanation ever! ")); 
        video2.AddComment(new Comment("Wonderer", "After watching this I am going to be a mechanic"));
        video2.AddComment(new Comment("Chipo Changu", "Please do another video comparing diesel and petrol engines"));
        video2.AddComment(new Comment("DaddyP", "My son is going to love this"));
        videos.Add(video2);

        Video video3 = new Video("Top 10 Destinations in Zimbabwe", "Travel Zimbabwe", 2400);
        video3.AddComment(new Comment("Masimba Patson", "Adding this to my bucket list")); 
        video3.AddComment(new Comment("The Traveller", "Victoria falls you are hosting me this December"));
        video3.AddComment(new Comment("MamaJ", "Great Zimbabwe is great indeed"));
        video3.AddComment(new Comment("Jonson Bae", "A true narration of the beautiful country"));
        videos.Add(video3);

        Video video4 = new Video("Nature Quench", "Health Enthusiast", 480);
        video4.AddComment(new Comment("Unstoppable", "Thank you nature provides for all our needs")); 
        video4.AddComment(new Comment("SisRue", "I am going to make my own juices from now on"));
        video4.AddComment(new Comment("Girly Piecy", "A low carb video next will complete my health plan"));
        video4.AddComment(new Comment("Bob Biggy", "I tried this and am super happy "));
        videos.Add(video4);   

        Console.Clear();
        foreach(Video video in videos)
        {
            video.Display();
        }

    }


}