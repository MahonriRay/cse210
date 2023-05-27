public class Scripture : Reference
{
    // iterate through Words that _isHidden is false and give those words numbers to flip
    List<Word> _words = new List<Word>();
    List<Word> _hiddenWords = new List<Word>();
    Reference _ref;
    // verse will be the actual words of the verse
    string _verse; 
    // public static ConsoleKey keyInfo;
    int thwRound = 0;
    int highestRnd = -1;
    int randomNumber = 2;
    bool allHidden = true;
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
    public void ConvertStringToList()
    {
        string[] indivWords = _verse.Split(" ");
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
    public void UnHideWords()
    {
        foreach (Word thingy in _hiddenWords)
        {
            thingy.UnHideWord();
        }
    }
    public bool CheckAllWordsHidden()
    {
        foreach (Word word in _words)
        {
            if(word.GetHiddenStatus() == true)
            {
                allHidden = true;
            }
            else
            {
                allHidden = false;
                return false;
            }
        }
        return true;
    }
    public void TestHideWords()
    {   
        foreach (Word thangthang in _words)
        {
            int wrdRound = thangthang.GetRoundHidden();
            if(wrdRound > 0)
            {
                if(wrdRound > highestRnd)
                {
                    thangthang.HideWord();
                    highestRnd = wrdRound;
                }
            }
        }
        if (thwRound + 1 > highestRnd)
        {
            foreach (Word thingamajig in _words)
            {
                // possible if statement needed here to check if word has been hidden previously
                if(thingamajig.GetRoundHidden() > 0)
                {
                    thingamajig.WriteHideWord();
                }
                else
                {
                    var random = new Random();
                    if(randomNumber < 3)
                    {
                        int thisRound = thwRound + 1;
                        thingamajig.HideWord();
                        thingamajig.WriteHideWord();
                        if(thingamajig.GetRoundHidden() > 0)
                        {
                            // thingamajig.SetRoundHidden(thingamajig.GetRoundHidden());
                        }
                        else
                        {
                        thingamajig.SetRoundHidden(thisRound);
                        }
                    }
                    else
                    {
                        thingamajig.WriteHideWord();
                    }
                var randomNmbr = random.Next(0,11);
                randomNumber = randomNmbr;
                }
            }
            
        }
        else
        {
            foreach (Word thang in _words)
            {
                if(thang.GetRoundHidden() == thwRound + 1)
                {
                    thang.HideWord();
                }
                thang.WriteHideWord();
            }
        }
        // break;
            
        randomNumber = 2;
    }
    public void HideDemWords()
    {
        Console.Clear();
        DisplayRef();
        WriteOutWord();
        while(true)
        {
            if(CheckAllWordsHidden())
            {
                Console.WriteLine("\nAll words have been hidden. [U]ndo to show previously hidden words - [Q]uit to exit program");
            }
            else
            {
            Console.WriteLine("\n[RETURN] to hide more words - [U]ndo to show previously hidden words - [Q]uit to exit program");
            }
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            if(keyInfo.KeyChar == '\r')
            {
                Console.Clear();
                DisplayRef();
                TestHideWords();
                // Console.WriteLine();
                thwRound++;
            }
            else if(keyInfo.Key == ConsoleKey.U)
            {
                Console.Clear();
                DisplayRef();
                foreach (Word themWords in _words)
                {
                    if (themWords.GetRoundHidden() == thwRound)
                    {
                        themWords.UnHideWord();
                    }
                }
                // TestHideWords();
                foreach (Word thoseWords in _words)
                {
                    thoseWords.WriteHideWord();
                }
                if(thwRound>0)
                {
                thwRound--;
                }
                else
                {
                    
                }
                // Console.WriteLine();
            }
            else if(keyInfo.Key == ConsoleKey.Q)
            {
                Environment.Exit(0);
            }
        }
    }
}

//   -------------------------------
//  |        CODE GRAVEYARD         |
//   -------------------------------
//                -|-
//                 |
//             .-'~~~`-.
//           .'         `.
//           |  R  I  P  |
//           |           |
//           |           |
//         \\|           |//
// ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
// public void DisplayRef()
// {
//     if(_ref._book)
// }
// while(keyInfo = ConsoleKey.Enter || keyInfo = ConsoleKey.U)
// if(keyInfo.Key == ConsoleKey.Enter)
// if round hidden == current round || round hidden == 0
// _hiddenWords.Add(new Word(thingamajig.GetWord(), true, thingamajig.GetWord(), thisRound));
// Console.WriteLine($"The user entered an {keyInfo.Key}");
// hdwRound++;
// hdwRound = HideDemWords Round
// int hdwRound = 0;
// string response = "";
// string[] options = {"u", "\n"};
// var keyInfo = Console.ReadKey();
// int currentRound = hdwRound + 1;

// ~~ TestHideWords ~~
        // thwRound = TestHideWord Round
        // int thwRound = 0;
        // foreach (Word thingy in _words)
        // {
        //     thingy.WriteHideWord();
        //     // int checkIf = thingy.GetRoundHidden();
        //     // if(thingy.GetRoundHidden() >= thwRound || thingy.GetRoundHidden() == 0)
        //     // {
        //     //     thingy.UnHideWord();
        //     //     thingy.WriteHideWord();
        //     // }
        //     // if(checkIf >= thwRound)
        //     // {
        //     //     // foreach (Word thang in _words)
        //     //     // {
        //     //         thingy.WriteHideWord();
        //     //     // }
        //     // }
        //     else
        //     {

        //     }
        //     return;
        // }  
        // thangthang.GetHiddenStatus() == true

//         // int wordCount = 0;
        // string wordCnt = wordCount.ToString();
        // string newWord = $"newWord{wordCnt}";

        //     foreach (Word thang in _words)
// {
//     thang.WriteHideWord();
// }
// public void TestAdd()
// {
//     _words.Add(new Word("I,", false, "I,"));
//     _words.Add(new Word("Nephi", false, "Nephi"));
// }

                    // else if(themWords.GetRoundHidden() > thwRound)
                    // {
                    //     themWords.HideWord();
                    // }
                    // themWords.WriteHideWord();