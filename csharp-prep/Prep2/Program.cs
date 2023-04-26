using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage?: ");
        string answer = Console.ReadLine();
        int gradePercentage = int.Parse(answer); 

        string gradeSign = "";

        if (gradePercentage >=60 && gradePercentage < 93)
        {

            int remainder = gradePercentage % 10;
            if (remainder >= 7)
            {
                gradeSign = "+";
            }

            else if (remainder < 3)
            {
                gradeSign = "-";
            }

            else
            {
                gradeSign = "";
            }
        }

        string letter = "";

        if (gradePercentage >90)
        {
            letter = "A";
        }

        else if (gradePercentage >= 80)
        {
            letter = "B";
        }

        else if (gradePercentage >= 70)
        {
            letter = "C";
        }

        else if (gradePercentage >= 60)
        {
            letter = "D";
        }

        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your letter grade is {letter}{gradeSign}");

        if (gradePercentage >=70)
        {
            Console.WriteLine("CONGRATULATIONS, YOU PASSED!");
        }

        else
        {
            Console.WriteLine("Better luck next time...");
        }
    }
}