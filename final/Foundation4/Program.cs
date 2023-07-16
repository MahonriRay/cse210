using System;

Console.Clear();

Activity act1 = new Activity();

act1.AddGoal(new Cycling("06/12/2023", 30, 6));
act1.AddGoal(new Running("09/09/0909", 45, 3));
act1.AddGoal(new Swimming("06/12/2023", 30, 33));

act1.DisplayGoals();
