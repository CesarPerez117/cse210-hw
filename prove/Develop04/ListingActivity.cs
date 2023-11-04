using System;
using System.Diagnostics;

public class ListingActivity : Activity
{
    private string _activityName = "Breathing";
    private string _activityDescription = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    private List<string> _promptList = new List<string>
    {
    "Who are people that you appreciate?",
    "What are personal strengths of yours?",
    "Who are people that you have helped this week?",
    "When have you felt the Holy Ghost this month?",
    "Who are some of your personal heroes?"
    };


    public ListingActivity(int timeActivity) : base(timeActivity)
    {
    }
    
    public void StartingMessage()
    {
        Console.WriteLine($"Welcome to the {_activityName} Activity.\n{_activityDescription}");
    }
    public void EndingMessage(int seconds)
    {
        Console.WriteLine($"\nWell Done!\nYou have completed another {seconds} seconds of the {_activityName} activity");
    }

    private string GetRandomPrompt()
    {
        var random = new Random();
        int index = random.Next(_promptList.Count);
        return _promptList[index];
    }
    
    public void ShowPrompt()
    {
        string prompt = GetRandomPrompt();
        Console.Clear();
        Console.WriteLine("\nList as many responses you can to the following prompt:");
        Console.WriteLine($"\n--- {prompt} ---");

    }

    public void GetUserList(int seconds)
    {
        int timer = 0;
        string item;
        List<string> userList = new List<string> {};
        Console.Write($"You may begin in: ");
        for (int i = 5; i > 0; i--)
        {   
            Console.Write($"{i}");
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        while (timer < seconds)
        {   
            if (timer == seconds)
            {
                break;
            }
            if (timer != seconds)
            {   
                Console.Write("\n> ");
                item = Console.ReadLine();
                userList.Add(item);
                timer += 5;
            }
        }
        int listCount = userList.Count;
        Console.WriteLine($"You listed {listCount} items!");
        Thread.Sleep(5000);
    }

    
}