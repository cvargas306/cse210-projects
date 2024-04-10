using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var events = new List<Event>
        {
            new Lecture
            {
                Title = "Lecture A",
                Description = "Have a speaker and have a limited capacity",
                Date = DateTime.Today,
                Time = TimeSpan.FromHours(10),
                Address = new Address
                {
                    Street = "575 Beech St",
                    City = "Palmer",
                    State = "California",
                    Country = "USA"
                },
                SpeakerName = "Franz Hydn",
                Capacity = 75
            },

              new Reception
            {
                Title = "Reception B",
                Description = "Require people to RSVP, or register, beforehand.",
                Date = DateTime.Today.AddDays(1),
                Time = TimeSpan.FromHours(12),
                Address = new Address
                {
                    Street = "115 West Silver St",
                    City = "West Field",
                    State = "MA",
                    Country = "USA"
                },
                EmailForRSVP = "user01@usermail.com"
            },

              new OutdoorGathering
            {
                Title = "Outdoor Gathering C",
                Description = "Do not have a limit on attendees, but need to track the weather forecast.",
                Date = DateTime.Today.AddDays(2),
                Time = TimeSpan.FromHours(14),
                Address = new Address
                {
                    Street = "85 South St",
                    City = "Ware",
                    State = "MA",
                    Country = "USA"
                },
                WeatherForecast = "Cloudy"
            }


        }; 
    }
}