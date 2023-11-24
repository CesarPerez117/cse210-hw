using System;

public class GoalManager
// Important! This whole code I received from Jonathan. I understood very clear the function of every method and the use of the .trim()
// I just did minor changed base on convinence. This helped me becuase I was stuck creating a separated own class. 
// Also, this class is the result of the discussion we had before about "where to put and interact with the list?" and Mitch did something similar.
{
    private List<Goal> _goals;
    private int _selectedGoalIndex;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _selectedGoalIndex = 0;
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

        public void DisplayGoal()
    {
        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.Write($"{i + 1}. ");
            Console.Write(_goals[i].DisplayGoal());
            Console.WriteLine();
        }
        Console.WriteLine();
        
    }

    public void DisplayForRecordEvent()
    {   
        
        Console.WriteLine();
        Console.WriteLine("Select a goal from below:");
        for (int i = 0; i < _goals.Count; i++)
        {
            // uncompleted goals
            if (!_goals[i].IsComplete())
            {
                Console.WriteLine($"{i + 1}. {_goals[i].GetName()}");
            }
        }
        Console.Write("Which goal have you completed? ");
        _selectedGoalIndex = int.Parse(Console.ReadLine());
    }

    public void RecordEvent()
    {
        _goals[_selectedGoalIndex - 1].RecordEvent(_selectedGoalIndex, _goals);
    }

    
    public void SaveGoal(string fileName)
    {   
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (var goal in _goals)
            {
                goal.SaveGoal(writer);
            }
        }

    }

    public void LoadGoal(string fileName)
    {   
        _goals.Clear();
        string[] lines = File.ReadAllLines(fileName);
        foreach (var line in lines)
        {
            string[] goalData = line.Split('|');

            if (goalData.Length > 0)
            {
                Goal loadedGoal;

                switch (goalData[0].Trim())
                {
                    case "SimpleGoal":
                        loadedGoal = new SimpleGoal(goalData[1].Trim(), goalData[2].Trim(), int.Parse(goalData[3].Trim()));
                    break;
                    case "EternalGoal":
                        loadedGoal = new EternalGoal(goalData[1].Trim(), goalData[2].Trim(), int.Parse(goalData[3].Trim()));
                    break;
                    case "CheckListGoal":
                        CheckListGoal checkListGoal = new CheckListGoal(goalData[1].Trim(), goalData[2].Trim(), int.Parse(goalData[3].Trim()));
                        checkListGoal.LoadGoal(goalData);
                        loadedGoal = checkListGoal;
                        break;
                    default:
                        continue; 
                }

                _goals.Add(loadedGoal);
            
            }
        }
    }

    public void DisplayTotalPoints()
    {
        int totalPoints = 0;
        foreach (var goal in _goals)
        {
            totalPoints += goal.GetPoints();
        }
        Console.WriteLine($"You have {totalPoints} points.");
    }
}