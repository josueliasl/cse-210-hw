using System;
using System.Collections.Generic;
using System.Transactions;

public class Video

{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;
    
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }
    public void AddComment(Comment comments)
    {
      _comments.Add(comments);
    }

    public int GetCommentCount()
    {
        return _comments.Count;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {_title}, Author:{_author}, Length: {_length}, Number of Comments {GetCommentCount()}");
        foreach (Comment _comment in _comments)
        {
           Console.WriteLine($" {_comment.GetDisplayText()}");
        }
    }
}

//