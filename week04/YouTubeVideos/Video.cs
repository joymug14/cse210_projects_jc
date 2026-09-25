using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;

public class Video
{
    private string _title;
    private string _author;
    private int _lengthInSeconds;
    private List<Comment> _comments;

    public Video(string title, string author, int lengthInSeconds)
    {
        _title = title;
        _author = author;
        _lengthInSeconds = lengthInSeconds;
        _comments = new List<Comment>();

    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);

    }

    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    public void Display()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_lengthInSeconds}");
        Console.WriteLine($"Number of comments: {GetNumberOfComments()}");
        Console.WriteLine($"Comments");

        foreach(Comment comment in _comments)
        {
            Console.WriteLine($" -{comment.GetDisplayText()}");
        }
        Console.WriteLine();
    }




}