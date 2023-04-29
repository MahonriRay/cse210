using System;

class Program
{
    static void Main(string[] args)
    {   
        
        int guess = -1;
        string answer = "yes";
        int guessAttempt = 0;
     
        
        while (answer == "yes")
        {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 51);
            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                guessAttempt += 1;

                if (magicNumber > guess)
                {
                    Console.WriteLine("Higher");
                }
                else if (magicNumber < guess)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine($"You guessed it!\nIt took you {guessAttempt} attempts"); 
                }

            }    
            Console.Write("Play again? ");
            string response = Console.ReadLine();
            if (response == "yes")
            {
               answer = "yes";
               guessAttempt = 0;
               guess = -1;
            }   
            else
            {
                answer = "no";
            }
        }                
    }
}