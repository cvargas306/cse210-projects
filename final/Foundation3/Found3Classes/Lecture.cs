using System;
public class Lecture : Event
{
    public string SpeakerName { get; set; }
    public int Capacity { get; set; }

    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nType: Lecture\nSpeaker Name: {SpeakerName}\nCapacity: {Capacity}";
    }

    public override string GetShortDescription()
    {
        return $"Type: Lecture\nTitle: {Title}\nDate: {Date}";
    }
}