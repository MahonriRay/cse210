using System;

class Program
{
    static void Main(string[] args)
    {   
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 51);
        
        int guess = -1;
        string answer = "yes";
     
        
        
        {
            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());

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
                    Console.WriteLine("You guessed it!"); 
                }

            }    
            Console.Write("Play again? ");
            string response = Console.ReadLine();
            if (response == "yes")
            {
               answer = "yes";
            }   
            else
            {
                answer = "no";
            }
        }                
    }
}