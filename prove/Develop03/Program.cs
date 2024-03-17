using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture("John 3:16", "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");
        while (true)
        {
            Console.WriteLine(scripture.ToString());
            Console.WriteLine("\nPress Enter to hide a word or type 'quit' to exit.");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
                break;
            scripture.HideRandomWord();
        }
    }
}

public class Scripture
{
    public Reference Reference { get; set; }
    public List<Word> Words { get; set; }

    public Scripture(string reference, string text)
    {
        Reference = new Reference(reference);
        Words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void HideRandomWord()
    {
        Random random = new Random();
        int index = random.Next(Words.Count);
        Words[index].IsHidden = true;
    }

    public override string ToString()
    {
        return $"{Reference.ToString()}\n{string.Join(" ", Words)}";
    }
}

public class Reference
{
    public string Book { get; set; }
    public int Chapter { get; set; }
    public int VerseStart { get; set; }
    public int? VerseEnd { get; set; }

    public Reference(string reference)
    {
        string[] parts = reference.Split(' ');
        Book = parts[0];
        string[] verses = parts[1].Split('-');
        Chapter = int.Parse(verses[0].Split(':')[0]);
        VerseStart = int.Parse(verses[0].Split(':')[1]);
        VerseEnd = verses.Length > 1 ? int.Parse(verses[1]) : (int?)null;
    }

    public override string ToString()
    {
        return $"{Book} {Chapter}:{VerseStart}" + (VerseEnd.HasValue ? $"-{VerseEnd.Value}" : "");
    }
}

public class Word
{
    public string Text { get; set; }
    public bool IsHidden { get; set; }

    public Word(string text)
    {
        Text = text;
        IsHidden = false;
    }

    public override string ToString()
    {
        return IsHidden ? "_____" : Text;
    }
}

