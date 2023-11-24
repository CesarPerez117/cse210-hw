using System;

public class SimpleGoal : Goal
{

    public SimpleGoal(string goalName, string goalDescription, int goalPoints) : base(goalName, goalDescription, goalPoints)
    {
        //
    }
    public override void DisplayGoalMessage()
    {
        base.DisplayGoalMessage();
    }

    public override void SaveGoal(StreamWriter writer)
    {
        writer.WriteLine($"Simple Goal | {GetName()} {GetDescription()} | {_goalPoints}");
        // this use of the method of getters and setter was my solution for the journal but I learned it here... sad.
    }

    public override void LoadGoal(string[] data)
    {
        base.LoadGoal(data);
    }

    public override void RecordEvent(int index, List<Goal> goals)
    {
        base.RecordEvent(index, goals);
        base.AddPoints();
    }

    public override string DisplayGoal()
    {
        string goal = base.DisplayGoal();
        return goal;
    }

}