public class Event
{
    protected string _titleOfEvent;
    protected string _descriptionOfEvent;
    protected string _dateOfEvent;
    protected int _timeOfEvent; //Use Military Time (1200, 1600, 2100, etc.)
    protected Address _addressOfEvent;

    public Event(string titleOfEvent, string descriptionOfEvent, string dateOfEvent, int timeOfEvent, Address address)
    {
        _titleOfEvent = titleOfEvent;
        _descriptionOfEvent = descriptionOfEvent;
        _dateOfEvent = dateOfEvent;
        _timeOfEvent = timeOfEvent;
        _addressOfEvent = address;
    }

    public void DisplayEventDetails() //title, desc, date, time, address
    {
        Console.WriteLine($"{_titleOfEvent} -- {_descriptionOfEvent}\n"
        +$"When: {_dateOfEvent} at {_timeOfEvent}\n"
        +$"Where: {_addressOfEvent.DisplayAddress()}");
    }
    public void ShortDescription()
    {
        Console.WriteLine(Border());
        Console.WriteLine($"Type of Event: {this.GetType().Name}\n"+
        $"Title: {_titleOfEvent}\n"+
        $"Date: {_dateOfEvent}");
        Console.WriteLine(Border());
    }
    public string Border()
    {
        return "==========================================================================";
    }
}