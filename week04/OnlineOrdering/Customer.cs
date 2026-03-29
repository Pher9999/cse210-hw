public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public string isDomestic()
    {
        return _address.isDomestic();
    }

    public string displayCustomerInfo()
    {
        return $"Customer Name: {_name}\nAddress: {_address.getFullAddress()}\nCustomer Type: {isDomestic()}";
    }
}