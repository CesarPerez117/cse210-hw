using System.Diagnostics.CodeAnalysis;

public class Person
{
    private string _title;
    private string _firstName;
    private string _lastName;

    public string GetTitle()
    {
        return _title;
    }
    public void SetTitle(string title)
    {
        _title = title;
    }

    public string GetFirstName()
    {
        return _firstName;
    }
    public void SetFirstName(string firstName)
    {
        _firstName = firstName;
    }

    public string GetLastName()
    {
        return _lastName;
    }
    public void SetLastName(string lastName)
    {
        _lastName = lastName;
    }


    public string GetInformalSignature()
    {
        return "Thanks, " + _firstName;
    }

    public string GetFormalSignature()
    {
        return "Sincerely, " + GetFullName();
    }

    private string GetFullName()
    {
        return _title + " " + _firstName + " " + _lastName;
    }
    
}