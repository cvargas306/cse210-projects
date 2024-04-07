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
                    new Comment { CommenterName = "@youtube_user 01", Text = "Interesting" },
                    new Comment { CommenterName = "@youtube_user 02", Text = "Thanks for sharing!" }
                }
            },

            new Video
            {

                Title= "Video B",
                Author= "Author B",
                Length= 110,
                Comments= new List<Comment>
                {
                    new Comment { CommenterName = "@youtube_user 03", Text = "WOW" },
                    new Comment { CommenterName = "@youtube_user 04", Text = "Nice!" },
                    new Comment { CommenterName = "@youtube_user 05", Text = "Beautiful!" }
                }
            },

            new Video
            {

                Title= "Video C",
                Author= "Author C",
                Length= 240,
                Comments= new List<Comment>
                {
                    new Comment { CommenterName = "@youtube_user 06", Text = "Incredible" },
                    new Comment { CommenterName = "@youtube_user 07", Text = "I can't believe it!" },
                    new Comment { CommenterName = "@youtube_user 08", Text = "How is it possible?!" }
                }
            },

            new Video
            {

                Title= "Video D",
                Author= "Author D",
                Length= 167,
                Comments= new List<Comment>
                {
                    new Comment { CommenterName = "@youtube_user 3", Text = "We need more videos like this!" },
                    new Comment { CommenterName = "@youtube_user 4", Text = "I've learned a lot with this video" }
                }
            }


        };
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}, Author: {video.Author}, Length: {video.Length}, Number of comments: {video.GetNumbersOfComments()}");
            foreach (var comment in video.Comments)
            {
                Console.WriteLine($" Comment by {comment.CommenterName}:, {comment.Text} ");
            }
        }
    }

}