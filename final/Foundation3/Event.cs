using System;
using System.Net.Sockets;

public class Event
{
    // General attributes 
    private string _eventType;
    private string _eventTitle;
    private string _eventDescription;
    private string _eventDate;
    private string _eventTime; // At first this was an integer but was so hard for me to make it works :(
    protected string _address; // I placed protected becuase I am trying to use inheritance to get full details address 
    // extra note: It wans't possible to figure it out how to get every full details with the address, and it's becuase I have it in a method

    // Constructor 
    public Event(string eventType, string eventTitle, string eventDescription, string eventDate, string eventTime)
    {   
        _eventType = eventType;
        _eventTitle = eventTitle;
        _eventDescription = eventDescription;
        _eventDate = eventDate;
        _eventTime = eventTime;
        

    }

    // Methods 
    public string GetAddress(string street, string city, string state, string country)
    {
        string _address = $"{street}, {city}, {state}, {country}";
        return _address;
    }
    public string GetEventType()
    {
        return _eventType;
    }
    public string StandarDetails(string address)
    {
        _address = address;
        return $"Title: {_eventTitle}\nDescription: {_eventDescription}\nDate: {_eventDate} | Time: {_eventTime}\nAddress: {_address}";
    }

    // Teacher Nathan said in the Teams Server that I can use Polymorphism and I need it here.
    public virtual string FullDetails()
    {
        // the same as standar but will add from the child classes 
        return $"Title: {_eventTitle}\nDescription: {_eventDescription}\nDate: {_eventDate} | Time: {_eventTime}\nAddress: {_address}";
    }

    public string ShortDescription()
    {
        return $"Event Type: {_eventType}\nTitle: {_eventTitle}\nDate: {_eventDate}";
    }
}