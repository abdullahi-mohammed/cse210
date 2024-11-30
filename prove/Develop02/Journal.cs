using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> Entries { get; set; } = new List<Entry>();
    private static readonly string[] prompts = new string[]
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    public void AddEntry(string response)
    {
        Random rand = new Random();
        string prompt = prompts[rand.Next(prompts.Length)];
        string date = DateTime.Now.ToString("MM/dd/yyyy HH:mm");
        Entries.Add(new Entry(date, prompt, response));
    }

    public void DisplayEntries()
    {
        foreach (var entry in Entries)
        {
            Console.WriteLine(entry);
        }
    }

    public void SaveJournal(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in Entries)
            {
                writer.WriteLine($"{entry.Date}|{entry.Prompt}|{entry.Response}");
            }
        }
    }

    public void LoadJournal(string filename)
    {
        if (File.Exists(filename)) // Check if the file exists
        {
            Entries.Clear(); // Clear any existing entries
            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    // Split by the delimiter, assuming it's "|" for the date, prompt, and response
                    var parts = line.Split('|');
                    if (parts.Length == 3) // Ensure the line has exactly 3 parts (date, prompt, response)
                    {
                        Entries.Add(new Entry(parts[0], parts[1], parts[2]));
                    }
                    else
                    {
                        Console.WriteLine("Invalid entry format in the file.");
                    }
                }
            }
            Console.WriteLine("Journal loaded successfully.");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}

