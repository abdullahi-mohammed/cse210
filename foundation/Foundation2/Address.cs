public class Address
{
    private string _Street { get; set; }
    private string _City { get; set; }
    private string _State { get; set; }
    private string _Country { get; set; }

    public Address(string _street, string _city, string state, string _country)
    {
        _Street = _street;
        _City = _city;
        _State = state;
        _Country = _country;
    }

    public bool IsInUSA()
    {
        return _Country.ToUpper() == "USA";
    }

    public string GetFullAddress()
    {
        return $"{_Street}\n{_City}, {_State}\n{_Country}";
    }
}
