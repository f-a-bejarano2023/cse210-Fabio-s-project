using System;
using System.IO;

class Program
{
    static void Main()
    {
        GoalManager goalManager = new GoalManager();
        string filename;

        // Check if the goal_file_info.txt exists
        if (!File.Exists("goal_file_info.txt"))
        {
            // File info does not exist, prompt user to enter file info
            Console.Write("Enter the name of the file to save/load goals: ");
            string fileName = Console.ReadLine();
            Console.Write("Enter the directory to save the file: ");
            string directory = Console.ReadLine();

            // Combine directory and file name
            filename = Path.Combine(directory, fileName);

            try
            {
                // Ensure the directory exists
                Directory.CreateDirectory(Path.GetDirectoryName(filename));

                // Create the file
                using (FileStream fs = File.Create(filename))
                {
                    // File created
                }

                // Save the file path
                File.WriteAllText("goal_file_info.txt", filename);

                Console.WriteLine($"File created at {filename}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                return;
            }
        }
        else
        {
            // Read the existing file info
            filename = File.ReadAllText("goal_file_info.txt").Trim();
        }

        // Main program loop
        while (true)
        {
            Console.WriteLine("Welcome to the Eternal Quest Program!");
            Console.WriteLine("1. Create new goal");
            Console.WriteLine("2. List goals");
            Console.WriteLine("3. Save goals");
            Console.WriteLine("4. Load goals");
            Console.WriteLine("5. Record event");
            Console.WriteLine("6. Quit");
            Console.Write("Please select an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateNewGoal(goalManager);
                    break;
                case "2":
                    ListGoals(goalManager);
                    break;
                case "3":
                    goalManager.SaveGoals(filename);
                    Console.WriteLine("Goals saved successfully.");
                    break;
                case "4":
                    goalManager.LoadGoals(filename);
                    Console.WriteLine("Goals loaded successfully.");
                    break;
                case "5":
                    RecordEvent(goalManager);
                    break;
                case "6":
                    Console.WriteLine("Exiting program.");
                    return;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }
        }
    }

        static void CreateNewGoal(GoalManager goalManager)
    {
        Console.WriteLine("Select the type of goal to create:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Please select an option: ");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                CreateSimpleGoal(goalManager);
                break;
            case "2":
                CreateEternalGoal(goalManager);
                break;
            case "3":
                CreateChecklistGoal(goalManager);
                break;
            default:
                Console.WriteLine("Invalid choice, please try again.");
                break;
        }
    }

    static void CreateSimpleGoal(GoalManager goalManager)
    {
        Console.Write("Which goal do you want to set? ");
        string name = Console.ReadLine();
        Console.Write("Give a brief description of it: ");
        string description = Console.ReadLine();
        Console.Write("How many points will you earn? ");
        int points = int.Parse(Console.ReadLine());

        goalManager.Goals.Add(new SimpleGoal(name, description, points));
        Console.WriteLine("Simple Goal created successfully.");
    }

    static void CreateEternalGoal(GoalManager goalManager)
    {
        Console.Write("Which goal do you want to set? ");
        string name = Console.ReadLine();
        Console.Write("Give a brief description of it: ");
        string description = Console.ReadLine();
        Console.Write("How many points will you earn each time? ");
        int pointsPerEvent = int.Parse(Console.ReadLine());

        goalManager.Goals.Add(new EternalGoal(name, description, pointsPerEvent));
        Console.WriteLine("Eternal Goal created successfully.");
    }

    static void CreateChecklistGoal(GoalManager goalManager)
    {
        Console.Write("Which goal do you want to set? ");
        string name = Console.ReadLine();
        Console.Write("Give a brief description of it: ");
        string description = Console.ReadLine();
        Console.Write("How many points will you earn each time? ");
        int pointsPerEvent = int.Parse(Console.ReadLine());
        Console.Write("Set a number of times you will accomplish it for a bonus: ");
        int targetCount = int.Parse(Console.ReadLine());
        Console.Write("What will the bonus be when accomplished the number of times set? ");
        int bonusPoints = int.Parse(Console.ReadLine());

        goalManager.Goals.Add(new ChecklistGoal(name, description, targetCount, pointsPerEvent, bonusPoints));
        Console.WriteLine("Checklist Goal created successfully.");
    }

    static void ListGoals(GoalManager goalManager)
    {
        Console.WriteLine("Current goals:");
        foreach (var goal in goalManager.Goals)
        {
            goal.DisplayGoal();
        }
    }

    static void RecordEvent(GoalManager goalManager)
    {
        Console.WriteLine("Select the goal to record an event for:");
        for (int i = 0; i < goalManager.Goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goalManager.Goals[i].Name}");
        }

        Console.Write("Enter the number of the goal: ");
        int goalIndex = int.Parse(Console.ReadLine()) - 1;

        if (goalIndex >= 0 && goalIndex < goalManager.Goals.Count)
        {
            goalManager.Goals[goalIndex].RecordEvent();
            Console.WriteLine("Event recorded successfully.");
        }
        else
        {
            Console.WriteLine("Invalid selection, please try again.");
        }
    }
}
