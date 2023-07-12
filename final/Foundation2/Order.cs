public class Order
{
    Customer _customer;
    List<Product> _products = new List<Product>();
    int _shippingCost;

    public Order(Customer customer,  List<Product> products)
    {
        _customer = customer;
        _products = products;
    }
    public void PrintShippingDetails()
    {
        Console.WriteLine($"--Shipping Details--");
        Console.WriteLine(_customer.CustomerShipping());
    }
    public void PrintOrderDetails()
    {
        Console.WriteLine("--Invoice--");
        foreach (Product product in _products)
        {
            product.DisplayProduct();
        }
    }
    public void CalculateTotal()
    {
        float total = 0;
        foreach (Product product in _products)
        {
            float itemTotal = product.GetTotal();
            total += itemTotal;
        }
        if(_customer.CheckAddress() == true)
        {
            _shippingCost = 5;
        }
        else
        {
            _shippingCost = 35;
        }
        Console.WriteLine($"\nShipping Cost: {_shippingCost}.00 Total: ${total + _shippingCost}");
    }
    public void PrintAllDeets()
    {
        Console.WriteLine(Border());
        PrintShippingDetails();
        Console.WriteLine();
        PrintOrderDetails();
        CalculateTotal();
        Console.WriteLine(Border());
    }
    public string Border()
    {
        return $"========================================================";
    }
}