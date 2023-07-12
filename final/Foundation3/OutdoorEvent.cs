public class OutdoorEvent : Event
{
    string _weather;
    public OutdoorEvent(string titleOfEvent, string descriptionOfEvent, string dateOfEvent, int timeOfEvent, Address address) : base(titleOfEvent, descriptionOfEvent, dateOfEvent, timeOfEvent, address)
    {
    }

    public string GetWeather()
    {
        string[] weatherOptions = {"Sunny", "Cloudy", "Rain", "Hail", "Category 5 Hurricane", "Kia Summer Sale Event", "The downfall of my enemies", "Snow"};
        Random rand = new Random();

        int randomNum = rand.Next(weatherOptions.Count() - 1);
        string weather = weatherOptions[randomNum];
        _weather = weather;
        return weather;
    }
        public void FullDetails()
    {
        Console.WriteLine(Border());
        DisplayEventDetails();
        Console.WriteLine($"\nThe Weatherman is predicting: {_weather} -- "
        +"Plan accordingly. Please & Thank You.");
        Console.WriteLine(Border());
    }

}