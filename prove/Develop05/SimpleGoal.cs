using System;

class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points)
        : base(name, description, points) { }

    public override void RecordEvent()
    {
        if (!IsCompleted)
        {
            IsCompleted = true;
            EarnedPoints += Points;
            CompletionDates.Add(DateTime.Now);
            Console.WriteLine($"Congratulations! You earned {Points} points.");
        }
    }

    public override string GetGoalType()
    {
        return "SimpleGoal";
    }
}

