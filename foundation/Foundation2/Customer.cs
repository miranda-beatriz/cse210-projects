using System;
using System.Net.Sockets;

public class Customer
{
    private string _name;

    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public string GetShippingLabel()
    {
        return _address.GetFullAdress();
    }

    public bool IsInUSA()
    {
        return _address.IsInUSA();
    }

    public string GetName()
    {
        return _name;
    }

}