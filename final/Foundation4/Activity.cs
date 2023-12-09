using System;

public class Activity
{
    // attributes 
    private string _date;
    private double _minutes;
    //private double _distance;
    //private double _speed;
    //private double _pace;
    private string _activity;

    // constructor
    public Activity(string activity, string date, int minutes)
    {
        _date = date;
        _minutes = minutes;
        //_distance = distance;
        //_speed = speed;
        //_pace = pace;
        _activity = activity;
    }

    // methods
    // NOTE: my country use Kilometers per hour so I will use that one. 
    public string GetActivity()
    {
        return _activity;
    }
    public string GetDate()
    {
        return _date;
    }
    public double GetMinutes()
    {
        return _minutes;
    }
    // All methods will start with Running standar but will change when needed. 
    public virtual double GetDistance()
    {
        return 0.0;
    }
    public virtual double CalculateSpeedKmh()
    {
        return 0.0;
    }
    public virtual double CalculatePace()
    {
        return 0.0;
    }
    public virtual string DisplaySummary()
    {   
        return $"{GetDate()} | {GetActivity()} | ({GetMinutes()} minutes): Distance: {GetDistance()} km, Speed: {CalculateSpeedKmh():F2} kph, Pace: {CalculatePace():F2} min per km";
    }
    

    // Example of display
    // 03 Nov 2022 Running (30 min): Distance 4.8 km, Speed: 9.7 kph, Pace: 6.9 min per km
    // $"{_date} {_activity} ({_minutes} minutes): Distance: {_distance} km, Speed: {_speed} kph, Pace: {_pace} min per km";
}