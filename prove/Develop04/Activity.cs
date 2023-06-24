public class Activity
{
    List<string> _prompts = new List<string>();
    public virtual void Display()
    {
        Console.WriteLine($"Welcome to the {this.GetType().Name} Activity");
    }
    public static List<string> ReadFile(string fileName)
    {
        // List<string> . = new List<string>();
        List<string> listName = new List<string>();
        string fileNameList = fileName + "List";
        string[] lines = System.IO.File.ReadAllLines(fileName);
        foreach (string line in lines)
        {
            string[] parts = line.Split("~~");

            string sentence = parts[0];
            listName.Add(sentence);
        }
        return listName;
    }
    public virtual string PickRandPrompt(List<string> list)
    {
        int lengthRandPrompt = (list.Count());
        Random rnd = new Random();
        int promptNum = rnd.Next(lengthRandPrompt - 1);
        string prompt = list[promptNum];
        list.Remove(list[promptNum]);
        return prompt;
    }
    public virtual int SessionLength()
    {
        Console.Write($"How long, in seconds, would you like for your session?: ");
        string response = Console.ReadLine();
        int x = Int32.Parse(response);
        return x;
    }
    public virtual void Countdown(int time, int cursorPos)
    {
        for (int i = time; 0 < i; i--)
        {
            // Console.Clear();
            Console.SetCursorPosition(0,cursorPos);
            Console.WriteLine($"You may begin in.. {i}");
            Thread.Sleep(1000);
        }
        // int timeMS = time * 1000;
        // int funcDiv = timeMS / 1000; // returns how many seconds are in  
    }
    public virtual void Animation()
    {
        for (int i = 0; i < 3; i++)
        {
            Console.Write("-");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write('\\');
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("|");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(500);
            Console.Write("\b \b");

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
        // if(this.GetType().Name == "Breathing")
        //     Console.WriteLine($"Welcome to the Breathing Activity");
        // else if(this.GetType().Name == "Listing")
        //     Console.WriteLine($"Welcome to the Listing Activity");
        // else if(this.GetType().Name == "Reflection")
        //     Console.WriteLine("Welcome to the Reflection Activity");