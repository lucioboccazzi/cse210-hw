public class Customer
{
    private string _name;

    private Address address;

    public Customer(string name, Address address)
    {
        this._name = name;
        this.address = address;
    }
    public string Name
    {
        get { return _name; }
        private set { _name = value; }
    }
    public Address Address
    {
        get { return address; }
        private set { address = value; }
    }
    public bool LivesInUSA()
    {
        return address.IsInUSA();
    }

    public string GetCustomerDetails()
    {
        return $"{Name}\n{Address.GetFullAddress()}";
    }
}