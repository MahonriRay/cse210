public class Reference
{
    string _book;
    int _chapter;
    int _firstVerse;
    int _lastVerse;

    public Reference(string book, int chapter, int firstVerse, int lastVerse = -1)
    {
        _book = book;
        _chapter = chapter;
        _firstVerse = firstVerse;
        _lastVerse = lastVerse;
    }
    public Reference()
    {

    }

    public void DisplayReference()
    {
        if(_lastVerse > 0)
        {
            Console.WriteLine($"{_book} {_chapter}: {_firstVerse}-{_lastVerse}");
        }
        else
        {
            Console.WriteLine($"{_book} {_chapter}: {_firstVerse}");
        }
    }

}    
