using System;

public class BreathingActivity : MindfulnessActivity
{
    public BreathingActivity()
    {
        name = "Breathing Activity";
        description = "This activity will help you relax by guiding you through deep breathing. Clear your mind and focus on your breathing.";
    }

    public override void Execute(int duration)
    {
        StartActivity(duration);

        DateTime end = DateTime.Now.AddSeconds(duration);
        while (DateTime.Now < end)
        {
            Console.WriteLine("Breathe in...");
            Thread.Sleep(3000); // Simulate breathing in
            Console.WriteLine("Breathe out...");
            Thread.Sleep(3000); // Simulate breathing out
        }

        EndActivity(duration);
    }
}
