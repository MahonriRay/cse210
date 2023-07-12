public class Running : Activity
{

    public Running(string date, int length, float distance) : base(date, length)
    {
        _distance = distance;
    }
}