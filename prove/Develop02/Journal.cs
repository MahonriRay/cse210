public class Journal
{
    List<string> _entries = new List<string>();
    

    private string NicePrint(string item)
    {
        string border = "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~";
        string text = $"\n{item}\n";
        return $"\n{border}{item}{border}\n";
    }
        public void AddEntry(string entry)
    {
        _entries.Add(entry);
    }
    public void SaveToJournal(string entry, string filename)
    {
        // string filename = Console.ReadLine();
        // Console.WriteLine($"Your file has been saved as {filename}");
        string niceJournalEntry = NicePrint(entry);
        using (StreamWriter outputFile = File.AppendText(filename))
        {            
            // You can add text to the file with the WriteLine method
            outputFile.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            outputFile.WriteLine(entry);
            outputFile.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            // You can use the $ and include variables just like with Console.WriteLine
        }
    }
    public void LoadFromJournal()
    {
        Console.Write("\nWhat is the name of the file you would like to load?: ");
        string fileName = Console.ReadLine();
        Console.WriteLine("\nDisplay:\n1.) All entries?\n2.) Entries from a certain date?");
        Console.Write("Please select an option: ");
        string loadResponse = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(fileName);
        int elementCount = 0;
        if (loadResponse == "1")
        {
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
        else
        {
            Console.Write("What date would you like to read? (mm/dd/yyy):");
            string dateInquiry = Console.ReadLine();
            Console.WriteLine();
            bool isEmpty = true;
            foreach (string line in lines)
            {
                int nextLine = elementCount + 1;
                string[] parts = line.Split("\n");
                // string entry = parts[1];
                if (line.Contains(dateInquiry))
                {
                    isEmpty = false;
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    Console.WriteLine(lines[elementCount]);
                    Console.WriteLine($"{lines[nextLine]}");
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
                }

                elementCount++;
            }
            if (isEmpty == true)
            {
                Console.WriteLine("There are no entries on that date.\n");
            }
        }
    }
    public void DisplayFromEntries()
    {
        bool isEmpty = !_entries.Any();
        if (isEmpty)
        {
            Console.WriteLine("There are no entries to be displayed\n");
        }
        foreach (string entry in _entries)
        {

            Console.WriteLine($"{entry}");
        }
    }
    public string SaveEntries()
    {
        Journal _journal = new Journal();
        Console.WriteLine("\nPlease type a journal name to save your entries. If a file doesn't exist, one will automatically be created.");
        Console.Write("Filename: ");
        string filename = Console.ReadLine();
        Console.WriteLine($"Your file has been saved as {filename}\n");
        foreach (string entry in _entries)
        {
            _journal.SaveToJournal(entry, filename);
        }
        return filename;
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

// private string _entry = "";
// private string _date = "";
// private string _prompt = "";
// public Journal (string entry)
// {
//     _entry = entry;
// }

// private string _entry = "";
// private string _date = "";
// private string _prompt = "";
// public Journal (string entry)
// {
//     _entry = entry;
// }

// else 
// {
//     Console.WriteLine("There are no entries on that date.\n");
//     break;
// }