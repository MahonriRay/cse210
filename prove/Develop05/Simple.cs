public class Simple : Goal
{
    Player _player;
    string  _goalName;
    string _description;
    int _goalPoints;

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