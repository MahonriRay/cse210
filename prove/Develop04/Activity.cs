public class Activity
{
    public virtual void Display()
    {
        Console.WriteLine($"Welcome to the {this.GetType().Name} Activity");
    }
    public virtual int SessionLength()
    {
        Console.Write($"How long, in seconds, would you like for your session?: ");
        string response = Console.ReadLine();
        int x = Int32.Parse(response);
        return x;
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