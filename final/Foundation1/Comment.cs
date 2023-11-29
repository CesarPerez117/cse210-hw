using System;

public class Comment
{
    string _name;
    string _text;

    // I am sure I can use the constructor as the get set but I will just use the methods this time.
    public Comment(string name, string text) // With this constructor, I can do get set without having problems.
    {
        _name = name;
        _text = text;
    }

    //public void GetName(string name)
    //{
    //    _name = name;
    //}
    //public string SetName()
    //{
    //    return _name;
    //}
    //public void GetText(string text)
    //{
    //    _text = text;
    //}
    //public string SetText()
    //{
    //    return _text;
    //}

    public void DisplayCommentInfo()
    {
        Console.WriteLine($"{_name}: {_text}");
    }

    // This does not works becuase I need inheritance to make it works
    
    // public string CommentInfo()
    // {
    //    return $"{_name}: {_text}";
    // }
    // public void DisplayCommentInfo()
    // {
    //    Console.WriteLine(CommentInfo());
    // }

    
}