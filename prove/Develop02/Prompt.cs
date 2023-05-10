public class Prompt
{
    
    List<string> _prompts = new List<string>();
    // private string _prompt = "";
    
    public Prompt()
    {
        // _prompt = prompt;
    }

    public string GetPrompt()
    {
        Prompt prompt = new Prompt();
        string randomPrompt = prompt.PickRandomPrompt();
        Console.Write($"{randomPrompt}: ");
        return randomPrompt;
    }

    public string GetDate()
    {
        DateTime now = DateTime.Now;
        string formatNow = now.ToString("MM/dd/yyyy");
        return formatNow;
    }

    public string GetResponse()
    {
        string response = Console.ReadLine();
        return $"{response}";
    }

    public string PickRandomPrompt()
    {
        Prompt randPrompt = new Prompt();
        string fileName = "prompts.txt";
        string[] lines = System.IO.File.ReadAllLines(fileName);
        foreach (string line in lines)
        {
            string[] parts = line.Split("~~");

            string promptQuestion = parts[0];

            randPrompt.AddPrompt(promptQuestion);
        }

        int lengthRandPrompt = (randPrompt._prompts.Count());
        // Console.WriteLine(lengthRandPrompt);dot
        Random rnd = new Random();
        int promptNum = rnd.Next(lengthRandPrompt);

        return randPrompt._prompts[promptNum];
    }

    public void AddPrompt(string prompt)
    {
        _prompts.Add(prompt);
    }

    internal void AddPrompt(Entry entry)
    {
        throw new NotImplementedException();
    }
}