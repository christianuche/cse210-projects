using System;

public class Resume
{
     // Member variable for the person's name
    public string _PersonName;

    // Member variable for the list of jobs
    public List<Job> _Jobs = new List<Job>();  // Initializing to a new list

    public void Display()
    {
        Console.WriteLine($"Name: {_PersonName}");
        Console.WriteLine("Jobs: ");

        foreach (Job job in _Jobs)
        {
            job.DisplayJobDetails();
        }
    }
}