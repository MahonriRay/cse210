public class Comment
{
    string _commentAuthor;
    string _comment;

    public Comment(string commentAuthor, string comment)
    {
        _commentAuthor = commentAuthor;
        _comment = comment;
    }
    public void DisplayComment()
    {
        Console.WriteLine($"User: {_commentAuthor} -- Comment: {_comment}");
    }
}