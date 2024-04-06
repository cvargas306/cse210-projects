using System;
using System.Collections.Generic;
using System.Threading;
//Check the comments to know the exceeding requirements
//( Keeping a log of how many times activities were performed)

public abstract class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }   

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Starting {_name} activity. {_description}");
        Console.Write("Enter the duration of the activity in seconds: ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        ShowSpinner(2);
    }

    public abstract void Run();
    public virtual void DisplayEndingMessage()
    {
        Console.WriteLine("You have done a good job!");
        ShowSpinner(2);
        Console.WriteLine($"You have completed the {_name} activity for {_duration} seconds.");
        ShowSpinner(2);
    }
    protected void ShowSpinner(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(seconds);
        while (DateTime.Now < futureTime)
        {
            Console.Write("/");
            Thread.Sleep(125);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(125);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(125);
            Console.Write("\b \b");
            Console.Write("|");
            Thread.Sleep(125);
            Console.Write("\b \b");
        }
    }
    protected void ShowCountDown(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(seconds);
        while (DateTime.Now < futureTime)
        {
            Console.Write((futureTime - DateTime.Now).Seconds);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

}
public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.") {}
    
    public override void Run()
    {
        DisplayStartingMessage();
        for (int i = 0; i < _duration; i++)
        {
            Console.WriteLine(i % 2 == 0 ? "Breathe in..." : "Breathe out...");
            ShowCountDown(1);
        }
        DisplayEndingMessage();
    }
}


public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }

    public override void Run()
    {
        DisplayStartingMessage();
        GetRandomPrompt();
        GetListFromUser();
        DisplayEndingMessage();
    }

    private void GetRandomPrompt()
    {
        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count)];
        Console.WriteLine(prompt);
    }

     private List<string> GetListFromUser()
     {
         List<string> list = new List<string>();
         DateTime startTime = DateTime.Now;
         while ((DateTime.Now - startTime).TotalSeconds < _duration)
         //for (int i = 0; i < _duration; i++)   //I commented these lines to fix the error. I kept the lines to remember what I make before
         {
             string item = Console.ReadLine();
             if (!string.IsNullOrEmpty(item))
             {
                list.Add(item);
                ShowCountDown(1);
                
            //  }
            //  if (i <_duration -1 )
            //  {
                //ShowCountDown(1);
             }
                  
         }
         _count = list.Count;
         return list;
     }
     public override void DisplayEndingMessage()
     {
        Console.WriteLine($"You have listed {_count} items.");
        base.DisplayStartingMessage();
     }
}

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity() : base("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

    }

    public override void Run()
    {
        DisplayStartingMessage();
        DisplayPrompt();
        DisplayQuestions();
        DisplayEndingMessage();
    }

    private void DisplayPrompt()
    {
        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count)];
        Console.WriteLine(prompt);
    }

    private void DisplayQuestions()
    {
        Random random = new Random();
        for (int i = 0; i < _duration; i++)
        {
            string question = _questions[random.Next(_questions.Count)];
            Console.WriteLine(question);
            ShowCountDown(1);
        }
    }

}


class Program
{
    static int breathingActivityCount = 0;
    static int listingActivityCount = 0;
    static int reflectingActivityCount = 0;
    static void Main(string[] args)
    {
        BreathingActivity breathingActivity= new BreathingActivity(); //I declared 3 integer variables to keep track of the count for each activity.
        ListingActivity listingActivity = new ListingActivity();
        ReflectingActivity reflectingActivity = new ReflectingActivity();

        while (true)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start listing activity");
            Console.WriteLine("3. Start reflecting activity");
            Console.WriteLine("4. Show activity counts"); //Menu modified to add an option to Show activity counts
            Console.WriteLine("5. Quit");
            Console.Write("Type a number from the menu to choose an option: ");

            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    breathingActivity.Run();
                    breathingActivityCount++; //Incrementing correspondint count
                    break;
                case "2":
                    listingActivity.Run();
                    listingActivityCount++;
                    break;
                case "3":
                    reflectingActivity.Run();
                    reflectingActivityCount++;
                    break;
                case "4":
                    DisplayActivityCounts();
                    break;
                case "5":
                    return; 
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        
        }

    }
    static void DisplayActivityCounts() //Method added to display the counts
{
    Console.WriteLine($"Breathing Activity has been performed {breathingActivityCount} times.");
    Console.WriteLine($"Listing Activity has been performed {listingActivityCount} times.");
    Console.WriteLine($"Reflecting Activity has been performed {reflectingActivityCount} times.");
}

} 
    



    
    


