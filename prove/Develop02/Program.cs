using System;
using System.IO; 

    Prompt prompt1 = new Prompt();
    Entry _entry = new Entry();

    Journal myJournal = new Journal();

    string test = prompt1.GetDate();
    // Console.WriteLine($"\n{test}");
    string entryPrompt = prompt1.GetPrompt();
    // Console.WriteLine($"{entryPrompt}");
    string response = prompt1.GetResponse();
    Entry _entry1 = new Entry(test, entryPrompt, response);
    // Console.WriteLine(response);
    // _entry1.AddEntry(_entry1);

    Entry entry2 = new Entry(prompt1.GetDate(), prompt1.GetPrompt(), prompt1.GetResponse());
    // entry2.GetJournalEntry(entry2);
    // entry2.AddEntry(entry2.GetJournalEntry(entry2));
    myJournal.SaveToJournal(entry2.GetJournalEntry(entry2));

    _entry1.AddEntry(entry2.GetJournalEntry(entry2));




    // Entry entry1 = new Entry(test, entryPrompt, response);
    // myJournal.SaveToJournal(entry1.GetJournalEntry(entry1));
    // Menu _menu = new Menu(_entry);
    // _menu.Display();
// class Program
// {
//     static void Main(string[] args)
//     {
//         Entry entry1 = new Entry();
//         string test = entry1.GetDate();
//         Console.WriteLine($"{test}");
//     }
// }