public abstract class Goal
{
    protected Player _player;
    protected string _goalType;
    protected string  _goalName;
    protected string _description;
    protected int _goalPoints;
    protected bool _isDone;
    protected int _timesDone;
    protected int _bonusRequirement; //How many times the goal needs to be done to get bonus
    protected int _bonusPoints;
    public abstract int SetGoalType();
    public abstract void DisplayGoals();
    public abstract void SetGoalName ();
    public abstract void SetDescription ();
    public abstract void SetPoints();
    public abstract void SaveToFile(string userName);
    public abstract string StringifyGoal(Goal goal);

    public string DisplayGoalType()
    {
        return _goalType;
    }
    public string DisplayGoalName()
    {
        return _goalName;
    }
    public string DisplayGoalDescription()
    {
        return _description;
    }
    public int GetPoints()
    {
        return _goalPoints;
    }
    public bool GetIsDone()
    {
        return _isDone;
    }
    public void SetDone()
    {
        _isDone = true;
    }
    public void addTimeDone()
    {
        _timesDone ++;
    }
    public int GetTimesDone()
    {
        return _timesDone;
    }
    public int GetBonusRequirement()
    {
        return _bonusRequirement;
    }
    public int GetBonus()
    {
        return _bonusPoints;
    }
}