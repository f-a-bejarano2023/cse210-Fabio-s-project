using System;

public class Job
{
    // Member variables
    public string _companyName;
    public string _jobPosition;
    public int _startYear;
    public int _endYear;

    // Displaying job information
    public void DisplayJobInfo()
    {
        Console.WriteLine($"{_jobPosition} ({_companyName}) {_startYear}-{_endYear}");
    }
}