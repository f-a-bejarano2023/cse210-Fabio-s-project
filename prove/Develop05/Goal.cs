using System;
using System.Collections.Generic;

abstract class Goal
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int Points { get; set; }
    public bool IsCompleted { get; set; }
    public int EarnedPoints { get; set; }
    public List<DateTime> CompletionDates { get; set; }

    public Goal(string name, string description, int points)
    {
        Name = name;
        Description = description;
        Points = points;
        IsCompleted = false;
        EarnedPoints = 0;
        CompletionDates = new List<DateTime>();
    }

    public abstract void RecordEvent();
    public abstract string GetGoalType();

    public virtual void DisplayGoal()
    {
        string status = IsCompleted ? "[x]" : "[ ]";
        Console.WriteLine($"{status} {Name}: {Description} - Points: {EarnedPoints} - Completed: {IsCompleted}");
    }

    public override string ToString()
    {
        string completionDates = string.Join(",", CompletionDates);
        return $"{GetGoalType()},{Name},{Description},{Points},{IsCompleted},{EarnedPoints},{completionDates}";
    }

    public static Goal FromString(string type, string data)
    {
        string[] parts = data.Split('|');

        string name = parts[1];
        string description = parts[2];
        int points = int.Parse(parts[3]);
        bool isCompleted = bool.Parse(parts[4]);
        int earnedPoints = int.Parse(parts[5]);
        List<DateTime> completionDates = new List<DateTime>();

        if (parts.Length > 6 && !string.IsNullOrEmpty(parts[6]))
        {
            foreach (var date in parts[6].Split('|'))
            {
                completionDates.Add(DateTime.Parse(date));
            }
        }

        Goal goal = null;

        switch (type)
        {
            case "SimpleGoal":
                goal = new SimpleGoal(name, description, points);
                break;
            case "EternalGoal":
                goal = new EternalGoal(name, description, points);
                break;
            case "ChecklistGoal":
                int targetCount = int.Parse(parts[7]);
                int bonusPoints = int.Parse(parts[8]);
                goal = new ChecklistGoal(name, description, targetCount, points, bonusPoints);
                break;
        }

        if (goal != null)
        {
            goal.IsCompleted = isCompleted;
            goal.EarnedPoints = earnedPoints;
            goal.CompletionDates = completionDates;
        }

        return goal;
    }
}


