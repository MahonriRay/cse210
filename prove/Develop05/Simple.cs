public class Simple : Goal
{
    // string _goalType;
    public Simple(Player player, string goalType, string goalName, string description, int goalPoints)
    {
        _player = player;
        _goalType = goalType;
        _goalName = goalName;
        _description = description;
        _goalPoints = goalPoints;
    }

    public void Display()
    {
        Console.WriteLine($"{_goalType}");
    }

    public override void SetGoalType()
    {
        Console.WriteLine("What type of goal is this?\n"+
        "1.) Simple Goal\n"+
        "2.) Eternal Goal\n"+
        "3.) Checklist Goal");
        int goalSelection = int.Parse(Console.ReadLine());

        if(goalSelection == 1)
        {
            string goalType = "Simple";
            _goalType = goalType;
        }
        else if(goalSelection == 2)
        {
            string goalType = "Eternal";
            _goalType = goalType;
        }
        else
        {
            string goalType = "Eternal";
            _goalType = goalType;
        }
    }
    public override void SetGoalName()
    {
        Console.Write("What is the name of you goal?: ");
        string goalName = Console.ReadLine();
        goalName = _goalName;
    }

    public override void SetDescription()
    {
        Console.Write("Write a short description of your goal: ");
        string description = Console.ReadLine();
        description = _description;
    }

    public override void SetPoints()
    {
        Console.Write("How many points would you like this goal be worth(0 - 250): ");
        string points = Console.ReadLine();
        int goalPoints = int.Parse(points);
        goalPoints = _goalPoints;
    }

}