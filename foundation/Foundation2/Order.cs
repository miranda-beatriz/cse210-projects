using System;
using System.Net.Http.Headers;
using System.Runtime.InteropServices.Marshalling;

public class Order
{
    private List<Product> _products;

    private Customer _customer;

    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }

    public decimal CalculateTotalCost()
    {
        decimal totalCost = 0;

        foreach (Product product in _products)
        {
            totalCost += product.GetTotalCost();

        }

        decimal ShippingCost;

        if (_customer.IsInUSA())
        {
            ShippingCost = 5.00m;

        }
        else
        {
            ShippingCost = 35.00m;
        }

        totalCost += ShippingCost;

        return totalCost;
    }

    public string GetPackingLabel()
    {
        string label = "Packing Label: \n";

        foreach (Product product in _products)
        {
            label += $"{product.GetName()} (ID: {product.GetProductId()})  \n";

        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $"Shipping To: \n {_customer.GetName()}\n {_customer.GetShippingLabel()}";
    }
}