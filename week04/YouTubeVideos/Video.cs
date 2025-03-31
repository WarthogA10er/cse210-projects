using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

public class Video
{
    private string _title;
    private string _author;
    private int _lengthInSeconds;
    private List<Commment> _comments;

    public void SetVideo(string title, string author, int lengthInSeconds)
    {
        _title = title;
        _author = author;
        _lengthInSeconds = lengthInSeconds;
        _comments = new List<Commment>{};
    }

    public void AddComment(string commentText, string commenterName)
    {
        Commment comment = new Commment();
        comment.SetComment(commentText, commenterName);
        _comments.Add(comment);
    }

    public int NumberComments()
    {
        int commentCount = _comments.Count;
        return commentCount;
    }

    public void DisplayVideo()
    {
        int commentCount = NumberComments();
        Console.WriteLine($"{_title}:{_lengthInSeconds} - {_author}");
        Console.WriteLine($"commentCount\n");
        foreach(Commment comment in _comments)
        {
            comment.Display();
        }   
    }
}