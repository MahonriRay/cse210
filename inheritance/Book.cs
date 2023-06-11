public class Book : Loanable
{
    string _title;
    string _isbn;
    int _upc;
    public Book(string title, string isbn, int upc)
    {
        _title = title;
        _isbn = isbn;
        _upc = upc;
    }
    public override void Display()
    {
        Console.WriteLine($"Title: {_title}\nISBN: {_isbn}\nUPC: {_upc}");
        base.Display();

    }
}