public class Activity
{
    protected List<Activity> _activities = new List<Activity>();
    protected string _date;
    protected int _length; //Set in minutes
    protected float _distance; //Set in miles
    protected float _speed;
    protected int _laps;
    public Activity(string date, int length)
    {
        _date = date;
        _length = length;
    }
    public Activity()
    {
        
    }

    public void AddGoal(Activity activity)
    {
        _activities.Add(activity);
    }
    public void DisplayGoals()
    {
        foreach (Activity activity in _activities)
        {
            activity.DisplaySummary();
        }
    }

    public virtual void DisplaySummary()
    {
        // Console.WriteLine($"{_date} {this.GetType().Name} ({_length} min) - Distance {_distance}");
    }


}