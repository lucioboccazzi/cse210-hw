public class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateOrProvince;
    private string _country;


    public Address(string streetAddress, string city, string stateOrProvince, string country)
    {
        this._streetAddress = streetAddress;
        this._city = city;
        this._stateOrProvince = stateOrProvince;
        this._country = country;
    } 
    
    public string StreetAddress
    {
        get { return _streetAddress; }
        private set { _streetAddress = value; }  
    }
    public string City
    {
        get { return _city; }
        private set { _city = value; }  
    }
    public string StateOrProvince
    {
        get { return _stateOrProvince; }
        private set { _stateOrProvince = value; } 
    }

    public string Country
    {
        get { return _country; }
        private set { _country = value; }  
    }

    public bool IsInUSA()
    {
        return Country.Equals("USA", StringComparison.OrdinalIgnoreCase);
    }

    public string GetFullAddress()
    {
        return $"{StreetAddress}\n{City}, {StateOrProvince}\n{Country}";
    }
}