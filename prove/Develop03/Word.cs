public class Word
{
    string _word;
    bool _isHidden;
    string _hiddenWord;
    int _roundHidden;

    public Word(string word, bool isHidden, string hiddenWord = "", int roundHidden=0)
    {
        _word = word;
        _isHidden = isHidden;
        _hiddenWord = hiddenWord;
        _roundHidden = roundHidden;
    }

    public void HideWord()
    {
        _isHidden = true;
    }
    public void UnHideWord()
    {
        _isHidden = false;
    }
    public void SetRoundHidden(int rndHidden)
    {
        _roundHidden = rndHidden;
    }
    public int GetRoundHidden()
    {
        return _roundHidden;
    }
    public string GetWord()
    {
        return _word;
    }
    public bool GetHiddenStatus()
    {
        return _isHidden;
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
    // public void SetTrue()
    // {
    //     _isHidden = true;
    // }
            // if(_isHidden == true)
        // {
        //     foreach (char letter in _word)
        //     {
        //         Console.Write("_");
        //     }
        //     Console.Write(" ");
        // }