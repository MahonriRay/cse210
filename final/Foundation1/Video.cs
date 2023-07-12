public class Video
{
    string _title;
    string _author;
    int _videoLength; // Length measured in seconds.
    List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int videoLength)
    {
        _title = title;
        _author = author;
        _videoLength = videoLength;
    }
    public void AddComment(string author, string comment)
    {
        _comments.Add(new Comment(author, comment));
    }
    public void DisplayVidInfo()
    {
        Console.WriteLine($"{_title}({_videoLength / 60}:{_videoLength % 60}) by {_author}");
    }

    public void DisplayComments()
    {
        DisplayVidInfo();
        Console.WriteLine(Border());
        foreach (Comment comment in _comments)
        {
            comment.DisplayComment();
        }
        Console.WriteLine(Border()+"\n");
    }
    public string Border()
    {
        return "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~";
    }
}