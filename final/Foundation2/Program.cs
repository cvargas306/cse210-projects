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