using System;
using System.Collections.Generic;

public class GoalManager
{
    private List<Goal> goals = new List<Goal>();

    public void CreateNewGoal(int type)
    {
        Console.Write("Enter the name of your goal: ");
        string name = Console.ReadLine();
        Console.Write("Enter a short description: ");
        string description = Console.ReadLine();
        Console.Write("Enter the amount of points associated: ");
        int points = Convert.ToInt32(Console.ReadLine());

        switch (type)
        {
            case 1:
                goals.Add(new SimpleGoal(name, description, points));
                break;
            case 2:
                goals.Add(new EternalGoal(name, description, points));
                break;
            case 3:
                Console.Write("Enter the number of times needed for bonus: ");
                int targetTimes = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the bonus points: ");
                int bonusPoints = Convert.ToInt32(Console.ReadLine());
                goals.Add(new ChecklistGoal(name, description, points, targetTimes, bonusPoints));
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                break;
        }
    }

    public void ListGoals()
    {
        foreach (var goal in goals)
        {
            Console.WriteLine(goal.DisplayProgress());
        }
    }

    // Implement SaveGoals and LoadGoals methods for saving and loading goals from files
    // Implement RecordGoal method for recording progress of goals
}