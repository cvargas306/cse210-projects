using System;
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