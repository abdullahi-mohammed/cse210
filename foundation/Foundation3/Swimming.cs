using System;
// Derived class: Swimming
public class Swimming : Activity
{
    public int laps { get; set; }
    private const double lapDistance = 50 / 1000.0 * 0.62; // 50 meters in miles

    public override double GetDistance() => laps * lapDistance;
    public override double GetSpeed() => (GetDistance() / minutes) * 60;
    public override double GetPace() => minutes / GetDistance();
}
