using System;

class Program
{
    static void Main(string[] args)
    {
        //List to save every video
        List<Video> videos = new List<Video>();

        //First Video
        Video v1 = new Video("Mr Beast", "Visiting China", 600);

        //Add comments
        Comment c1 = new Comment("Brandom Rodriguez", "I realli liked this video!");
        v1.AddToList(c1);

        Comment c2 = new Comment("Karen Ortega", "This is so bad!");
        v1.AddToList(c2);

        Comment c3 = new Comment("Kevin Page", "Wow, I didn't know many thing about China");
        v1.AddToList(c3);

        //Add video to a List
        videos.Add(v1);

        // Second Video
        Video v2 = new Video("Camilo Shane", "Best cars of 2023", 523);

        //Add comments
        Comment c4 = new Comment("Riley Randoll", "I have the first one!");
        v2.AddToList(c4);

        Comment c5 = new Comment("Kevin Debruyne", "Amazing Cars!!!");
        v2.AddToList(c5);

        Comment c6 = new Comment("Britney Jackson", "I would love to have one of these cars!");
        v2.AddToList(c6);

        //Add video to a List
        videos.Add(v2);

        //Third Video
        Video v3 = new Video("Michael Jackson", "Best Dance Ever", 302);

        //Add comments
        Comment c7 = new Comment("Frederick Johnson", "That's crazy man!");
        v3.AddToList(c7);

        Comment c8 = new Comment("Lara Rhoades", "What an amazing video, I loved it!");
        v3.AddToList(c8);

        Comment c9 = new Comment("Sasha Mae", "To be honest I didn't like this video!");
        v3.AddToList(c9);

        Comment c10 = new Comment("Rodrigo De Paul", "Nice video Michael, you now have a new follower");
        v3.AddToList(c10);

        //Add video to a List
        videos.Add(v3);

        foreach (Video video in videos)
        {
            Console.WriteLine(video.ToString());
        }

    }
}