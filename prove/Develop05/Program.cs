using System;
using System.Drawing;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        int choice = 0;
        int choice2 = 0;

        GoalManager manager = new GoalManager();
        do 
        {
            Console.WriteLine("Menu Options:\n1. Create New Goal\n2. List Goals\n3. Save Goals\n4. Load Goals\n5. Record Event\n6. Quit");
            Console.Write("Select a choice from the menu: ");

            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1: // create new goal
                    Console.WriteLine("The types of goals are:\n1. Simple Goal\n2. Eternal Goal\n3. CheckList Goal");
                    Console.Write("Wich type of goal would you like to create? ");

                    choice2 = int.Parse(Console.ReadLine());

                    switch (choice2)
                    {
                        case 1:
                            SimpleGoal simpleGoal = new SimpleGoal("-DefaultName-", "-DefaultDescription-", 0);
                            simpleGoal.DisplayGoalMessage();
                            manager.AddGoal(simpleGoal);
                            break;
                        
                        case 2:
                            EternalGoal eternalGoal = new EternalGoal("-DefaultName-", "-DefaultDescription-", 0);
                            eternalGoal.DisplayGoalMessage();
                            manager.AddGoal(eternalGoal);
                            break;
                        
                        case 3: 
                            CheckListGoal checkListGoal = new CheckListGoal("-DefaultName-", "-DefaultDescription-", 0);
                            checkListGoal.DisplayGoalMessage();
                            manager.AddGoal(checkListGoal);
                            break;
                    }
                    break;

                case 2: // list goals
                    manager.DisplayGoal();
                    break;

                case 3: // save goals
                    Console.Write("What is the name of the goal file? ");
                    string fileName = Console.ReadLine();
                    manager.SaveGoal(fileName);
                    Console.WriteLine("File Saved.");
                    break;

                case 4: // load goals
                    Console.Write("What is the filename for the goal file? ");
                    fileName = Console.ReadLine();
                    manager.LoadGoal(fileName);
                    Console.WriteLine("File Loaded.");
                    break;

                case 5: // record event 
                    manager.DisplayForRecordEvent();
                    manager.RecordEvent();
                    break;

                case 6: // quit
                    break;
    
            }

        } while (choice != 6);
    }
}