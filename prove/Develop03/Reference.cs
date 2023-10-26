using System;

public class Reference {
   
    private string _scriptureReference;

    public string GetScriptureReference()
    {
        return _scriptureReference;
    }

    public void SetScriptureReference(string scriptureReference)
    {
        _scriptureReference = scriptureReference;
    }

    /*public void SetScriptureReference()
    {

    }*/

    public void Display()
    {
        Console.WriteLine(_scriptureReference);
    }
    
}