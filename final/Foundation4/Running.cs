public class Running : Activity
{

    public Running(string date, int length, float distance) : base(date, length)
    {
        _distance = distance;
    }

    public override void DisplaySummary()
    {
        Console.WriteLine($"{_date} {this.GetType().Name} ({_length} min) - Distance {_distance} miles, Speed {(_distance / _length) * 60} mph, Pace: {_length / _distance} min per mile");
    }
}