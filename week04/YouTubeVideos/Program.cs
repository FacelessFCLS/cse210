using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        List<Video> videos = new List<Video>();

        Video v1 = new Video("How to Survive a Mimic", "MimicSurvivalExpert", 233);
        Comment c1 = new Comment("DisplacerBeast24", "Mimics cannot be trusted!");
        v1.AddComment(c1);
        Comment c2 = new Comment("LawfulGoodClericBro", "I drank a Health Potion once. It was a Mimic. Mouth to Mouth damage is not recommended.");
        v1.AddComment(c2);
        Comment c3 = new Comment("ChairsR4Sitting", "Oh no! Mimics can't be cows, can they?!");
        v1.AddComment(c3);

        Video v2 = new Video("Cute n' Cuddly Cows", "TheCowCommander", 322);
        Comment c4 = new Comment("ChairsR4Sitting", "Yay cows! Cows are the best!");
        v2.AddComment(c4);
        Comment c5 = new Comment("ILUVCOWS", "I love cows.");
        v2.AddComment(c5);
        Comment c6 = new Comment("TheOnlyAirBender", "Cows are awesome, but have you seen my sky bison?");
        v2.AddComment(c6);

        Video v3 = new Video("Speaking of Unspeakable Horrors", "RavensLoft", 245);
        Comment c7 = new Comment("CountSVonZarovich", "If you speak of Unspeakable Horrors in a video, perhaps you did not quite understand the name of that which you speak.");
        v3.AddComment(c7);
        Comment c8 = new Comment("SpeakingOfSpeaking", "I saw one once! ... I don't wanna talk about it.");
        v3.AddComment(c8);
        Comment c9 = new Comment("ChairsR4Sitting", "The only Unspeakable Horror I care about is if Cows stopped being real.");
        v3.AddComment(c9);

        videos.Add(v1);
        videos.Add(v2);
        videos.Add(v3);

        foreach (Video v in videos)
        {
            v.DisplayVideo();
            Console.WriteLine(new string('-', 40));
        }


    }
}