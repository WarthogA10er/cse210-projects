using System.Runtime.InteropServices.Marshalling;

public class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateProvince;
    private string _country;

    public void SetAddress(string address)
    {
        List<string> addressParts = new List<string>(address.Split(','));
        string streetAddress  = addressParts[0];
        string city = addressParts[1];
        string stateProvince = addressParts[2];
        string country = addressParts[3];
        
        _streetAddress = streetAddress;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
    }

    public string GetCountry()
    {
        return _country;
    }

    public string DisplayAddress()
    {
        string displayAddress = ($"{_streetAddress}, {_city} {_stateProvince}, {_country}");
        return displayAddress;
    }
}