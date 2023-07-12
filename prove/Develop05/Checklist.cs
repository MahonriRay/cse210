public class Checklist : Simple
{
    // int _timesDone;
    // int _bonusRequirement; //How many times the goal needs to be done to get bonus
    // int _bonusPoints;

    public Checklist()
    {}

    public Checklist(string goalType, string goalName, string description, int goalPoints, int timesDone, int bonusRequirement, int bonusPoints)
    {
        _goalType = goalType;
        _goalName = goalName;
        _description = description;
        _goalPoints = goalPoints;
        _timesDone = timesDone;
        _bonusRequirement = bonusRequirement;
        _bonusPoints = bonusPoints;  
    }

    public override void DisplayGoals()
    {
        base.DisplayGoals();
        Console.Write($" -- Currently Completed: {_timesDone.ToString()}/{_bonusRequirement.ToString()}");
    }
    public override void SaveToFile(string userName)
    {
        using(StreamWriter outputFile = File.AppendText($"Players/{userName}.txt"))
        {
            outputFile.WriteLine($"{_goalType},{_goalName},{_description},{_goalPoints.ToString()},{_timesDone},{_bonusRequirement},{_bonusPoints}");
        }
    }
    public void SetChecklistGoal()
    {
        _goalType = "Checklist";
        SetGoalName();
        SetDescription();
        SetPoints();
        _timesDone = 0;
        SetBonusPoints();
        SetBonusRequirement();
    }

    // public void addTimeDone()
    // {
    //     _timesDone ++;
    // }
    public void SetBonusPoints ()
    {
        Console.Write("What is the bonus for accomplishing it that many times?: ");
        string points = Console.ReadLine();
        int bonusPoints = int.Parse(points);
        _bonusPoints = bonusPoints;
    }
    public void SetBonusRequirement ()
    {
        Console.Write("How many times does this goal need to be accomplished for a bonus?: ");
        string requirement = Console.ReadLine();
        int bonusRequirement = int.Parse(requirement);
        _bonusRequirement = bonusRequirement;
    }
    public override string StringifyGoal(Goal goal)
    {
        return ($"{goal.DisplayGoalType()},{goal.DisplayGoalName()},{goal.DisplayGoalDescription()},{goal.GetPoints().ToString()},{goal.GetTimesDone().ToString()},{goal.GetBonusRequirement().ToString()},{goal.GetBonus().ToString()}");
    }
    // public override string StringifyGoal(Goal goal)
    // {
    //     return ($"{_goalType},{_goalName},{_description},{_goalPoints.ToString()},{_timesDone.ToString()},{_bonusRequirement.ToString()},{_bonusPoints.ToString()}");
    // }   
}