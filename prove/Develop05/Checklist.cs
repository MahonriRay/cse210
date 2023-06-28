public class Checklist : Simple
{
    Player _player;
    string  _goalName;
    string _description;
    int _goalPoints;
    int _bonusPoints;
    int _bonusRequirement; //How many times the goal needs to be done to get bonus

    public Checklist(Player player, string goalType, string goalName, string description, int goalPoints) : base(player, goalType, goalName, description, goalPoints)
    {
    }

    public void SetBonusPoints ()
    {
        Console.Write("What is the bonus for accomplishing it that many times?: ");
        string points = Console.ReadLine();
        int bonusPoints = int.Parse(points);
        bonusPoints = _bonusPoints;
    }
    public void SetBonusRequirement ()
    {
        Console.Write("How many times does this goal need to be accomplished for a bonus?: ");
        string requirement = Console.ReadLine();
        int bonusRequirement = int.Parse(requirement);
        bonusRequirement = _bonusRequirement;
    }
}