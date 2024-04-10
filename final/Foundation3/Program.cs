using System;
using System.Collections.Generic;

public class Address
{
    public string Street {get; set;}
    public string City {get; set;}
    public string State {get; set;}
    public string Country {get; set;}
}

public abstract class Event
{
    public string Title {get; set;}
    public string Description {get; set;}
    public DateTime Date {get; set;}
    public TimeSpan Time {get; set;}
    public Address Address {get; set;}

    public abstract string GetFullDetails();
    public abstract string GetShortDescription();

    public string GetStandardDetails()
    {
        return $"Title: {Title}\nDescription: {Description}\nDate: {Date}\nTime: {Time}\nAddress: {Address.Street}, {Address.City}, {Address.State}, {Address.Country}";
    }
}

