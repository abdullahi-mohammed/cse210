using System;

public class Program
{
    public static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Mindfulness Program!");
            Console.WriteLine("Choose an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();
            if (choice == "4") break;

            Console.Write("Enter the duration in seconds: ");
            if (int.TryParse(Console.ReadLine(), out int duration))
            {
                MindfulnessActivity activity = choice switch
                {
                    "1" => new BreathingActivity(),
                    "2" => new ReflectionActivity(),
                    "3" => new ListingActivity(),
                    _ => null
                };

                activity?.Execute(duration);
            }
            else
            {
                Console.WriteLine("Invalid duration. Please try again.");
                Thread.Sleep(2000);
            }
        }

        Console.WriteLine("Thank you for using the Mindfulness Program!");
    }
}
