using System;

public class Swimming : Activity
{
    // Note: the length of a lap in the lap pool is 50 meters.

    // I am having errors displaying this class


    // attributes 
    private int _numberOfLaps;
    private double _swimmingDistance;
    private int _minutes;
    private string _date;

    // constructor
    public Swimming(string activity, string date, int minutes, double distance, int numberOfLaps): base(activity, date, minutes, distance)
    {
        _numberOfLaps = numberOfLaps;
        _minutes = minutes;
        _date = date;
    }

    // methods

    public override double GetDistance()
    {
        _swimmingDistance = _numberOfLaps * 50 / 1000;
        return _swimmingDistance;
    }
    public override double CalculateSpeedKmh()
    {
        return _swimmingDistance / _minutes * 60;
    }
    public override double CalculatePace()
    {
        return _minutes / _swimmingDistance;
    }
    public override string DisplaySummary()
    {
        return $"{_date} | {GetActivity()} | ({_minutes} minutes): Number of Laps: {_numberOfLaps} laps, Distance: {_swimmingDistance} km, Speed: {CalculateSpeedKmh():F2} kph, Pace: {CalculatePace():F2} min per km";
    }

}