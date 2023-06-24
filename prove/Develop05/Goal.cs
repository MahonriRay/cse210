public abstract class Goal
{
    Player _player;
    string  _goalName;
    string _description;
    int _goalPoints;
    public abstract void SetGoalName ();
    public abstract void SetDescription ();
    public abstract void SetPoints();

}