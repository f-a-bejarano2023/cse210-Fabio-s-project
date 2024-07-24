using System;
using System.Collections.Generic;
using System.IO;

class GoalManager
{
    public List<Goal> Goals { get; private set; }

    public GoalManager()
    {
        Goals = new List<Goal>();
    }

    public void SaveGoals(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var goal in Goals)
            {
                writer.WriteLine(goal.ToString());
            }
        }
    }

    public void LoadGoals(string filename)
    {
        Goals.Clear();
        using (StreamReader reader = new StreamReader(filename))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split(',');
                string type = parts[0];
                string data = string.Join(",", parts, 1, parts.Length - 1);

                Goal goal = Goal.FromString(type, data);
                Goals.Add(goal);
            }
        }
    }
}

