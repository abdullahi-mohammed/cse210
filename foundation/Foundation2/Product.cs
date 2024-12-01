public class Product
{
    private string _Name { get; set; }
    private string _ProductId { get; set; }
    private decimal _Price { get; set; }
    private int _Quantity { get; set; }

    public Product(string name, string productId, decimal price, int quantity)
    {
        _Name = name;
        _ProductId = productId;
        _Price = price;
        _Quantity = quantity;
    }

    public decimal GetTotalCost()
    {
        return _Price * _Quantity;
    }

    public string GetProductInfo()
    {
        return $"{_Name} (ID: {_ProductId})";
    }
}
