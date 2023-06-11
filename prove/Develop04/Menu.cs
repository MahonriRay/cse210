public class Menu
{

    public void Display()
    {
        string response = "";
        string[] options = {"1", "2", "3", "4"};
        while (response != "4")
        {
            while(options.Contains(response)==false)
            {
                Console.WriteLine("Menu Options:");
                Console.WriteLine("\t1.  Start Breathing Activity\n\t2.  Start Reflecting Activity\n\t3.  Start Listing Activity\n\t4.  Quit");
                Console.Write("Select a choice from the menu:  ");
                response = Console.ReadLine() ?? String.Empty;
            }
        }
    }
}