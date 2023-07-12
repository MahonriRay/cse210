public abstract class Activity
{
    protected List<Activity> _activities = new List<Activity>();
    protected string _date;
    protected int _length; //Set in minutes
    protected float _distance; //Set in miles
    // protected float _speed;
    public Activity(string date, int length)
    {
        _date = date;
        _length = length;
    }

    public void DisplaySummary()
    {
        Console.WriteLine($"{_date} ({_length})");
    }


}