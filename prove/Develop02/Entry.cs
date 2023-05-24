public class Entry
{
    List<string> _entries = new List<string>();
    // string _prompt;
    private string _date = "";
    private string _prompt = "";
    private string _response = "";
    private string _emotion = "";
    private string journalEntry = "";
    
    public Entry()
    {

    }
    public Entry (string date, string prompt, string response)
    {
        _date = date;
        _prompt = prompt;
        _response = response;
    }




    public string GetJournalEntry(Entry entry)
    {
        journalEntry = $"\n{entry._date} - {entry._prompt}\n{entry._response}\n";
        return journalEntry;
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
// public void AddEntry(string entry)
// {
//     _entries.Add(entry);
// }