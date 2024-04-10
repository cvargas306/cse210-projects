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
                Title = "Lecture 1",
                Description = "Description 1",
                Date = DateTime.Today,
                Time = TimeSpan.FromHours(10),
                Address = new Address
                {
                    Street = "123 Main St",
                    City = "Anytown",
                    State = "NY",
                    Country = "USA"
                },
                SpeakerName = "John Doe",
                Capacity = 100
            },
            // Add more events here...
        }; 
    }
}