using System;
using System.Collections.Generic;
using System.Text;

public class Order
{
    private List<Product> products;
    private Customer customer;
    private const decimal DomesticShippingCost = 5.00m;
    private const decimal InternationalShippingCost = 35.00m;

    public Order(Customer customer)
    {
        this.customer = customer;
        this.products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public decimal TotalCost()
    {
        decimal productsTotal = 0;

        foreach (Product product in products)
        {
            productsTotal += product.TotalCost();
        }

        decimal shippingCost = customer.LivesInUSA() ? DomesticShippingCost : InternationalShippingCost;
        return productsTotal + shippingCost;
    }

    public string PackingLabel()
    {
        StringBuilder label = new StringBuilder();
        label.AppendLine("Packing Label:");
        foreach (Product product in products)
        {
            label.AppendLine($"Product Name: {product.Name}, Product ID: {product.ProductId}");
        }
        return label.ToString();
    }

    public string ShippingLabel()
    {
        StringBuilder label = new StringBuilder();
        label.AppendLine("Shipping Label:");
        label.AppendLine($"Customer Name: {customer.Name}");
        label.AppendLine(customer.Address.GetFullAddress());
        return label.ToString();
    }
}
