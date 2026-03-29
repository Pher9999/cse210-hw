public class Order
{
    private Customer _customer;
    private List<Product> _products;

    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
    }

    public double getTotalPrice()
    {
        double totalPrice = 0;
        foreach (Product product in _products)
        {
            totalPrice += product.getTotalPrice();
        }
        return totalPrice;
    }

    public string displayOrderDetails()
    {
        string orderDetails = _customer.displayCustomerInfo() + "\nProducts:\n";
        foreach (Product product in _products)
        {
            orderDetails += $"- {product.getProductInfo()}\n";
        }
        orderDetails += $"Shipping Cost: {shippingCost():C}\n";
        double _ordertotalPrice = getTotalPrice() + shippingCost();
        orderDetails += $"Total Price: {_ordertotalPrice:C}";
        return orderDetails;
    }

    public double shippingCost()
    {
        return _customer.isDomestic() == "Domestic" ? 5.00 : 35.00;
    }

    public string getPackingLabel()
    {
        string packingLabel = "Packing Label:\n";
        foreach (Product product in _products)
        {
            packingLabel += $"- {product.getProductInfo()}\n";
        }
        return packingLabel;
    }

    public string getShippingLabel()
    {
        return $"Shipping Label:\n{_customer.displayCustomerInfo()}";
    }
}