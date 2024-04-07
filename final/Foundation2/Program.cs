using System;
using System.Collections.Generic;

public class Product
{
    public string Name {get; set;}
    public int ProductId {get; set;}
    public decimal Price {get; set;}
    public int Quantity {get; set;}

    public decimal TotalCost()
    {
        return Price * Quantity;
    }
}

public class Address
{
    public string Street {get; set;}
    public string City { get; set; }
    public string State { get; set; }
    public string Country { get; set; }

    public bool IsInUSA()
    {
        return Country.ToLower() == "usa";
    }

    public override string ToString()
    {
        return $"{Street}\n{City}, {State}\n{Country}";
    }
}

public class Customer
{
    public string Name {get; set;}
    
    public Address Address {get; set;}

    public bool LivesInUSA()
    {
        return Address.IsInUSA();
    }
}

public class Order
{
    public List<Product> Products { get; set; }
    public Customer Customer { get; set; }

    public decimal TotalCost()
    {
        decimal totalCost = Products.Sum(p => p.TotalCost());
        return totalCost + (Customer.LivesInUSA() ? 5 : 35);
    }

    public string PackingLabel()
    {
        return string.Join("\n", Products.Select(p => $"{p.Name} ({p.ProductId})"));
    }

    public string ShippingLabel()
    {
        return $"{Customer.Name}\n{Customer.Address}";
    }
}