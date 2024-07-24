using System;

class ChecklistGoal : Goal
{
    public int TargetCount { get; set; }
    public int BonusPoints { get; set; }
    public int CurrentCount { get; set; }

    public ChecklistGoal(string name, string description, int targetCount, int pointsPerEvent, int bonusPoints)
        : base(name, description, pointsPerEvent)
    {
        TargetCount = targetCount;
        BonusPoints = bonusPoints;
        CurrentCount = 0;
    }

    public override void RecordEvent()
    {
        CurrentCount++;
        EarnedPoints += Points;
        CompletionDates.Add(DateTime.Now);
        Console.WriteLine($"Congratulations! You earned {Points} points.");

        if (CurrentCount >= TargetCount)
        {
            IsCompleted = true;
            EarnedPoints += BonusPoints;
            Console.WriteLine($"Bonus! You earned an additional {BonusPoints} points.");
        }
    }

    public override string GetGoalType()
    {
        return "ChecklistGoal";
    }

    public override string ToString()
    {
        string baseData = base.ToString();
        return $"{baseData},{TargetCount},{BonusPoints},{CurrentCount}";
    }

    public static ChecklistGoal FromString(string data)
    {
        string[] parts = data.Split('|');

        string name = parts[1];
        string description = parts[2];
        int pointsPerEvent = int.Parse(parts[3]);
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

        int targetCount = int.Parse(parts[7]);
        int bonusPoints = int.Parse(parts[8]);
        int currentCount = int.Parse(parts[9]);

        ChecklistGoal goal = new ChecklistGoal(name, description, targetCount, pointsPerEvent, bonusPoints)
        {
            IsCompleted = isCompleted,
            EarnedPoints = earnedPoints,
            CompletionDates = completionDates,
            CurrentCount = currentCount
        };

        return goal;
    }
}
