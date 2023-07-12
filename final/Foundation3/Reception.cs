public class Reception : Event
{
    List<Person> _persons = new List<Person>();

    public Reception(string titleOfEvent, string descriptionOfEvent, string dateOfEvent, int timeOfEvent, Address address, List<Person> persons) : base(titleOfEvent, descriptionOfEvent, dateOfEvent, timeOfEvent, address)
    {
        _persons = persons;
    }

    public void FullDetails()
    {

    }
        public void PrintGuestList()
    {
        //Top is the row in which the cursor will be set :)
        string cursorPosition = Console.GetCursorPosition().ToString();
        string cursorPos1 = cursorPosition.Remove(0, 4);
        string cursorTop = cursorPos1.Remove(2, 1);
        int top = int.Parse(cursorTop);
        Console.SetCursorPosition(9, top);
        Console.WriteLine($"Guestlist for {_titleOfEvent}");
        Console.WriteLine(Border());
        top++;
        top++;

        List<Person> _rsvpTRUE = new List<Person>();
        List<Person> _rsvpFALSE = new List<Person>();
        foreach (Person person in _persons)
        {
            if(person.CheckRSVP() == true)
            {
                _rsvpTRUE.Add(person);
            }
            else
            {
                _rsvpFALSE.Add(person);
            }
        }
        Console.Write("Attending:");
        Console.SetCursorPosition(20, top);
        Console.WriteLine("Not Attending:");
        top++;
        while(_rsvpTRUE.Count() != 0 || _rsvpFALSE.Count() != 0)
        {
            foreach (Person person in _rsvpTRUE)
            {
                if(_rsvpTRUE.Count() == 0)
                {
                    Console.Write("");
                    break;
                }
                else
                {
                    Console.Write(person.GetName());
                    _rsvpTRUE.Remove(person);
                    break;
                }
            }
            Console.SetCursorPosition(20, top);
            foreach (Person person in _rsvpFALSE)
            {
                if(_rsvpFALSE.Count() == 0)
                {
                    Console.Write("");
                    break;
                }
                else
                {
                    Console.WriteLine(person.GetName());
                    _rsvpFALSE.Remove(person);
                    break;
                }
            }
            top++;
        }
        Console.WriteLine(Border());
    }
}