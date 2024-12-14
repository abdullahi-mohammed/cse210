using System;
using System.Collections.Generic;
using System.IO;

public class Program
{
    static List<Goal> goals = new List<Goal>();
    static int score = 0;

    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine($"\nGoals: {score}");
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. Record Progress");
            Console.WriteLine("3. Show Goals");
            Console.WriteLine("4. Save Progress");
            Console.WriteLine("5. Load Progress");
            Console.WriteLine("6. Exit");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    RecordProgress();
                    break;
                case "3":
                    ShowGoals();
                    break;
                case "4":
                    SaveProgress("progress.txt", goals, score);
                    break;
                case "5":
                    (goals, score) = LoadProgress("progress.txt");
                    break;
                case "6":
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void CreateGoal()
    {
        Console.WriteLine("Select goal type:");
        Console.WriteLine("1. Simple Goal (one-time completion)");
        Console.WriteLine("2. Eternal Goal (repeatable)");
        Console.WriteLine("3. Checklist Goal (requires multiple completions)");
        Console.Write("Enter your choice: ");
        string typeChoice = Console.ReadLine();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();

        switch (typeChoice)
        {
            case "1":
                Console.Write("Enter points for completing this goal: ");
                int simplePoints = int.Parse(Console.ReadLine());
                goals.Add(new SimpleGoal(name, description, simplePoints));
                break;
            case "2":
                Console.Write("Enter points for each time this goal is recorded: ");
                int eternalPoints = int.Parse(Console.ReadLine());
                goals.Add(new EternalGoal(name, description, eternalPoints));
                break;
            case "3":
                Console.Write("Enter points for each completion: ");
                int checklistPoints = int.Parse(Console.ReadLine());
                Console.Write("Enter the number of completions required: ");
                int targetCount = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points for completing the checklist: ");
                int bonusPoints = int.Parse(Console.ReadLine());
                goals.Add(new ChecklistGoal(name, description, checklistPoints, targetCount, bonusPoints));
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                return;
        }

        Console.WriteLine("Goal created successfully.");
    }

    static void RecordProgress()
    {
        if (goals.Count == 0)
        {
            Console.WriteLine("No goals available.");
            return;
        }

        Console.WriteLine("Available goals:");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i]}");
        }

        Console.Write("Enter the number of the goal to record progress: ");
        if (int.TryParse(Console.ReadLine(), out int choice) && choice > 0 && choice <= goals.Count)
        {
            int earnedPoints = goals[choice - 1].RecordProgress();
            score += earnedPoints;
            Console.WriteLine($"Progress recorded. You earned {earnedPoints} points. Your score is now {score}.");
        }
        else
        {
            Console.WriteLine("Invalid choice. Please try again.");
        }
    }

    static void ShowGoals()
    {
        if (goals.Count == 0)
        {
            Console.WriteLine("No goals to display.");
            return;
        }

        Console.WriteLine("Your Goals:");
        foreach (var goal in goals)
        {
            Console.WriteLine(goal);
        }
    }

    static void SaveProgress(string filename, List<Goal> goals, int score)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                writer.WriteLine($"Score:{score}");
                foreach (var goal in goals)
                {
                    writer.WriteLine(goal.GetStringRepresentation());
                }
            }
            Console.WriteLine("Progress saved successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving progress: {ex.Message}");
        }
    }

    static (List<Goal>, int) LoadProgress(string filename)
    {
        List<Goal> loadedGoals = new List<Goal>();
        int loadedScore = 0;

        try
        {
            if (File.Exists(filename))
            {
                string[] lines = File.ReadAllLines(filename);
                loadedScore = int.Parse(lines[0].Split(':')[1]);

                foreach (string line in lines[1..])
                {
                    var goal = Goal.FromStringRepresentation(line);
                    if (goal != null)
                        loadedGoals.Add(goal);
                }

                Console.WriteLine("Progress loaded successfully.");
            }
            else
            {
                Console.WriteLine("No saved progress found.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading progress: {ex.Message}");
        }

        return (loadedGoals, loadedScore);
    }
}