using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        Video video1 = new Video();
        Video video2 = new Video();
        Video video3 = new Video();
        video1._author = "Daniel";
        video1._title = "Why making youtube videos is a bad idea.";
        video1._length = 300;
        video2._author = "Gideon";
        video2._title = "How to git good at Rocket League";
        video2._length = 601;
        video3._author = "Seth";
        video3._title = "Why you should play OverWatch!";
        video3._length = 30;
        
        Comment comment1 = new Comment();
        comment1.name = "Timmy";
        comment1.text = "Wow that was awesome";
        Comment comment2 = new Comment();
        comment2.name = "Jonah";
        comment2.text = "What this video was trash";
        Comment comment3 = new Comment();
        comment3.name = "Jonathan";
        comment3.text = "I thought this video was okay";
        video1.addComment(comment1);
        video1.addComment(comment2);
        video1.addComment(comment3);
        Comment comment4 = new Comment();
        comment4.name = "Nathan";
        comment4.text = "I am actually way better at Rocket League than you.";
        Comment comment5 = new Comment();
        comment5.name = "Tyraine";
        comment5.text = "Nice flip reset double tap my dude!";
        Comment comment6 = new Comment();
        comment6.name = "Chasmic";
        comment6.text = "Save that one Pizza Boy!!!";
        video2.addComment(comment4);
        video2.addComment(comment5);
        video2.addComment(comment6);
        Comment comment7 = new Comment();
        comment7.name = "Tracer";
        comment7.text = "Too Slow!";
        Comment comment8 = new Comment();
        comment8.name = "Lucio";
        comment8.text = "Can't stop, Won't Stop!";
        Comment comment9 = new Comment();
        comment9.name = "Zaria";
        comment9.text = "That tickles.";
        video3.addComment(comment7);
        video3.addComment(comment8);
        video3.addComment(comment9);

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach(Video video in videos){
            video.DisplayInformation();
        }
        
        
    }
}