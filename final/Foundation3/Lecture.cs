using System;

public class Lecture : Event
{   
    // Unique class attributes 
    private string _speaker;
    private int _capacity;

    public Lecture(string eventType, string eventTitle, string eventDescription, string eventDate, string eventTime, string speaker, int capacity): base(eventType, eventTitle, eventDescription, eventDate, eventTime)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    // Methods 
    public override string FullDetails()
    {
        return $"{base.FullDetails()}\nEvent Type: {base.GetEventType()} | Speaker: {_speaker} | Capacity: {_capacity} people.";
    }
}