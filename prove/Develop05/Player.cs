public class Player //: Simple
{
    List<Goal> _goals = new List<Goal>();
    int _userID;
    string _userName;
    int _points;
    string _rank;
    public void SetID(int userID)
    {
        _userID = userID;
    }
    public void SetPoints(int points)
    {
        _points = points;
    }
    public void SetUserName(string userName)
    {
        _userName = userName;
    }
    public int GetPoints()
    {
        return _points;
    }
    public string DisplayRank()
    {
        return _rank;
    }
    public void SetRank(string rank)
    {
        _rank = rank;
    }
    public void CheckRank()
    {
        if (_points >= 0 && _points <= 100)
        {
            _rank = "n00b";
        }
        else if(_points > 100 && _points <= 300)
        {
            _rank = "Sorta Commited";
        }
        else if(_points >300 && _points <= 1000)
        {
            _rank = "Goal Slayer";
        }
        else{
            _rank = "Master of Goals";
        }
    }
    public Player CheckPlayer()
    {
        Player player = new Player();
        int userID = Directory.GetFiles("Players").Length + 1;

        Console.WriteLine("[N]ew player\n[R]eturning player");
        ConsoleKeyInfo keyInfo = Console.ReadKey();
        if(keyInfo.Key == ConsoleKey.N)
        {
            Console.Write("\bEnter a username: ");
            string newUserName = Console.ReadLine();
            var myFile = File.Create($"Players/{newUserName}.txt");
            myFile.Close();
            using (StreamWriter outputFile = File.AppendText($"Players/{newUserName}.txt"))
            {
                outputFile.WriteLine($"UserID,{userID},Username,{newUserName}");
            }
            player.SetID(userID);
            player.SetUserName(newUserName);
            player.SetPoints(0);
        }
        else
        {
            Console.Write("\bEnter the username: ");
            string userNameCheck = Console.ReadLine();
            string fileName = ($"Players/{userNameCheck}.txt");
            if(File.Exists(fileName))
            {
                string[] fileLines = System.IO.File.ReadAllLines(fileName);
                string[] userNameID = fileLines[0].Split(",");
                int setUserID = int.Parse(userNameID[1]);
                player.SetUserName(userNameCheck);
                player.SetID(setUserID);
                player.SetPoints(int.Parse(userNameID[5]));
                player.SetRank(userNameID[7]);
                // Console.WriteLine("That file exists.");
            }
        }
        return player;
    }
    public void GoalAddToList(Goal goal)
    {
        _goals.Add(goal);
    }
    public string DisplayUsername()
    {
        return _userName;
    }
    public int DisplayUserID()
    {
        return _userID;
    }
    public int DisplayUserPoints()
    {
        return _points;
    }
    public void TransferGoals(List<Goal> destination)
    {
        foreach (Goal goal in _goals)
        {
            destination.Add(goal);
        }
    }
    public void AddPoints(Goal goal)
    {
        _points += goal.GetPoints();
    }
    public void AddBonusPoints(Goal goal)
    {
        _points += goal.GetBonus();
    }
    public void LoadGoals()
    {
        string fileLocation = ($"Players/{_userName}.txt");
        string[] fileLines = System.IO.File.ReadAllLines(fileLocation);
        fileLines = fileLines.Skip(1).ToArray();
        foreach (var line in fileLines)
        {
            string[] lineItems = line.Split(",");
            if(lineItems[0] == "Simple")
            {
                int goalPoints = int.Parse(lineItems[3]);
                bool isDone = bool.Parse(lineItems[4]);
                _goals.Add(new Simple(lineItems[0], lineItems[1], lineItems[2], goalPoints, isDone));
            }
            else if(lineItems[0] == "Eternal")
            {
                int goalPoints = int.Parse(lineItems[3]);
                _goals.Add(new Eternal(lineItems[0], lineItems[1], lineItems[2], goalPoints));
            }
            else
            {
                int goalPoints = int.Parse(lineItems[3]);
                int timesDone = int.Parse(lineItems[4]);
                int bonusRequirement = int.Parse(lineItems[5]);
                int bonusPoints = int.Parse(lineItems[6]);
                _goals.Add(new Checklist(lineItems[0], lineItems[1], lineItems[2],goalPoints,timesDone,bonusRequirement,bonusPoints));
            }
        }
    }
}




// foreach (string line in fileLines)
// {
//     string[] parts = line.Split(",");
// } 