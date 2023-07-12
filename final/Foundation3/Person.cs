public class Person
{
    string _name;
    bool _rsvp;

    public Person(string name, bool rvsp)
    {
        _name = name;
        _rsvp = rvsp;
    }

    public bool CheckRSVP()
    {
        return _rsvp;
    }
    public string GetName()
    {
        return _name;
    }
}