using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videoList = new List<Video>();

        //Video 1
        Video video1 = new Video("50 Website Design Mistakes", "The Website Architect", 503);
        
        //Video 1 Comments
        Comment video1Comment1 = new Comment("Avarn388", "As a recent boot camp graduate and looking to build a portfolio website; thank you for these tips. They are really helpful.");
        Comment video1Comment2 = new Comment("theq937", "I agree having less form fields is generally better, though having both first and last names is valuable and probably worth keeping for many");
        Comment video1Comment3 = new Comment("catchnote2", "Yes a Part 2 please. I seriously enjoy learning from your videos. I find them to be the best. Thanks");

        video1.ListComments(video1Comment1);
        video1.ListComments(video1Comment2);
        video1.ListComments(video1Comment3);

        videoList.Add(video1);

        //Video 2
        Video video2 = new Video("Everything about Web Design in 3 minutes.", "Wuhoo Digital", 195);

        //Video 2 Comments
        Comment video2Comment1 = new Comment("lennox_wrld", "some big advert...so what's web design?");
        Comment video2Comment2 = new Comment ("sawairakhalid8464", "which software you're using for this video ?");
        Comment video2Comment3 = new Comment ("hiteshgautam8087", "Which intro maker do you use?");

        video2.ListComments(video2Comment1);
        video2.ListComments(video2Comment2);
        video2.ListComments(video2Comment3);

        videoList.Add(video2);

        //Video 3
        Video video3 = new Video("The 7 laws of good Web Design", "BONT", 856);

        //Video 3 Comments
        Comment video3Comment1 = new Comment("HarshitDesai", "WHAT!! that color palette overlay trick was mind blowing.");
        Comment video3Comment2 = new Comment("akibtanjil", "This channel is just a goldmine");
        Comment video3Comment3 = new Comment("Sofia0S0S", "This is great content, so different from the other channels that are all the same. Thank you!");

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