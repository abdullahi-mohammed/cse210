using System;

public abstract class MindfulnessActivity
{
    protected string name { get; set; }
    protected string description { get; set; }

    public void StartActivity(int duration)
    {
        Console.Clear();
        Console.WriteLine($"Starting {name}...");
        Console.WriteLine(description);
        Console.WriteLine($"You will do this activity for {duration} seconds.\n");
        Console.WriteLine("Prepare to begin...");
        DisplaySpinner(5);
    }

    public void EndActivity(int duration)
    {
        Console.WriteLine("\nGood job!");
        Console.WriteLine($"You have completed the {name} for {duration} seconds.");
        DisplaySpinner(5);
    }

    protected void DisplaySpinner(int seconds)
    {
        DateTime end = DateTime.Now.AddSeconds(seconds);
        while (DateTime.Now < end)
        {
            Console.Write("|");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(250);
            Console.Write("\b \b");
        }
    }

    public abstract void Execute(int duration);
}
