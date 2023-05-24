// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Player michael = new Player("Michael the Goat", "Jordan", 23);
Player axa = new Player("Axa", "Uribe", 10);
Team fireballs = new Team("Fireballs");

Player danny = new Player("Danny", "DeVito", 3);
Player marvin = new Player("Marvin", "The Martian", 99);
Team monstars = new Team("MonStars");
monstars.AddPlayer(danny);
monstars.AddPlayer(marvin);


fireballs.AddPlayer(michael);
fireballs.AddPlayer(axa);

fireballs.AddWin();
fireballs.AddLoss();
fireballs.AddWin();

fireballs.Display();

michael.UpdateJersey(45);
michael.UpdateJersey(23);
// michael.Display();
Match greatstBrawl = new Match(monstars, fireballs);

greatstBrawl.DecideWin();
// Match(monstars, fireballs);




fireballs.Display();
// michael._firstName = Michael;
// michael.__lastName = Jordan;
// michael.jerseyNumber = 23;