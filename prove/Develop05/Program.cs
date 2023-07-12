using System;
//Load all goals and players into program before doing anything!

Player player1 = new Player();
Simple goal1 = new Simple();//player1, "Simple", "Test Goal", "Test test test", 250);
Eternal eter1 = new Eternal();
Menu menu = new Menu();

menu.MenuDisplay();

eter1.SetEternalGoal();
player1.GoalAddToList(eter1);
goal1.SetSimpleGoal();
player1.GoalAddToList(goal1);
// goal1.Display();
player1.CheckPlayer();




// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Hello Develop05 World!");
//     }
// }