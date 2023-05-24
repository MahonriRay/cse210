public class Team
{
    private List<Player> _roster = new List<Player>();
    private List<string> _sponsor = new List<string>();
    private string _name;
    private int _wins;
    private int _losses;

    public Team(string name)
    {
        _name = name;
    }

    public void AddPlayer(Player p)
    {
        _roster.Add(p);
    }

    public void AddWin()
    {
        _wins += 1;
    }
    public void AddLoss()
    {
        _losses += 1;
    }
    public void Display()
    {
        Console.WriteLine($"{_name} {_wins}/{_losses}");
        foreach (Player p in _roster)
        {
            p.Display();
        }
    }

    public string GetTeamName()
    {
        return _name;
    }
}
