using System;
using System.Collections.Generic;
using System.Threading;

public abstract class MindfulnessActivity
{
    protected string _name { get; set; }
    protected string _description { get; set; }
    protected int _duration { get; set; }

    public MindfulnessActivity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void StartActivity(int duration)
    {
        _duration = duration;
        Console.WriteLine($"\nStarting {_name} Activity");
        Console.WriteLine(_description);
        Thread.Sleep(2000);
        Console.WriteLine("Prepare to begin...");
        Thread.Sleep(3000);
        RunActivity();
        EndActivity();
    }

    protected abstract void RunActivity();

    protected void EndActivity()
    {
        Console.WriteLine($"\nGood job! You have completed the {_name} activity for {_duration} seconds.");
        Thread.Sleep(2000);
    }

    protected void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i}... ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}