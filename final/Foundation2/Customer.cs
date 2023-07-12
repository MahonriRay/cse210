public class Customer
{
    string _name;
    Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public string CustomerShipping()
    {
        return $"{_name}\n"+
        $"{_address.ShippingAddress()}";
    }
    public bool CheckAddress()
    {
        return _address.CheckCountry();
    }
}