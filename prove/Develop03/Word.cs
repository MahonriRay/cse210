public class Word
{
    string _word;
    bool _isHidden;
    string _hiddenWord;

    public Word(string word, bool isHidden, string hiddenWord = "")
    {
        _word = word;
        _isHidden = isHidden;
        _hiddenWord = hiddenWord;
    }

    public void HideWord()
    {
        _isHidden = true;
        // if(_isHidden == true)
        // {
        //     foreach (char letter in _word)
        //     {
        //         Console.Write("_");
        //     }
        //     Console.Write(" ");
        // }
    }
    public void ShowWord()
    {
        if(_isHidden == false)
        {
            foreach (char letter in _word)
            {
                Console.Write(letter);
            }
        }
    }
    public void AddWord(string word)
    {

    }
    public void SetTrue()
    {
        _isHidden = true;
    }
    // public bool GetBool()
    // {
    //     if(_isHidden == true)
    //     {
    //         return true;
    //     }
    //     else
    //     {
    //         return false;
    //     }
    // }
    public string GetWords()
    {
        if(_isHidden == true)
        {
            foreach (char letter in _word)
            {
                Console.Write("_");
            }
        }
        return _word;
    }
    public void WriteHideWord()
    {
        if(_isHidden == true)
        {
            foreach (char letter in _word)
            {
                if(Char.IsPunctuation(letter))
                {
                    Console.Write(letter);
                }
                else
                {
                    Console.Write("_");
                }
            }
            Console.Write(" ");
        }
        else
        {
            Console.Write($"{_word} ");
        }
    }
    public void Display()
    {

    }
}