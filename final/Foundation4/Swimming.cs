public class Swimming : Activity
{
    int _laps;
    public Swimming(string date, int length, int laps) : base(date, length)
    {
        float distance = (((laps * 50)/1000.3f * 0.62f));
        _laps = laps;
    }
}