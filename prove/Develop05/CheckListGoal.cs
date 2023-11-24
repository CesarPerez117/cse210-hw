using System;
using System.Runtime.CompilerServices;

public class CheckListGoal : Goal
{
    private int _goalTarget;
    private int _goalProgress;
    private int _goalBonus;
    public CheckListGoal(string goalName, string goalDescription, int goalPoints) : base(goalName, goalDescription, goalPoints)
    {
        _goalProgress = 0;
        _goalTarget = 0;
        _goalBonus = 0;
    }

    public override void DisplayGoalMessage()
    {
        base.DisplayGoalMessage();
        Console.WriteLine("How many times does this goal need to be accomplished for a bonus? ");
        _goalTarget = int.Parse(Console.ReadLine());
        Console.WriteLine("What is the bonus for accomplishing it that many times? ");
        _goalBonus = int.Parse(Console.ReadLine()); 
    }

    public override void SaveGoal(StreamWriter writer)
    {
        writer.WriteLine($"CheckListGoal | {GetName()} | {GetDescription()} | {_goalPoints} | {_goalTarget} | {_goalBonus} | {_goalProgress}");
    }
    public override void LoadGoal(string[] data)
    {
        _goalName = data[1];
        _goalDescription = data[2];
        _goalPoints = int.Parse(data[3]);
        _goalTarget = int.Parse(data[4]);
        _goalBonus = int.Parse(data[5]);
        _goalProgress = int.Parse(data[6]);
    }
    public override void RecordEvent(int index, List<Goal> goals)
    {
        base.AddPoints();
        _goalProgress++;

        if (_goalProgress == _goalTarget)
        {
            base.RecordEvent(index, goals);
            _points += _goalBonus;
        }
    }

    public override string DisplayGoal()
    {
        string goal = $"{base.DisplayGoal()} -- Currently Completed: {_goalProgress}/{_goalTarget}";
        return goal;
    }

}