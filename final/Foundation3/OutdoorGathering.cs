using System;
public class OutdoorGathering : Event
{
    public string WeatherForecast { get; set; }

    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nType: Outdoor Gathering\nWeather Forecast: {WeatherForecast}";
    }

    public override string GetShortDescription()
    {
        return $"Type: Outdoor Gathering\nTitle: {Title}\nDate: {Date}";
    }
}