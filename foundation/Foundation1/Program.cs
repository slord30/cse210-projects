using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videoList = new List<Video>();

        //Video 1
        Video video1 = new Video("Name of Video1", "Author of Video1", 503);
        
        //Video 1 Comments
        Comment video1Comment1 = new Comment("Commenter1", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.");
        Comment video1Comment2 = new Comment("Commenter2", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.");
        Comment video1Comment3 = new Comment("Commenter3", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.");

        video1.ListComments(video1Comment1);
        video1.ListComments(video1Comment2);
        video1.ListComments(video1Comment3);

        videoList.Add(video1);

        //Video 2
        Video video2 = new Video("Name of Video2", "Author of Video2", 195);

        //Video 2 Comments
        Comment video2Comment1 = new Comment("Commenter1", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.");
        Comment video2Comment2 = new Comment ("Commenter2", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.");
        Comment video2Comment3 = new Comment ("Commenter3", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.");

        video2.ListComments(video2Comment1);
        video2.ListComments(video2Comment2);
        video2.ListComments(video2Comment3);

        videoList.Add(video2);

        //Video 3
        Video video3 = new Video("Name of Video3", "Author of Video3", 856);

        //Video 3 Comments
        Comment video3Comment1 = new Comment("Commenter1", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.");
        Comment video3Comment2 = new Comment("Commenter2", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.");
        Comment video3Comment3 = new Comment("Commenter3", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.");

        video3.ListComments(video3Comment1);
        video3.ListComments(video3Comment2);
        video3.ListComments(video3Comment3);

        videoList.Add(video3);

        foreach (Video video in videoList)
        {
            video.DisplayInfo();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}