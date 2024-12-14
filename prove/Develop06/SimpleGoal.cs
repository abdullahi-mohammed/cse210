using System;
using System.Collections.Generic;
using System.IO;

public class SimpleGoal : Goal
{
    public int Points { get; set; }
    public bool IsCompleted { get; set; }

    public SimpleGoal(string name, string description, int points) : base(name, description)
    {
        Points = points;
        IsCompleted = false;
    }

    public override int RecordProgress()
    {
        if (!IsCompleted)
        {
            IsCompleted = true;
            return Points;
        }
        return 0;
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal|{Name}|{Description}|{Points}|{IsCompleted}";
    }

    public override string ToString()
    {
        return base.ToString() + $", Points: {Points}, Completed: {IsCompleted}";
    }
}


public class EternalGoal : Goal
{
    public int PointsPerCompletion { get; set; }

    public EternalGoal(string name, string description, int pointsPerCompletion) : base(name, description)
    {
        PointsPerCompletion = pointsPerCompletion;
    }

    public override int RecordProgress()
    {
        return PointsPerCompletion;
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal|{Name}|{Description}|{PointsPerCompletion}";
    }

    public override string ToString()
    {
        return base.ToString() + $", Points per Completion: {PointsPerCompletion}";
    }
}

public class ChecklistGoal : Goal
{
    public int PointsPerCompletion { get; set; }
    public int TargetCount { get; set; }
    public int BonusPoints { get; set; }
    public int CurrentCount { get; set; }

    public ChecklistGoal(string name, string description, int pointsPerCompletion, int targetCount, int bonusPoints) : base(name, description)
    {
        PointsPerCompletion = pointsPerCompletion;
        TargetCount = targetCount;
        BonusPoints = bonusPoints;
        CurrentCount = 0;
    }

    public override int RecordProgress()
    {
        if (CurrentCount < TargetCount)
        {
            CurrentCount++;
            if (CurrentCount == TargetCount)
            {
                return PointsPerCompletion + BonusPoints;
            }
            return PointsPerCompletion;
        }
        return 0;
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{Name}|{Description}|{PointsPerCompletion}|{TargetCount}|{BonusPoints}|{CurrentCount}";
    }

    public override string ToString()
    {
        return base.ToString() + $", Points per Completion: {PointsPerCompletion}, Target: {TargetCount}, Bonus: {BonusPoints}, Completed: {CurrentCount}/{TargetCount}";
    }
}
