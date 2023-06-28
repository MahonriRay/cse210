public abstract class Goal
{
    protected Player _player;
    protected string _goalType;
    protected string  _goalName;
    protected string _description;
    protected int _goalPoints;
    public abstract void SetGoalType();
    public abstract void SetGoalName ();
    public abstract void SetDescription ();
    public abstract void SetPoints();

}