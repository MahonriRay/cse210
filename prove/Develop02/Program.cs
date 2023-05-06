using System;

class Program
{
    static void Main(string[] args)
    {
        Entry entry1 = new Entry();
        string test = entry1.GetPrompt();
        Console.WriteLine($"{test}");
    }
}