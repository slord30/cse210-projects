using System;
using System.Net.Http.Headers;

public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool ifUSA()
    {
        return _address.isUSA() ? true: false;         
    }

    public string GetName()
    {
        return _name;
    }

    public string CombineAddress()
    {
        string generatedAddress = _address.CombineAddress();
        return generatedAddress;
    }
}