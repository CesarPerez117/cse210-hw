using System;

public class EternalGoal : Goal
{

    public EternalGoal(string goalName, string goalDescription, int goalPoints) : base(goalName, goalDescription, goalPoints)
    {
        //
    }

    public override void DisplayGoalMessage()
    {
        base.DisplayGoalMessage();
    }
    public override void SaveGoal(StreamWriter writer)
    {
        writer.WriteLine($"Eternal Goal | {GetName()} {GetDescription()} {_goalPoints}");
    }

    public override void LoadGoal(string[] data)
    {
        _goalName = data[1];
        _goalDescription = data[2];
        _goalPoints = int.Parse(data[3]);
    }

    public override void RecordEvent(int index, List<Goal> goals)
    {
        Goal selectedGoal = goals[index - 1];
        selectedGoal.AddPoints();
    }

    public override string DisplayGoal()
    {
        string goal = base.DisplayGoal();
        return goal;
    }


}