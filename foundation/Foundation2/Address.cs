using System;

public class Address
{
    private string _street;
    private string _city;
    private string _stateOrProvince;
    private string _country;

    public Address(string street, string city, string stateOrProvince, string country)
    {
        _street = street;
        _city = city;
        _stateOrProvince = stateOrProvince;
        _country = country;
    }

    public string GetFullAdress()
    {
        return $"{_street}, {_city}, {_stateOrProvince}, {_country}";
    }

    public bool IsInUSA()
    {
        return _country.ToLower() == "usa";
    }

}