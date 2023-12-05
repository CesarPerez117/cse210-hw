using System;

public class Cycling : Activity
{
    // attributes 

    // constructor
    public Cycling(string activity, string date, int minutes, double distance): base(activity, date, minutes, distance)
    {

    }

    // methods
    public override double GetDistance()
    {
        return base.GetDistance();
    }
    public override double CalculateSpeedKmh()
    {
        return base.CalculateSpeedKmh();
    }
    public override double CalculatePace()
    {
        return base.CalculatePace();
    }
    public override string DisplaySummary()
    {
        return base.DisplaySummary();
    }

}