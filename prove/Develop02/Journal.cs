public class Journal
{
    // private string _entry = "";
    // private string _date = "";
    // private string _prompt = "";
    // public Journal (string entry)
    // {
    //     _entry = entry;
    // }
    

    private string NicePrint(string item)
    {
        string border = "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~";
        string text = $"\n{item}\n";
        return $"\n{border}{item}{border}\n";
        // Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        // Console.WriteLine(item);
        // Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
    }
    public void SaveToJournal(string entry)
    {
        string filename = "myJournal.txt";
        string niceJournalEntry = NicePrint(entry);
        using (StreamWriter outputFile = File.AppendText(filename))
        {            
            // You can add text to the file with the WriteLine method
            // outputFile.Write($"\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n{entry}\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            outputFile.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            outputFile.Write(entry);
            outputFile.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            // You can use the $ and include variables just like with Console.WriteLine
        }
    }
}