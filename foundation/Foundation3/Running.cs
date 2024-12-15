using System;
// Derived class: Running
public class Running : Activity
{
    public double distance { get; set; } // in miles

    public override double GetDistance() => distance;
    public override double GetSpeed() => (distance / minutes) * 60;
    public override double GetPace() => minutes / distance;
}