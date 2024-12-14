using System;
using System.Collections.Generic;
using System.IO;


public abstract class Goal
{
    public string Name { get; set; }
    public string Description { get; set; }

    protected Goal(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public abstract int RecordProgress();
    public abstract string GetStringRepresentation();

    public static Goal FromStringRepresentation(string representation)
    {
        var parts = representation.Split('|');
        string type = parts[0];

        return type switch
        {
            "SimpleGoal" => new SimpleGoal(parts[1], parts[2], int.Parse(parts[3])) { IsCompleted = bool.Parse(parts[4]) },
            "EternalGoal" => new EternalGoal(parts[1], parts[2], int.Parse(parts[3])),
            "ChecklistGoal" => new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5])) { CurrentCount = int.Parse(parts[6]) },
            _ => null,
        };
    }

    public override string ToString() => $"Goal: {Name}, Description: {Description}";
}