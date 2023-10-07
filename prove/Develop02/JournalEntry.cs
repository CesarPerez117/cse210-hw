using System;

public class JournalEntry
{
    public string _dateTime = "";
    public string _journalPrompt = "";
    public string _journalAnswer = "";
    public JournalEntry()
    {
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_dateTime} - {_journalPrompt}");
        Console.WriteLine($"> {_journalAnswer}");
    }
}