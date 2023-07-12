public class Menu : Player
{
    // Player _menuPlayer = new Player();
    List<Goal> _menuGoals = new List<Goal>();
    List<Goal> _unsavedGoals = new List<Goal>();
    List<string> _stringGoals = new List<string>();
    public void MenuDisplay()
    {
        Console.Clear();
        Player menuPlayer = new Player();
        menuPlayer = menuPlayer.CheckPlayer();
        Console.Clear();
        // Player player = _menuPlayer.CheckPlayer();
        Console.WriteLine($"Welcome to Goal Tracker {menuPlayer.DisplayUsername()} -- You currently have {menuPlayer.GetPoints().ToString()} Points\n");
        menuPlayer.LoadGoals();
        menuPlayer.TransferGoals(_menuGoals);
        // List<Goal> displayGoals = player._goals; 
        string response = "";
        string[] options = {"1", "2", "3", "4", "5", "6"};
        while (response != "6")
        {
            while(options.Contains(response)==false)
            {
                Console.WriteLine(MenuBorder());
                Console.WriteLine($"{menuPlayer.DisplayUsername()} -- {menuPlayer.DisplayUserPoints()} Points");
                Console.Write("1. Create New Goal\n"+
                "2. List Goals\n"+
                "3. Save Goals\n"+
                "4. Record Event\n"+
                "5. Show Player Rank\n"+
                "6. Quit\n");
                Console.WriteLine(MenuBorder());
                Console.Write("\nPlease select an option: ");
                response = Console.ReadLine() ?? String.Empty;
                Console.Clear();
            }
            switch (response)
            {
                case "1":
                    Simple goal = new Simple();
                    int GoalNumbahType = goal.SetGoalType();
                    if (GoalNumbahType == 1)
                    {
                        goal.SetSimpleGoal();
                        _unsavedGoals.Add(goal);
                    }
                    else if(GoalNumbahType == 2)
                    {
                        Eternal eGoal = new Eternal();
                        eGoal.SetEternalGoal();
                        _unsavedGoals.Add(eGoal);
                    }
                    else
                    {
                        Checklist cGoal = new Checklist();
                        cGoal.SetChecklistGoal();
                        _unsavedGoals.Add(cGoal);
                    }
                    break;
                case "2":
                    Console.WriteLine($"Goals for {menuPlayer.DisplayUsername()}:\n");
                    foreach (Goal goalList in _menuGoals)
                    {
                        goalList.DisplayGoals();
                        Console.WriteLine();
                    }
                    foreach (Goal goalList in _unsavedGoals)
                    {
                        goalList.DisplayGoals();
                        Console.WriteLine();                        
                    }
                    Console.WriteLine();
                    break;
                case "3":
                    foreach (Goal goalList in _unsavedGoals)
                    {
                        goalList.SaveToFile(menuPlayer.DisplayUsername());
                        _menuGoals.Add(goalList);
                    }
                    _unsavedGoals.Clear();
                    break;
                case "4":
                    int i = 1;
                    foreach (Goal goalList in _menuGoals)
                    {
                        Console.Write($"{i.ToString()}.)");
                        goalList.DisplayGoals();
                        Console.WriteLine();
                        i++;
                    }
                    foreach (Goal goalList in _unsavedGoals)
                    {
                        Console.Write($"{i}.)");
                        goalList.DisplayGoals();
                        Console.WriteLine();  
                        i++;                      
                    }
                    Console.Write("Which goal did you accomplish?");
                    string recordResponse = Console.ReadLine();
                    int selection = int.Parse(recordResponse);
                    if (selection <= _menuGoals.Count())
                    {
                        menuPlayer.AddPoints(_menuGoals[selection - 1]);
                        if(_menuGoals[selection - 1].DisplayGoalType() == "Simple")
                        {
                            _menuGoals[selection - 1].SetDone();
                        }
                        else if(_menuGoals[selection - 1].DisplayGoalType() == "Checklist")
                        {
                            _menuGoals[selection - 1].addTimeDone();
                            if (_menuGoals[selection - 1].GetTimesDone() == _menuGoals[selection - 1].GetBonusRequirement())
                            {
                                menuPlayer.AddBonusPoints(_menuGoals[selection - 1]);
                            }
                        }
                    }
                    else
                    {
                        int unsavedSelection = selection - _menuGoals.Count();
                        menuPlayer.AddPoints(_unsavedGoals[unsavedSelection - 1]);                        
                    }
                    Console.Clear();
                    Console.WriteLine($"You're goal has been recorded and {_menuGoals[selection - 1].GetPoints()} points have been added.\n");
                    break;
                case "5":
                    Console.WriteLine($"{menuPlayer.DisplayUsername()}: Rank -- {menuPlayer.DisplayRank()}\n");
                    break;
                case "6":
                    _stringGoals.Add($"UserID,{menuPlayer.DisplayUserID().ToString()},Username,{menuPlayer.DisplayUsername()},Points,{menuPlayer.DisplayUserPoints().ToString()},Rank,{menuPlayer.DisplayRank()}");
                    Simple simp = new Simple();
                    Eternal eter = new Eternal();
                    Checklist check = new Checklist();
                    foreach (Goal exitGoal in _menuGoals)
                    {   
                        if(exitGoal.DisplayGoalType() == "Simple")
                        {
                            _stringGoals.Add(simp.StringifyGoal(exitGoal));
                        }
                        else if(exitGoal.DisplayGoalType() == "Eternal")
                        {
                            _stringGoals.Add(eter.StringifyGoal(exitGoal));
                        }
                        else 
                        {
                            _stringGoals.Add(check.StringifyGoal(exitGoal));
                        }
                    }
                    // using (StreamWriter outputFile = File.AppendText($"Players/{menuPlayer.DisplayUsername()}.txt"))
                    // {
                    //     outputFile.WriteLine($"UserID,{menuPlayer.DisplayUserID().ToString()},Username,{menuPlayer.DisplayUsername()}");
                    // }                    
                    File.WriteAllLines($"Players/{menuPlayer.DisplayUsername()}.txt", _stringGoals);
                    Environment.Exit(0);
                    break;
            }
            response = "";
        }
    }
    public string MenuBorder()
    {
        return "=================================";
    }
}
//   -------------------------------
//  |        CODE GRAVEYARD         |
//   -------------------------------
//                -|-
//                 |
//             .-'~~~`-.
//           .'         `.
//           |  R  I  P  |
//           |           |
//           |           |
//         \\|           |//
// ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
                        // if(goalList.DisplayGoalType() == "Checklist")
                        // {
                        //     goalList.DisplayGoals();
                        //     Console.
                        // }