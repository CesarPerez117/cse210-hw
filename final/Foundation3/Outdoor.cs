using System;

public class Outdoor : Event
{
    private string _weather;
    public Outdoor(string eventType, string eventTitle, string eventDescription, string eventDate, string eventTime, string weather): base(eventType, eventTitle, eventDescription, eventDate, eventTime)
    {
        _weather = weather;
    }

    public override string FullDetails()
    {
        return $"{base.FullDetails()}\nWeather: {_weather}";
    }
}