using System;

class Program
{
    static void Main(string[] args)
    {
        //Order 1
        Address address1 = new Address("233 Mountain Road", "The Woodlands", "TX", "USA");
        Customer customer1 = new Customer("Sarah Lord", address1);
        List<Product> productList1 = new List<Product>();

        Product p101 = new Product("Birds of the Rocky Mountain Playing Cards", "BPC54", 5.95, 1);
        Product p102 = new Product("Gothic Mystery Witch Earrings", "GWE02", 9.95, 2);
        Product p103 = new Product("Outdoor Planter Large Pot", "OP250", 75.06, 1);

        productList1.Add(p102);
        productList1.Add(p102);
        productList1.Add(p103);

        Order order1 = new Order(productList1, customer1);

        Console.WriteLine("Order Number: 01");
        order1.DisplayResults();
        Console.WriteLine();

        //Order 2
        Address address2 = new Address("15585 W 2500 S", "Rexburg", "ID", "USA");
        Customer customer2 = new Customer("Connor Lord", address2);
        List<Product> productList2 = new List<Product>();

        Product p201 = new Product("Halloween Lights", "HL0408", 19.95, 3);
        Product p202 = new Product("HP Prime Graphing Calculator", "HPGC24", 161.48, 1);
        Product p203 = new Product("Hanes White T-Shirt", "HTS05", 7.99, 5);

        productList2.Add(p201);
        productList2.Add(p202);
        productList2.Add(p203);

        Order order2 = new Order(productList2, customer2);

        Console.WriteLine("Order Number: 02");
        order2.DisplayResults();
        Console.WriteLine();

        //Order 3
        Address address3 = new Address("5 Senores", "Oaxaca De Juarez", "Oaxaca", "Mexico");
        Customer customer3 = new Customer("Jackson Lord", address3);
        List<Product> productList3 = new List<Product>();

        Product p301 = new Product("Portable Bluetooth Speaker", "BS715", 21.95, 1);
        Product p302 = new Product("Resistance Workout Bands", "RWB2004", 3.49, 6);
        Product p303 = new Product("Pocket Trumpet", "PT330N", 159.99, 1);

        productList3.Add(p301);
        productList3.Add(p302);
        productList3.Add(p303);

        Order order3 = new Order(productList3, customer3);

        Console.WriteLine("Order Number: 03");
        order3.DisplayResults();
        Console.WriteLine();
    }
}