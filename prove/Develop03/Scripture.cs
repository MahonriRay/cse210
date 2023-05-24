public class Scripture : Reference
{
    List<Word> _words = new List<Word>();
    Reference _ref;
    // verse will be the actual words of the verse
    string _verse; 
    public static ConsoleKey keyInfo;

    // public Scripture()
    // {

    // }
    
    public Scripture(Reference reference, string verse)
    {
        _verse = verse;
        _ref = reference;
    }

    public void PrintVerse()
    {
        // Scripture scripture = new Scripture();
        Console.WriteLine($"{_verse}");
    }
    public void DisplayRef()
    {
        _ref.DisplayReference();
    }
    // public void TestAdd()
    // {
    //     _words.Add(new Word("I,", false, "I,"));
    //     _words.Add(new Word("Nephi", false, "Nephi"));
    // }
    public void ConvertStringToList()
    {
        string[] indivWords = _verse.Split(" ");
        // int wordCount = 0;
        // string wordCnt = wordCount.ToString();
        // string newWord = $"newWord{wordCnt}";
        foreach (string word in indivWords)
        {
            _words.Add(new Word(word, false, word));
        }
    }
    public void WriteOutWord()
    {
        foreach (Word thingamadoo in _words)
        {
            Console.Write($"{thingamadoo.GetWords()} ");
        }
    }
    public void TestHideWords()
    {
        foreach (Word thingamajig in _words)
        {
            var random = new Random();
            var randomNumber = random.Next(0,10);
            if(randomNumber < 3)
            {
                thingamajig.SetTrue();
                thingamajig.WriteHideWord();
            }
            else
            {
                thingamajig.WriteHideWord();
            }
        }
    }
    public void HideDemWords()
    {
        // string response = "";
        // string[] options = {"u", "\n"};
        // ConsoleKeyInfo keyInfo = "";

        while(keyInfo.Key != ConsoleKey.Enter || keyInfo.Key != ConsoleKey.U)
        {
            Console.Write("[RETURN] to hide more words\n[U]ndo to show previously hidden words");
            ConsoleKey keyInfo = Console.ReadKey();
            if(keyInfo == ConsoleKey.Enter)
            {

            }
        }
    }
    // public void DisplayRef()
    // {
    //     if(_ref._book)
    // }
}