using System;

public class Video 
{   // becuase is basic encapsulation, I will not use Public or Private attributes here, just attributes.
    string _title;
    string _author;
    int _length;

    public List<Comment> _commentsList = new List<Comment>();
    public List<Video> _videoList = new List<Video>();

    // track the title, author and length of the video. For each video, return the number of comments.
    public Video() //Defaults
    {
        _title = "Unknown";
        _author = "Unknown";
        _length = 0;
    }

    // Getters and Setters.
    // I am sure I can use the constructor as the get set but I will just use the methods this time.
    public void GetTitle(string title)
    {
        _title = title;
    }
    public string SetTitle()
    {
        return _title;
    }
    public void GetAuthor(string author)
    {
        _author = author;
    }
    public string SetAuthor()
    {
        return _author;
    }
    public void GetLength(int length)
    {
        _length = length;
    }
    public int SetLength()
    {
        return _length;
    }
    //
    //

    //public void AddCommentToList(string name, string text)
    //{
    //    _commentsList.Add(Comment.GetName(name) + Comment.GetText(text)); 
    //}  // This does not work, I need to use constructors.
    public void AddCommentToList(string name, string text)
    {
        Comment comment = new Comment(name, text);
        _commentsList.Add(comment);
    }
    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {_title} | Author: {_author} | Length: {_length} seconds.");
        Console.WriteLine($"{GetNumberOfComments()} comments in this video.");
        Console.WriteLine($"Comments: ");
        foreach (Comment comment in _commentsList)
        {
            comment.DisplayCommentInfo();
        }
    }
    
    public int GetNumberOfComments()
    {
        return _commentsList.Count;
    }

    
}