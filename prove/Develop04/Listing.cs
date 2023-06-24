public class Listing : Activity
{
    List<string> _listPrompts = ReadFile("ListPrompts.txt");
    List<string> _responses = new List<string>();
    protected string _classNameLA = "Listing Activity";

    public override void Display()
    {

        Console.WriteLine("AYO");
        base.Display();
    }
    public override int SessionLength()
    {
        return base.SessionLength();
    }
    public void AskPrompt()
    {
        Console.Clear();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        string randPrompt = PickRandPrompt(_listPrompts);
        Console.WriteLine($"--{randPrompt}--");
        Thread.Sleep(50);
        Countdown(4, 2);
    }
    public void GetResponses()
    {
        Console.Write(">");
        string response = Console.ReadLine();
        StoreResponse(response);
    }
    public void StoreResponse(string response)
    {
        _responses.Add(response);
    }
    public void RunIt()
    {
        int sessLength = SessionLength();
        AskPrompt();
        Thread time = new Thread(() =>Thread.Sleep(sessLength * 1000));
        time.Start();
        while(true)
        {
            while(true)
            {
            GetResponses();
            break;
            }
            if(time.IsAlive == false)
            {
                break;
            }
        }
        time.Join();
    }
}