using System;

class Program
{
    static void Main(string[] args)
    {
        string name = GetName();
        int num = GetNum();
        int squareNumbah = SquareDisNumbah(num);
        DisplayOutPut(squareNumbah, name);
        HelloWorld();
    }
    static void HelloWorld()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string GetName()
    {
        Console.Write("\nPlease enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }
    static int GetNum()
    {
        Console.Write("Please enter a number por favor: ");
        int userNum = int.Parse(Console.ReadLine());
        return userNum;
    }

    static int SquareDisNumbah(int number)
    {
        int squaredNum = number * number;
        return squaredNum;
    }

    static void DisplayOutPut(int num, string name)
    {
        Console.WriteLine($"{name}, the square of your number is {num} \n");
    }
}