public class Cycling : Activity
{
    // float _speed;
    public Cycling(string date, int length, float speed) : base(date, length)
    {
        float distance = (speed * _length) / 60;
        _distance = distance;
        _speed = speed;
    }

    public override void DisplaySummary()
    {
        Console.WriteLine($"{_date} {this.GetType().Name} ({_length} min) - Distance {_distance} miles, Speed {_speed} mph, Pace: {_length / _distance} min per mile");
    }
}