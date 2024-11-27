using System;


public class Comment
{
    private string _userName;
    private string _commentText;

    public Comment(string userName, string commentText)
    {
        _userName = userName;
        _commentText = commentText;

    }

    public void DisplayInfo()
    {
        Console.WriteLine($"User: {_userName}");
        Console.WriteLine($"Comment: {_commentText}");
    }
}