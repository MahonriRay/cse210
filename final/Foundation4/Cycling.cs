public class Cycling : Activity
{
    float _speed;
    public Cycling(string date, int length, float speed) : base(date, length)
    {
        float distance = (speed * _length) / 60;
        _distance = distance;
        _speed = speed;
    }
}