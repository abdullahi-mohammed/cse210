public class Customer
{
    private string _Name { get; set; }
    private Address _Address { get; set; }

    public Customer(string name, Address address)
    {
        _Name = name;
        _Address = address;
    }

    public bool IsInUSA()
    {
        return _Address.IsInUSA();
    }

    public string GetCustomerInfo()
    {
        return $"{_Name}\n{_Address.GetFullAddress()}";
    }
}
