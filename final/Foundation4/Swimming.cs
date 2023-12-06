using System;

public class Swimming : Activity
{
    // Note: the length of a lap in the lap pool is 50 meters.

    // I am having errors displaying this class

    // Final Note: Now is working. My problem is that I was doing mathematical operacion between double and int and that 
    // returns 0 in every case for some reason. 


    // attributes 
    private double _numberOfLaps;
    //private double _swimmingDistance;
    //private int _minutes;

    // constructor
    public Swimming(string activity, string date, int minutes, double distance, int numberOfLaps): base(activity, date, minutes, distance)
    {
        _numberOfLaps = numberOfLaps;
        //_minutes = minutes;
    }

    // methods

    public double GetNumberOfLaps()
    {
        return _numberOfLaps;
    }
    public double GetSwimmingDistance()
    {
        //return GetNumberOfLaps() * 50 / 1000;
        return (_numberOfLaps * 50) / 1000;
    }
    public override double CalculateSpeedKmh()
    {
        return GetSwimmingDistance() / GetMinutes() * 60;
    }
    public override double CalculatePace()
    {
        return GetMinutes() / GetSwimmingDistance();
    }
    public override string DisplaySummary()
    {
        return $"{GetDate()} | {GetActivity()} | ({GetMinutes()} minutes): Number of Laps: {GetNumberOfLaps()} laps, Distance: {GetSwimmingDistance()} km, Speed: {CalculateSpeedKmh():F2} kph, Pace: {CalculatePace():F2} min per km";
    }

}