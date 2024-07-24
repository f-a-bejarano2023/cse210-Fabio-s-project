using System;

class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int pointsPerEvent)
        : base(name, description, pointsPerEvent) { }

    public override void RecordEvent()
    {
        EarnedPoints += Points;
        CompletionDates.Add(DateTime.Now);
        Console.WriteLine($"Congratulations! You earned {Points} points.");
    }

    public override string GetGoalType()
    {
        return "EternalGoal";
    }
}

