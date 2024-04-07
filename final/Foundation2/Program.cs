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

class Program
{
    static void Main(string[] args)
    {
        var orders = new List<Order>
        {
            new Order
            {
                Customer = new Customer
                {
                    Name = "Lisa Simpson",
                    Address = new Address
                    {
                        Street = "712 Red Bark Lane",
                        City = "Henderson",
                        State = "Nevada",
                        Country = "USA"
                    }
                },
                Products = new List<Product>
                {
                    new Product { Name = "Widget", ProductId = 1, Price = 18.99m, Quantity = 3 },
                    new Product { Name = "Gadget", ProductId = 2, Price = 28.99m, Quantity = 2 },
                    new Product { Name = "Laptop", ProductId = 3, Price = 385.80m, Quantity = 1 }
                }
            },

            new Order
            {
                Customer = new Customer
                {
                    Name = "Walter White",
                    Address = new Address
                    {
                        Street = "Negra Arroyo Lane",
                        City = "Albuquerque",
                        State = "New Mexico",
                        Country = "USA"
                    }
                },
                Products = new List<Product>
                {
                    new Product { Name = "Monitor", ProductId = 1, Price = 75.20m, Quantity = 2 },
                    new Product { Name = "CPU", ProductId = 2, Price = 98.50m, Quantity = 1 }
                }
            },

            new Order
            {
                Customer = new Customer
                {
                    Name = "Light Yagami",
                    Address = new Address
                    {
                        Street = "5-2-1, Chuo",
                        City = "Ginza Region",
                        State = "Tokyo",
                        Country = "JPN"
                    }
                },
                Products = new List<Product>
                {
                    new Product { Name = "Notebook", ProductId = 1, Price = 11.75m, Quantity = 1 },
                    new Product { Name = "Pen", ProductId = 2, Price = 3.65m, Quantity = 3 }
                }
            }
            
        };

        foreach (var order in orders)
        {
            Console.WriteLine($"Order for {order.Customer.Name}:\nTotal Cost: ${order.TotalCost()}\nPacking Label:\n{order.PackingLabel()}\nShipping Label:\n{order.ShippingLabel()}\n");
        }
    }
}