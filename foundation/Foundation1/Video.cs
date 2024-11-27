using System;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comment;



    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comment = new List<Comment>();
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Video Length: {_length} seconds.");
    }

    public void AddComment(Comment comment)
    {

        _comment.Add(comment);

    }

    public int GetCommentCount()
    {
        return _comment.Count;
    }

    public void DisplayComments()
    {
        foreach (Comment comment in _comment)
        {
            comment.DisplayInfo();

        }
    }
}