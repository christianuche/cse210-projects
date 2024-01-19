using System;

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of Job named job1
        Job job1 = new Job();

        // Set the member variables for job1 using dot notation
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2024;
        job1._endYear = 2026;

        // Create a second instance of Job named job2
        Job job2 = new Job();

        // Set the member variables for job2 using dot notation
        job2._jobTitle = "Manager";
        job2._company = "Amazon";
        job2._startYear = 2026;
        job2._endYear = 2030;

        Resume  myResume = new Resume();
        myResume._PersonName = "Christian Uche";

        myResume._Jobs.Add(job1);
        myResume._Jobs.Add(job2);

        myResume.Display();
    }
}