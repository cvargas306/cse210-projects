using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        string percentage = Console.ReadLine();
        int percent = int.Parse(percentage); 

        string grade = "";

        if (percent >= 90)
        {
            grade = "A";
        }

        else if (percent >= 80)
        {
            grade = "B";
        }

        else if (percent >= 70)
        {
            grade = "C";
        }

        else if (percent >= 60)
        {
            grade = "D";
        }

        else 
        {
            grade = "F";
        }

        Console.WriteLine($"Your grade is: {grade}");

        if (percent >= 70)
        {
            Console.WriteLine("You approved.");
        }

        else
        {
            Console.WriteLine("Keep trying");
        }
    }
}

