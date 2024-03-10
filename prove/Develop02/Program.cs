using System;
using System.IO;
using System.Collections.Generic;
class Program
{
    static List<Entry> journalEntries = new List<Entry>();
    static Random random = new Random();
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");

            Console.Write("Choose an option (1-5): ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    WriteNewEntry();
                    break;
                case "2":
                    DisplayJournal();
                    break;
                case "3":
                    SaveJournalToFile();
                    break;
                case "4":
                    LoadJournalFromFile();
                    break;
                case "5":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please choose again.");
                    break;

            }
        }
        
    }
    static void WriteNewEntry()
    {
        string[] prompts = {
            "What was a new blessing I received today?",
            "What good action did I do today?",
            "How did I see the hand of the Lord in my life today?",
            "What made me happy today?",
            "What did I learn today?"
        };
        string prompt = prompts[random.Next(prompts.Length)];

        Console.WriteLine($"Prompt: {prompt}");
        Console.Write("Your response: ");
        string response = Console.ReadLine();

        string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        Entry newEntry = new Entry(prompt, response, date);
        journalEntries.Add(newEntry);

        Console.WriteLine("Entry saved successfully!\n");
    }

    static void DisplayJournal()
    {
        Console.WriteLine("Journal Entries:");
        foreach (var entry in journalEntries)
        {
            Console.WriteLine($"Date: {entry.Date}\nPrompt: {entry.Prompt}\nResponse: {entry.Response}\n");
        }
    }

    static void SaveJournalToFile()
    {
        Console.Write("Enter a filename to save the journal: ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (var entry in journalEntries)
            {
                outputFile.WriteLine($"{entry.Date}|{entry.Prompt}|{entry.Response}");
            }
        }

        Console.WriteLine("Journal saved to file successfully!\n");
    }

    static void LoadJournalFromFile()
    {
        Console.Write("Enter a filename to load the journal: ");
        string fileName = Console.ReadLine();

        try
        {
            string[] lines = File.ReadAllLines(fileName);
            journalEntries.Clear();

            foreach (var line in lines)
            {
                string[] parts = line.Split('|');
                if (parts.Length == 3)
                {
                    string date = parts[0].Trim();
                    string prompt = parts[1].Trim();
                    string response = parts[2].Trim();

                    Entry loadedEntry = new Entry(prompt, response, date);
                    journalEntries.Add(loadedEntry);
                }
            }

            Console.WriteLine("Journal loaded from file successfully!\n");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading journal from file: {ex.Message}\n");
        }
    }
}

class Entry
{
    public string Prompt { get; }
    public string Response { get; }
    public string Date { get; }

    public Entry(string prompt, string response, string date)
    {
        Prompt = prompt;
        Response = response;
        Date = date;
    }
}