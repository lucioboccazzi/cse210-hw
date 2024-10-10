using System;
public class Product
{

    private string name;
    private int productId;
    private decimal price;
    private int quantity;

    public Product(string name, int productId, decimal price, int quantity)
    {
        this.name = name;
        this.productId = productId;
        this.price = price;
        this.quantity = quantity;
    }

    public string Name
    {
        get { return name; }
        private set { name = value; }
    }

    public int ProductId
    {
        get { return productId; }
        private set { productId = value; }
    }

    public decimal Price
    {
        get { return price; }
        private set { price = value; }
    }

    public int Quantity
    {
        get { return quantity; }
        private set { quantity = value; }
    }

    public decimal TotalCost()
    {
        return price * quantity;
    }

    public string GetProductDetails()
    {
        return $"Product Name: {Name}\nProduct ID: {ProductId}\nPrice per Unit: ${Price}\nQuantity: {Quantity}\nTotal Cost: ${TotalCost()}";
    }
}
