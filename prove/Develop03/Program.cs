using System;
// Send Brother Hayes an email @Hayesa@byui.edu for extra credit
// Possibly add a rewind function
// WORD CLASS :: Attributes :: string _word, boolean _isHidden Methods :: HideWord, ShowWord, DisplayWord
// REFERENCE CLASS :: Attributes :: string _book, int _chapter, int _firstVerse, int _lastVerse
// Scripture Class :: List<word> _words (Word the class, not just a word), Reference _ref Methods:: Display, ConvertStringToList, HideWords(), IsCompletelyHidden
// Program

Scripture firstScripture = new Scripture(new Reference("1 Nephi", 1, 1), "I, Nephi, having been born of goodly parents. 2. Words of the prophet yo.");



// firstScripture.DisplayRef();
// firstScripture.TestAdd();
firstScripture.ConvertStringToList();
// firstScripture.WriteOutWord();
// firstScripture.TestHideWords();
firstScripture.HideDemWords();


Word firstWord = new Word("POYO", true);
firstWord.HideWord();
// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Hello Develop03 World!");
//     }
// }