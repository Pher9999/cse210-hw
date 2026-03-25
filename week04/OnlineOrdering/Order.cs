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
}