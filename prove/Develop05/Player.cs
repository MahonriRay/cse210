public class Player
{
    int _userID;
    string _userName;
    public void SetID(int userID)
    {
        userID = _userID;
    }
    public void SetUserName(string userName)
    {
        userName = _userName;
    }
    public void CheckPlayer()
    {
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
            SetID(userID);
            SetUserName(newUserName);
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
                SetUserName(userNameCheck);
                SetID(setUserID);
                Console.WriteLine("That file exists.");
            }
        }
    }
}




// foreach (string line in fileLines)
// {
//     string[] parts = line.Split(",");
// } 