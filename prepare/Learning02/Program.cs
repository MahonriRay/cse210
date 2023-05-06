using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Apple";
        job1._jobTitle = "Software Engineer";
        job1.startYear = 2018;
        job1.endYear = 2023;

        Job job2 = new Job();
        job2._company = "LinkedIn";
        job2._jobTitle = "Data Scientist";
        job2.startYear = 2020;
        job2.endYear = 2023;

        Resume myResume = new Resume();
        myResume._name = "John Doe";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.DisplayInfo();


        Console.WriteLine("Hello Learning02 World!");
    }
}