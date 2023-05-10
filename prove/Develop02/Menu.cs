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
        Prompt displayPrompt = new Prompt();
        string response = "";
        string[] options = {"1","2","3","4","5"};
        while (response != "5")
        {
            while(options.Contains(response)==false)
            {
                Console.Write("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
                response = Console.ReadLine() ?? String.Empty;
            }
            switch (response)
            {
                case "1":
                    string date = displayPrompt.GetDate();
                    string prompt = displayPrompt.GetPrompt();
                    Console.WriteLine(prompt);
                    string userResponse = displayPrompt.GetResponse();
                    // _entry.AddEntry(new Entry(date, prompt, userResponse));

                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "4":
                    break;
                case "5":
                    Environment.Exit(0);
                    break;
            }
            response = "";
        }
    }
}