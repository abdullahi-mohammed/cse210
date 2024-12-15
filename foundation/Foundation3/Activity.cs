using System;
using System.Collections.Generic;

// Base class: Activity
public abstract class Activity
{
    public string date { get; set; }
    public int minutes { get; set; }

    public abstract double GetDistance(); // Abstract to ensure derived classes implement it
    public abstract double GetSpeed();
    public abstract double GetPace();
    public virtual string GetSummary()
    {
        return $"{date} ({minutes} min): Distance: {GetDistance():0.0} miles, " +
               $"Speed: {GetSpeed():0.0} mph, Pace: {GetPace():0.0} min per mile";
    }
}
