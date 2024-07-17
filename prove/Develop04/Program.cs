using System;

public class Program
{
    private static Dictionary<string, MindfulnessActivity> activities = new Dictionary<string, MindfulnessActivity>
    {
        { "1", new BreathingActivity() },
        { "2", new ReflectionActivity() },
        { "3", new ListingActivity() }
    };

    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\nMindfulness Program");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");

            string choice = Console.ReadLine();
            if (choice == "4")
            {
                Console.WriteLine("Exiting the program. Have a mindful day!");
                break;
            }

            if (activities.ContainsKey(choice))
            {
                Console.Write("Enter the duration of the activity in seconds: ");
                int duration = int.Parse(Console.ReadLine());
                activities[choice].StartActivity(duration);
            }
            else
            {
                Console.WriteLine("Invalid choice. Please select a valid activity.");
            }
        }
    }
}