using System.Collections.Generic;

public class Order
{
    private List<Product> _Products { get; set; }
    private Customer _Customer { get; set; }

    public Order(Customer customer)
    {
        _Customer = customer;
        _Products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _Products.Add(product);
    }

    public decimal CalculateTotalCost()
    {
        decimal totalCost = 0;

        foreach (Product product in _Products)
        {
            totalCost += product.GetTotalCost();
        }

        // Add shipping cost
        totalCost += _Customer.IsInUSA() ? 5 : 35;
        return totalCost;
    }

    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (Product product in _Products)
        {
            label += $"- {product.GetProductInfo()}\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{_Customer.GetCustomerInfo()}";
    }
}
