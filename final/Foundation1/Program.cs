using System;
using System.Collections.Generic;

public class Comment
{
    public string CommneterName {get; set;}
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