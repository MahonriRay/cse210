using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int addNumber = -1;
        Console.WriteLine("Enter a list of number, type 0 when finished.");
        
        do
        {
            string inputNumber = Console.ReadLine();
            addNumber = int.Parse(inputNumber);

            if (addNumber != 0)
            {
                numbers.Add(addNumber);
            }
        }while(addNumber != 0);

        int sum = 0;
        foreach(int number in numbers)
        {
            sum+=number;
        }
        Console.WriteLine($"The sum is {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is {average}");

        int maxNum = numbers[0];
        foreach (int number in numbers)
        {
            if (number > maxNum)
            {
                maxNum = number;
            }
        }
        numbers.Sort();
        int smallNum = 0;
        foreach (int i in numbers)
        {
            if (i > 0)
            {
                smallNum = i;
                break;
            }
        }
        Console.WriteLine($"The smallest positive number is {smallNum}");

        Console.WriteLine($"The max number is {maxNum}");

        numbers.Sort();
        Console.WriteLine("The sorted list is");
        foreach (int i in numbers)
        {
            Console.WriteLine(i);
        }
    }
}