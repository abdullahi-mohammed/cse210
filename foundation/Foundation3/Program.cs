using System;

// Main program
public class Program
{
    public static void Main(string[] args)
    {
        // Create activities
        var activities = new List<Activity>
        {
            new Running { date = "03 Nov 2022", minutes = 30, distance = 3.0 },
            new Cycling { date = "03 Nov 2022", minutes = 40, speed = 15.0 },
            new Swimming { date = "03 Nov 2022", minutes = 25, laps = 20 }
        };

        // Display summaries
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
