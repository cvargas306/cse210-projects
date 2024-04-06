using System;
using System.Collections.Generic;
using System.Threading;

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
    public void DisplayEndingMessage()
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
        for (int i = 0; i < _duration; i++)
        {
            Console.Write("Enter an item for your list (or 'done' to finish): ");
            string item = Console.ReadLine();
            if (string.IsNullOrEmpty(item)|| item.ToLower() == "done")
            {
                break;
            }
            list.Add(item);
            
        }
        _count = list.Count;
        return list;
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
    static void Main(string[] args)
    {
        BreathingActivity breathingActivity= new BreathingActivity();
        ListingActivity listingActivity = new ListingActivity();
        ReflectingActivity reflectingActivity = new ReflectingActivity();

        while (true)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start listing activity");
            Console.WriteLine("3. Start reflecting activity");
            Console.WriteLine("4. Quit");
            Console.Write("Type a number from the menu to choose an option: ");

            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    breathingActivity.Run();
                    break;
                case "2":
                    listingActivity.Run();
                    break;
                case "3":
                    reflectingActivity.Run();
                    break;
                case "4":
                    return; 
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        
        }

    }

} 
    



    
    


