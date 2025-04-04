public class Customer
{
    private string _name;
    private Address _address;

    public void SetCustomer(string name, string address)
    {
        _name = name;
        _address = new Address();
        _address.SetAddress(address);
    }

    public string ReturnCustomerName()
    {
        return _name;
    }
    public string ReturnCustomerAddress()
    {
        string displayAddress = _address.DisplayAddress();
        return displayAddress;
    }

    public string IfInUsa()
    {
        string country = _address.GetCountry();
        string countryLower = country.ToLower();
        if (countryLower == "usa" || countryLower == "us" || countryLower == "united states of america")
        {
            return "usa";
        }

        else
        {
            return "not usa";
        }
    }
}