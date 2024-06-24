using System;

class Program
{
    static void Main(string[] args)
    {
        // Creating instances of  the Job class
        Job job1 = new Job();
        job1._jobPosition= "Software Engineer";
        job1._companyName = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._jobPosition = "Senior Developer";
        job2._companyName = "Google";
        job2._startYear = 2022;
        job2._endYear = 2024;

        // Creating an instance of he Resume class
        Resume resume = new Resume("John Doe");

        // Adding job information to the workExperience list
        resume.AddJob(job1);
        resume.AddJob(job2);

        // Displaying the resume
        resume.DisplayResume();

    }
}