using System;

public class Activity {

    // Variable that I need to create for the constructor
    // in the desing this was called _userTime : Int, but, _timeActivity is more understandable. It is true that the user enters de time, but is for the activities.
    private int _timeActivity;
 

    // IMPORTANT
    // I tried to made a whole constructor also for the activity name and description but it was to much trouble,
    // so I decided to make individual methods to make the starting and ending message. 
    public Activity(int timeActivity) 
    {
        // So basically, this will make the difference betwueen the things I do in the base agains the child
        _timeActivity = timeActivity;
        
    }

    public int ActivityTime() 
    { 
        // Ask and get the entry of the time from the user and return it to store it and use it.
        Console.Write("How long, in seconds, would you like for your session? ");
        int userEntry = int.Parse(Console.ReadLine());
        _timeActivity = userEntry;
        return userEntry;
    }
    public void SetActivityTime(int timeActivity) 
    { // I need this to called it outside
        _timeActivity = timeActivity;
    }
    

    public void Spinner() // this is an attempt of spinner I found in stackoverflow.
    {                       // i am using this version becuase works better for me.
        var counter = 0;
        for (int i = 0; i < 20; i++)
        {
            switch (counter % 4)
            {
                case 0: Console.Write("/"); break;
                case 1: Console.Write("-"); break;
                case 2: Console.Write("\\"); break;
                case 3: Console.Write("|"); break;
            }
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            counter++;
            Thread.Sleep(200);
        }
    }

    public void GetReady() // in the video demo, the spinned was used also to get ready, so lets do it. 
    { 
        var counter = 0;
        for (int i = 0; i < 50; i++)
        {
            switch (counter % 4)
            {
                case 0: Console.Write("Get ready... /"); break;
                case 1: Console.Write("Get ready... -"); break;
                case 2: Console.Write("Get ready... \\"); break;
                case 3: Console.Write("Get ready... |"); break;
            }
            Console.SetCursorPosition(Console.CursorLeft - 14, Console.CursorTop);
            counter++;
            Thread.Sleep(75);
        }
    }

}