using System;
using System.Collections.Generic;

public class Resume
{
    // Member variables
    public string _candidateName;
    public List<Job> _workExperience;

    // Initializing name and jobs list
    public Resume(string name)
    {
        _candidateName= name;
        _workExperience = new List<Job>();
    }

    // Adding a job to the resume
    public void AddJob(Job job)
    {
        _workExperience.Add(job);
    }

    // Displaying the resume
    public void DisplayResume()
    {
        Console.WriteLine($"Name: {_candidateName}");
        Console.WriteLine("Jobs:");
        foreach (var job in _workExperience)
        {
            job.DisplayJobInfo();
        }
    }
}