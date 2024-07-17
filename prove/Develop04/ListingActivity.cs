

public class ListingActivity : MindfulnessActivity
{
    private static readonly List<string> Prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }
    protected override void RunActivity()
    {
        Random rand = new Random();
        string prompt = Prompts[rand.Next(Prompts.Count)];
        Console.WriteLine($"\n{prompt}");
        Thread.Sleep(3000);
        int startTime = Environment.TickCount;
        int count = 0;
        while ((Environment.TickCount - startTime) / 1000 < _duration)
        {
            Console.Write("List an item: ");
            Console.ReadLine();
            count++;
        }
        Console.WriteLine($"\nYou listed {count} items.");
    }
}