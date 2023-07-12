public class Simple : Goal
{
    // string _goalType;
    // public Simple(Player player, string goalType, string goalName, string description, int goalPoints)
    // {
    //     _player = player;
    //     _goalType = goalType;
    //     _goalName = goalName;
    //     _description = description;
    //     _goalPoints = goalPoints;
    // }

    public Simple()
    {}
    public Simple(string goalType, string goalName, string description, int goalPoints, bool isDone)
    {
        _goalType = goalType;
        _goalName = goalName;
        _description = description;
        _goalPoints = goalPoints;
        _isDone = isDone;
    }
    public override void DisplayGoals()
    {
        if(_isDone == true)
        {
            Console.Write($"[X] {_goalName} ({_description})");
        }
        else
        {
            Console.Write($"[ ] {_goalName} ({_description})");
        }
    }

    public override int SetGoalType()
    {
        Console.WriteLine("What type of goal is this?\n"+
        "1.) Simple Goal\n"+
        "2.) Eternal Goal\n"+
        "3.) Checklist Goal");
        int goalSelection = int.Parse(Console.ReadLine());
        int GoalNumType;

        if(goalSelection == 1)
        {
            string goalType = "Simple";
            _goalType = goalType;
            GoalNumType = 1;
        }
        else if(goalSelection == 2)
        {
            string goalType = "Eternal";
            _goalType = goalType;
            GoalNumType = 2;
        }
        else
        {
            string goalType = "Eternal";
            _goalType = goalType;
            GoalNumType = 3;
        }
        return GoalNumType;
    }
    public override void SetGoalName()
    {
        Console.Write("What is the name of you goal?: ");
        string goalName = Console.ReadLine();
        _goalName = goalName;
    }

    public override void SetDescription()
    {
        Console.Write("Write a short description of your goal: ");
        string description = Console.ReadLine();
        _description = description;
    }

    public override void SetPoints()
    {
        Console.Write("How many points would you like this goal be worth(0 - 250): ");
        string points = Console.ReadLine();
        int goalPoints = int.Parse(points);
        _goalPoints = goalPoints;
    }
    public void SetIsDone()
    {
        Console.WriteLine("Have you finished this goal?\n"+
        "1.) Yes\n2.) No");
        string response = Console.ReadLine();
        if(response == "1")
        {
            _isDone = true;
        }
    }
    public void SetSimpleGoal()
    {
        _goalType = "Simple";
        SetGoalName();
        SetDescription();
        SetPoints();
        _isDone = false;
    }
    // public void SetDone()
    // {
    //     _isDone = true;
    // }

    public void OverWriteFile(string userName, string[] goals)
    {
        File.WriteAllLines($"Players/{userName}.txt", goals);
        // using(StreamWriter outputFile = File.WriteAllLines($"Players/{userName}.txt", goals))
        // {
        //     outputFile.WriteLine($"{_goalType},{_goalName},{_description},{_goalPoints.ToString()},{_isDone.ToString()}");
        // }
    }
    public override void SaveToFile(string userName)
    {
        using(StreamWriter outputFile = File.AppendText($"Players/{userName}.txt"))
        {
            outputFile.WriteLine($"{_goalType},{_goalName},{_description},{_goalPoints.ToString()},{_isDone.ToString()}");
        }
    }

    public override string StringifyGoal(Goal goal)
    {
        return ($"{goal.DisplayGoalType()},{goal.DisplayGoalName()},{goal.DisplayGoalDescription()},{goal.GetPoints().ToString()},{goal.GetIsDone().ToString()}");
    }
}