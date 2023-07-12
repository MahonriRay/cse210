public class Eternal : Simple
{

    public Eternal()
    {}

    public Eternal(string goalType, string goalName, string description, int goalPoints)
    {
        _goalType = goalType;
        _goalName = goalName;
        _description = description;
        _goalPoints = goalPoints;  
    }

    public void SetEternalGoal()
    {
        _goalType = "Eternal";
        SetGoalName();
        SetDescription();
        SetPoints();
    }
    public override void SaveToFile(string userName)
    {
        using(StreamWriter outputFile = File.AppendText($"Players/{userName}.txt"))
        {
            outputFile.WriteLine($"{_goalType},{_goalName},{_description},{_goalPoints.ToString()}");
        }
    }
    public override void DisplayGoals()
    {
        Console.Write($"[ ] {_goalName} ({_description})");
    }
    public override string StringifyGoal(Goal goal)
    {
        return ($"{goal.DisplayGoalType()},{goal.DisplayGoalName()},{goal.DisplayGoalDescription()},{goal.GetPoints().ToString()}");
    }
    // public override string StringifyGoal(Goal goal)
    // {
    //     return ($"{_goalType},{_goalName},{_description},{_goalPoints.ToString()}");
    // }    
    // string  _goalName;
    // string _description;

    // public Eternal(Player player, string goalType, string goalName, string description, int goalPoints) : base(player, goalType, goalName, description, goalPoints)
    // {
    // }
}