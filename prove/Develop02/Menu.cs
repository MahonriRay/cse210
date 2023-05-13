public class Menu
{
    private Journal _journal;
    private Prompt _prompt;
    private Entry _entry;

    public Menu(Entry entry)
    {
        _entry = entry;
    }


    public void Display()
    {
        Journal displayJournal = new Journal();
        string response = "";
        string[] options = {"1","2","3","4","5"};
        while (response != "5")
        {
            while(options.Contains(response)==false)
            {
                Console.Write("1. Write\n2. Display\n3. Save\n4. Load\n5. Quit\n");
                Console.Write("Please select an option: ");
                response = Console.ReadLine() ?? String.Empty;
            }
            switch (response)
            {
                case "1":
                    // Write Journal Entry - Save it to add entry so that it can be displayed or saved from a list.
                    Console.WriteLine();
                    Prompt newPrompt = new Prompt();
                    Entry newEntry = new Entry(newPrompt.GetDate(), newPrompt.GetPrompt(), newPrompt.GetResponse());
                    displayJournal.AddEntry(newEntry.GetJournalEntry(newEntry));
                    Console.WriteLine();

                    break;
                case "2":
                    // Display Journal entries, iterate from list.
                    displayJournal.DisplayFromEntries();
                    break;
                case "3":
                    // Save to Journal - saves to myJournal.txt - iterate through list with SaveToJournal function
                    displayJournal.SaveEntries();
                    break;
                case "4":
                    // Load from saved Journal - Ask for date/prompt, if neither, display entire journal
                    displayJournal.LoadFromJournal();
                    break;
                case "5":
                    Environment.Exit(0);
                    break;
            }
            response = "";
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
                    // string date = displayPrompt.GetDate();
                    // string prompt = displayPrompt.GetPrompt();
                    // Console.WriteLine(prompt);
                    // string userResponse = displayPrompt.GetResponse();
                    // _entry.AddEntry(new Entry(date, prompt, userResponse));
