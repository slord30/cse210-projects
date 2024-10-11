using System;
using System.Numerics;

public class Product
{
    private string _name;
    private string _productid;
    private double _price;
    private int _quantity;

    public Product(string name, string productid, double price, int quantity)
    {
        _name = name;
        _productid = productid;
        _price = price;
        _quantity = quantity;
    }

    public double GetTotalPrice()
    {
        double totalPrice = _price * _quantity;
        double roundedPrice = Math.Round(totalPrice, 2);
        return roundedPrice;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetProductID()
    {
        return _productid;
    }

    public double GetPrice()
    {
        return _price;
    }

    public int GetQuantity()
    {
        return _quantity;
    }
}