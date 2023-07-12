public class Address
{
    string _street;
    string _city;
    string _stateProvince;
    string _country;

    public Address(string street, string city, string stateProvince, string country)
    {
        _street = street;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
    }

    public string DisplayAddress()
    {
         return $"{_street}, {_city} {_stateProvince}, {_country}";
    }
}