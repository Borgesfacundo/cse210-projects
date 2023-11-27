using System;

class Program
{
    static void Main(string[] args)
    {
        //List to save every video
        List<Video> videos = new List<Video>();


        //First Video
        Video v1 = new Video();
        //add title author and length
        v1._author = "Mr Beast";
        v1._title = "Visiting China";
        v1._length = 600;

        //Add comments
        Comment c1 = new Comment();
        c1._cAuthor = "Brandom Rodriguez";
        c1._commentText = "I really liked this video!";
        v1.comments.Add(c1);

        Comment c2 = new Comment();
        c2._cAuthor = "Karen Ortega";
        c2._commentText = "This is so bad!";
        v1.comments.Add(c2);

        Comment c3 = new Comment();
        c3._cAuthor = "Kevin Page";
        c3._commentText = "Wow, i din't know many things about China";
        v1.comments.Add(c3);

        //Add video to a List
        videos.Add(v1);

        // Second Video
        Video v2 = new Video();
        //add title author and length
        v2._author = "Camilo Shane";
        v2._title = "Best Cars of 2023";
        v2._length = 523;

        //Add comments
        Comment c4 = new Comment();
        c4._cAuthor = "Riley Randoll";
        c4._commentText = "I have the first one!";
        v2.comments.Add(c4);

        Comment c5 = new Comment();
        c5._cAuthor = "Kevin Debruyne";
        c5._commentText = "Amazing cars!!!";
        v2.comments.Add(c5);

        Comment c6 = new Comment();
        c6._cAuthor = "Britney Jackson";
        c6._commentText = "I would love to have one of these cars!";
        v2.comments.Add(c6);

        //Add video to a List
        videos.Add(v2);

        //Third Video
        Video v3 = new Video();
        //add title author and length
        v3._author = "Michael Jackson";
        v3._title = "Best Dance Ever";
        v3._length = 302;

        //Add comments
        Comment c7 = new Comment();
        c7._cAuthor = "Frederick Johnson";
        c7._commentText = "That's crazy man!";
        v3.comments.Add(c7);

        Comment c8 = new Comment();
        c8._cAuthor = "Lara Rhoades";
        c8._commentText = "What an amazing video, I loved it!";
        v3.comments.Add(c8);

        Comment c9 = new Comment();
        c9._cAuthor = "Sasha Mae";
        c9._commentText = "To be honest I didn't like this video!";
        v3.comments.Add(c9);

        Comment c10 = new Comment();
        c10._cAuthor = "Rodrigo De Paul";
        c10._commentText = "Nice video Michael, you now have a new follower";
        v3.comments.Add(c10);

        //Add video to a List
        videos.Add(v3);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Video Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Number of comments: {video.NumOfComments()}\n");
            //Reading comments
            for (int i = 0; i < video.comments.Count; i++)
            {
                Console.WriteLine($"{video.comments[i].AddComment()}");
            }
            Console.WriteLine();
        }

    }
}