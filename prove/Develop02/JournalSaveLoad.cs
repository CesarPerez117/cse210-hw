using System;
using System.ComponentModel;
using System.IO;
using Microsoft.VisualBasic;


public class JournalSaveLoad
{
    public List<JournalEntry> _journalSave = new List<JournalEntry>(); // here is were I store the current user entrys.
    public string _readText = ""; // an attribute that I placed to help me with the Load and Displays of file.txt,
                                    // more info in the program, option 3.
    public JournalSaveLoad()
    {
    }

    public void Display()
    {
        foreach (JournalEntry journalEntry in _journalSave)
        {   // displays the current user entrys stored in _journalSave.
            journalEntry.Display();
        }

    }
    
    
    public void LoadFile()
    {
        Console.Write("What is the file name? ");
        string _fileName = Console.ReadLine();
        

        if (File.Exists(_fileName)) // double check that the file exists and we can work on it. 
        {
            _readText = File.ReadAllText(_fileName); // store all the info inside the file.txt in the attribute
            
            // I need to send readText to the Display option
            //Console.WriteLine(readText);
            Console.WriteLine("File ready to display.");
        }
        else 
        {
            Console.WriteLine("The file was not found.");
        }
    }
    public void SaveFile(string _fileNameSave)
    {
        using (StreamWriter outputFile = new StreamWriter(_fileNameSave)) // calls the SW 
        {   // I need to iterate trough all the lines in the Entry to save it.
            foreach (JournalEntry journalEntry in _journalSave)
            {
                outputFile.WriteLine($"Date: {journalEntry._dateTime} - {journalEntry._journalPrompt}");
                outputFile.WriteLine($"> {journalEntry._journalAnswer}");

                // this is the standar to save the entry
            }
        }
    }
    
    public void CreateFile() 
    // why this class. Well basically, I know it overwrites the files, but I was thinking I can do something better,
    // then I added this funtion, that asks the file name, if the name you entered does not exists, will create the file and 
    // write the entry. If the file exists, will advice you about the overwriting and will asks you to confirm. 
    {
        Console.WriteLine("IMPORTANT! Remeber your file name needs .txt at the final.");
        Console.Write("What is the file name? ");
    
        string _userAnswer = Console.ReadLine();
       
        if (!File.Exists(_userAnswer))
        {
            
            //File.CreateText(_userAnswer); // this method gives me errors 
            SaveFile(_userAnswer);
            Console.Write("> File Created.");
            Console.WriteLine($" Journal entry added to {_userAnswer} and saved.");
            SaveFile(_userAnswer);
        }
        else
        { 
        
            Console.WriteLine($"> {_userAnswer} file already exists.");
            Console.WriteLine("File will be overwritting. Want to continue? " +
            "\n1. Yes" +
            "\n2. No");
            Console.Write("> ");
            int _currentAnswer = int.Parse(Console.ReadLine()); 
            if (_currentAnswer is 1)
            {
                SaveFile(_userAnswer);
                Console.WriteLine("> Journal overwritted.");
            }
            else if (_currentAnswer is 2)
            {
                Console.WriteLine("> Canceled.");
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }

    }

    /*public void AddJournalToFile(string _fileName) // this is a failed try to create something that can append instead of overwrite. 
    { 
        using (StreamWriter outputFile = new StreamWriter(_fileName))
        {
            foreach (JournalEntry journalEntry in _journalSave)
                {
                    outputFile.WriteLine($"Date: {journalEntry._dateTime} - Prompt: {journalEntry._journalPrompt}");
                    outputFile.WriteLine($"> {journalEntry._journalAnswer}\n");
                }
        }
    }*/
}