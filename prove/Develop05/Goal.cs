using System;

public abstract class Goal 
{
    protected int _points;
    protected string _goalName;
    protected string _goalDescription;
    protected int _goalPoints;
    private bool _completed; // this is part of the help I received from Jonathan
    

    public Goal(string goalName, string goalDescription, int goalPoints)
    {
        _points = 0;
        _goalName = goalName;
        _goalDescription = goalDescription;
        _goalPoints = goalPoints;
        _completed = false;
    }

    public string GetName()
    {
        return _goalName;
    }
    public string GetDescription()
    {
        return _goalDescription;
    }

    public int GetPoints()
    {
        return _points;
    }
    public virtual void AddPoints()
    {
        _points += _goalPoints;
    }
    
    public virtual void DisplayGoalMessage()
    {
        Console.WriteLine("What is the name of your goal? ");
        _goalName = Console.ReadLine();
        Console.WriteLine("What is a shor description of it? ");
        _goalDescription = Console.ReadLine();
        Console.WriteLine("What is the amount of points associated with this goal? ");
        _goalPoints = int.Parse(Console.ReadLine());
    }

    public virtual void SaveGoal(StreamWriter writer)
    {
        writer.WriteLine(_points);
        string goal = $"{_goalName} | {_goalDescription} | {_goalPoints} | {_completed}";
        writer.WriteLine(goal);
    }

    public virtual void LoadGoal(string[] data)
    {
        _goalName = data[1];
        _goalDescription = data[2];
        _goalPoints = int.Parse(data[3]);
        _completed = bool.Parse(data[4]);
    }

    public virtual void RecordEvent(int index, List<Goal> goals)
    {
        Goal selectedGoal = goals[index - 1]; // the -1 is to match with array localization as 1 is 0 in an array.
        selectedGoal.MarkCompleted();
    }
    public virtual void MarkCompleted()
    {
        _completed = true;
    }
    public virtual bool IsComplete()
    {
        return _completed; // Jonathan showed me the code were he found this but I don't understand what it does yet. He told me is to get back the value from MarkComplete 
    }

    public virtual string DisplayGoal()
    {
        string goal;
        if (IsComplete())
        {
            goal = $"[x] {_goalName} {_goalDescription}";
        }
        else
        {
            goal = $"[ ] {_goalName} {_goalDescription}";
        }
        return goal;
    }

    
}