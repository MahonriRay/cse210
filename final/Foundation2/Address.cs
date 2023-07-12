public class Address
{
    string _streetAddress;
    string _city;
    string _stateProvince;
    string _country;
    bool _inAmerica;

    public Address(string streetAddress, string city, string stateProvince, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
    }


    public bool CheckCountry()
    {
        if(_country == "America" || _country == "United States")
        {
            _inAmerica = true;
        }
        else
        {
            _inAmerica = false;
        }
        return _inAmerica;
    }
    public string ShippingAddress()
    {
        return $"{_streetAddress} {_city}, \n"+
        $"{_stateProvince} {_country}";
    }
}