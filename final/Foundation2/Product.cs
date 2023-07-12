public class Product
{
    string _name;
    int _productID;
    float _price;
    int _quantity;

    public Product(string name, int productID, float price, int quantity)
    {
        _name = name;
        _productID = productID;
        _price = price;
        _quantity = quantity;
    }

    public Product AddQty(int qtyAmt)
    {
        Product prod1 = new Product(_name, _productID, _price, qtyAmt);
        return prod1;
    }

    public float GetPrice()
    {
        return _price * _quantity;
    }
    public void DisplayProduct()
    {
        Console.WriteLine($"Product ID: {_productID} -- X{_quantity} {_name} Price: ${_price}");
    }
    public float GetTotal()
    {
        return _price * _quantity;
    }
}