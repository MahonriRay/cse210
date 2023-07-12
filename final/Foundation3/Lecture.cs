public class Lecture : Event
{
    string _speakerOfEvent;
    int _capacityOfEvent;

    public Lecture(string titleOfEvent, string descriptionOfEvent, string dateOfEvent, int timeOfEvent, Address address, string speakerOfEvent, int capacityOfEvent) : base(titleOfEvent, descriptionOfEvent, dateOfEvent, timeOfEvent, address)
    {
        _speakerOfEvent = speakerOfEvent;
        _capacityOfEvent = capacityOfEvent;
    }

    public void FullDetails()
    {
        Console.WriteLine(Border());
        Console.WriteLine($"Speaker: {_speakerOfEvent}");
        DisplayEventDetails();
        Console.WriteLine($"\nCapacity: {_capacityOfEvent} -- "
        +"Please arrive promptly to secure a seat. Please & Thank You.");
        Console.WriteLine(Border());
    }
}