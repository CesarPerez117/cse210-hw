using System;

public class Reception : Event
{
    private string _emailRSVP;
    // I needed to investigate what is an RSVP, and I found:
    // RSVP is an abbreviation of the French phrase répondez s'il vous plaît, or in the English language, “reply, if it pleases you.”
    public Reception(string eventType, string eventTitle, string eventDescription, string eventDate, string eventTime, string emailRSVP): base(eventType, eventTitle, eventDescription, eventDate, eventTime)
    {
        _emailRSVP = emailRSVP;
    }

    public override string FullDetails()
    {
        return $"{base.FullDetails()}\nEmail RSVP: {_emailRSVP}";
    }
}