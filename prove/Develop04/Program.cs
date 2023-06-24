using System;
using System.Threading.Tasks;
// Menu Class - METHODS: Choose Activity - Display(Starting & Ending Message) - Animation 
// Breathing Activity - ATTRIBUTES: _timeInput - METHODS: ReceiveTime - Animation
// Reflection Activity - ATTRIBUTES: :METHODS: ReceivePrompt - FollowUpQuestion - Animation
// Listing Activity - ATTRIBUTES: :METHODS: ReceivePrompt - AddEntriesToList

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");
        // Menu menu1 = new Menu();
        // menu1.Display();
        Activity act1 = new Activity();
        Reflection ref1 = new Reflection();
        Listing list1 = new Listing();
        list1.RunIt();
        act1.Countdown(5, 0);
        ref1.PromptThemUp();
        // List<string> prompts = Activity.ReadFile("Prompts.txt");
        // string randPrompt = act1.PickRandPrompt(prompts);
        // Console.WriteLine(randPrompt);
        Breathing breath1 = new Breathing();
        // breath1.BreatheIn(5);
        // breath1.BreatheInAnimation(1500);
        // breath1.BreatheInAnimation(5000);
        // breath1.BreatheOutAnimation(5000);
        breath1.BreatheInOut();
        // breath1.Display();
        // Listing listing1 = new Listing();
        // listing1.Display();
        // breath1.BreatheYo();
    }
}