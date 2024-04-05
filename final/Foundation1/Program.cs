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
                Title= "Video 1",
                Author= "Author 1",
                Length= 120,
                Comments= new List<Comment>
                {
                    new Comment { CommenterName = "User 1", Text = "Great video!" },
                    new Comment { CommenterName = "User 2", Text = "Thanks for sharing!" }
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