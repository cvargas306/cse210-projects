using System;
public class Reception : Event
{
    public string EmailForRSVP { get; set; }

    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nType: Reception\nEmail for RSVP: {EmailForRSVP}";
    }

    public override string GetShortDescription()
    {
        return $"Type: Reception\nTitle: {Title}\nDate: {Date}";
    }
}