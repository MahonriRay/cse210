public class Swimming : Activity
{
    // int _laps;
    public Swimming(string date, int length, int laps) : base(date, length)
    {
        float distance = (((laps * 50)/1000.3f * 0.62f));
        _distance = distance;
        _laps = laps;
    }

    public override void DisplaySummary()
    {
        Console.WriteLine($"{_date} {this.GetType().Name} ({_length} min) - Distance {Math.Round(_distance, 2)} miles, Speed {Math.Round((_distance / _length) * 60, 2)} mph, Pace: {Math.Round((_length / _distance), 2)} min per mile");
    }
}