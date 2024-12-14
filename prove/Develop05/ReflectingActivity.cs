using System;
using System.Collections.Generic;

public class ReflectionActivity : MindfulnessActivity
{
    private static readonly List<string> Prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private static readonly List<string> Questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What did you learn from this experience?"
    };

    public ReflectionActivity()
    {
        name = "Reflection Activity";
        description = "This activity will help you reflect on times in your life when you have shown strength and resilience.";
    }

    public override void Execute(int duration)
    {
        StartActivity(duration);

        var random = new Random();
        string prompt = Prompts[random.Next(Prompts.Count)];
        Console.WriteLine($"\n{prompt}");
        Console.WriteLine("Reflect on the following questions:\n");

        DateTime end = DateTime.Now.AddSeconds(duration);
        while (DateTime.Now < end)
        {
            string question = Questions[random.Next(Questions.Count)];
            Console.WriteLine($"- {question}");
            DisplaySpinner(5);
        }

        EndActivity(duration);
    }
}
