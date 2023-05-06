public class Job
{
    // Variables
    public string _jobTitle;
    public string _company;
    public int startYear;
    public int endYear;
    // Constructor
    public Job()
    {

    }

    // Methods (functions)
    public void DisplayInfo()
    {
        Console.WriteLine($"Company: {_company}\nJob Title: {_jobTitle}\nDate of Employment: {startYear} - {endYear}\n");
    }
}