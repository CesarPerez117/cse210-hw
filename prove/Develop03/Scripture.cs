using System;
using System.Collections.Generic;

public class Scripture {

    private string _scriptureVersStart;
    private string _scriptureVersEnd;
    public string _singleScriptureFile = "singleEscripture.txt";

    // string[] singleScriptureLines = File.ReadAllLines(_singleScriptureFile);

    // getters and setter for scripture content
    // first for the start or 1st paragraph of scripture
    public string GetScriptureVersStart()
    {
        return _scriptureVersStart;
    }
    public void SetScriptureVersStart(string scriptureVersStart)
    {
        _scriptureVersStart = scriptureVersStart;
    }
    
    // second, for the end or 2nd paragraph of the scripture
    public string GetScriptureVersEnd()
    {
        return _scriptureVersEnd;
    }
    public void SetScriptureVersSEnd(string scriptureVersEnd)
    {
        _scriptureVersEnd = scriptureVersEnd;
    }

    
    
        /*public class ScriptureDictionary {
        Dictionary<int, ScriptureReference> scripture = new Dictionary<int, ScriptureReference>()
        {   
            {1, new ScriptureReference {_scriptureReference="John 3:16", _scriptureVersStart="For God so bloved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."}},
            {2, new ScriptureReference {_scriptureReference="Proverbs 3:5-6", _scriptureVersStart="Trust in the Lord with all thine heart; and lean not unto thine own understanding.", _scriptureVersEnd="In all thy ways acknowledge him, and he shall direct thy paths."}},
        };
    }*/
}