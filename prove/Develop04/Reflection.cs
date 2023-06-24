public class Reflection : Activity
{

    List<string> prompts = ReadFile("Prompts.txt");
    List<string> followUps = ReadFile("PromptFollowUp.txt");

    public override void Display()
    {
        Console.Clear();
        base.Display();
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. "+
        "This will help you recognize the power you have and how you can use it in other aspects of your life.");
    }
    public override string PickRandPrompt(List<string> list)
    {
        return base.PickRandPrompt(list);
    }
    public void PromptThemUp()
    {
        int sessionDuration = SessionLength();
        string promptQuestion = PickRandPrompt(prompts);
        Console.WriteLine($"{promptQuestion}");
        Thread time = new Thread(() =>Thread.Sleep(sessionDuration * 1000));
        time.Start();
        while(true)
        {
            while(true)
            {
                string followUp = PickRandPrompt(followUps);
                Console.WriteLine($"{followUp}");
                Console.Read();
                break;
            }
            if(time.IsAlive == false)
            {
                break;
            }
        }
        Console.WriteLine($"This session lasted for {sessionDuration} seconds");
        Animation();
    }
}