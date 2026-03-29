public class Product
{
    private string _name;
    private string _productId;
    private double _price;
    private int _quantity;

    public Product(string name, string productId, double price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public double getTotalPrice()
    {
        return _price * _quantity;
    }

    public string getProductInfo()
    {
        return $"Product Name: {_name}, Product ID: {_productId}, Price: {_price:C}, Quantity: {_quantity}: Total: {getTotalPrice():C}";
    }
}