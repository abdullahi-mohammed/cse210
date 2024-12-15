using System;
// Derived class: Cycling
public class Cycling : Activity
{
    public double speed { get; set; } // in mph

    public override double GetDistance() => (speed * minutes) / 60;
    public override double GetSpeed() => speed;
    public override double GetPace() => 60 / speed;
}
