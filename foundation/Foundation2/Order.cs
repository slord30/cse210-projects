using System;
using System.Reflection;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(List<Product> product, Customer customer)
    {
        _products = product;
        _customer = customer;
    }

    public double CalcShipping()
    {
        double shippingCost = _customer.ifUSA() ? 5 : 35;
        return shippingCost;
    }

    public double TotalOrderCost()
    {
        double totalPrice = 0;

        foreach (Product p in _products)
        {
            double price = p.GetTotalPrice();
            totalPrice += price;
        }

        double shippingCost = CalcShipping();
        totalPrice += shippingCost;
        return totalPrice;
    }

    public string MakePackingLabel()
    {
        string packingLabel = "Packing Label: \n";
        foreach (Product p in _products)
        {
             packingLabel += $"{p.GetName()} - {p.GetProductID()} \n";
        }
        return packingLabel;
    }

    public string MakeShippingLabel()
    {
        string shippingLabel = "Shipping Label: \n";
        shippingLabel += _customer.GetName() + "\n" + _customer.CombineAddress();
        return shippingLabel;
    }

    public string GenerateTotalOrderCost()
    {
        string totalCost = "\nProducts:\n";
        double totalPrice = TotalOrderCost();
        foreach (Product p in _products)
        {
            totalCost += $"{p.GetName()} {p.GetProductID} - ${p.GetPrice} x {p.GetQuantity} = {p.GetTotalPrice} \n";
        }

        totalCost += $"Shipping Cost: ${CalcShipping()} \n";
        totalCost += $"Total: ${TotalOrderCost()} \n";

        return totalCost;
    }

    public void DisplayResults()
    {
        string packingLabel = MakePackingLabel();
        string shippingLabel = MakeShippingLabel();
        string totalCost = GenerateTotalOrderCost();

        Console.WriteLine(packingLabel);
        Console.WriteLine(shippingLabel);
        Console.WriteLine(totalCost);
    }
}