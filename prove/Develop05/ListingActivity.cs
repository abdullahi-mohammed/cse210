using System;
using System.Collections.Generic;

public class ListingActivity : MindfulnessActivity
{
    private static readonly List<string> Prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are your personal strengths?",
        "Who are people you have helped this week?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity()
    {
        name = "Listing Activity";
        description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    public override void Execute(int duration)
    {
        StartActivity(duration);

        var random = new Random();
        string prompt = Prompts[random.Next(Prompts.Count)];
        Console.WriteLine($"\n{prompt}");
        Console.WriteLine("Start listing your responses. Press Enter after each one.\n");

        DateTime end = DateTime.Now.AddSeconds(duration);
        int count = 0;

        while (DateTime.Now < end)
        {
            Console.Write("> ");
            Console.ReadLine(); // Collect input
            count++;
        }

        Console.WriteLine($"\nYou listed {count} items!");
        EndActivity(duration);
    }
}
