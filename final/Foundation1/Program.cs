using System;
using System.Collections.Generic;

public class Comment
{
    public string CommenterName {get; set;}
    public string Text {get; set;}
}

public class Video
{
    public string Title {get; set;}
    public string Author {get; set;}
    public int Length {get; set;}
    public List<Comment> Comments {get; set;}

    public int GetNumbersOfComments()
    {
        return Comments.Count;
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos=new List<Video>
        {
            new Video
            {
                Title= "Video A",
                Author= "Author A",
                Length= 60,
                Comments= new List<Comment>
                {
                    new Comment { CommenterName = "Comment 1", Text = "Interesting" },
                    new Comment { CommenterName = "Comment 2", Text = "Thanks for sharing!" }
                }
            },

            new Video
            {

                Title= "Video B",
                Author= "Author B",
                Length= 110,
                Comments= new List<Comment>
                {
                    new Comment { CommenterName = "Comment 1", Text = "WOW" },
                    new Comment { CommenterName = "Comment 2", Text = "Nice!" }
                }
            },

            new Video
            {

                Title= "Video C",
                Author= "Author C",
                Length= 240,
                Comments= new List<Comment>
                {
                    new Comment { CommenterName = "Comment 1", Text = "Incredible" },
                    new Comment { CommenterName = "Comment 2", Text = "I can't believe it!" }
                }
            },

            new Video
            {

                Title= "Video D",
                Author= "Author D",
                Length= 167,
                Comments= new List<Comment>
                {
                    new Comment { CommenterName = "Comment 1", Text = "We need more videos like this!" },
                    new Comment { CommenterName = "Comment 2", Text = "I've learned a lot with this video" }
                }
            },



        };
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}, Author: {video.Author}, Length: {video.Length}, Number of comments: {video.GetNumbersOfComments()}");
            foreach (var comment in video.Comments)
            {
                Console.WriteLine($" Commnet by {comment.CommenterName}:, {comment.Text} ");
            }
        }
    }

}