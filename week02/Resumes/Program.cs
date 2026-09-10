using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Auto Electrian";
        job1._company = "ZUPCO";
        job1._startYear = 2021;
        job1. _endYear =2023;

        Job job2 = new Job();
        job2._jobTitle = "Service Technician";
        job2._company = "Marce";
        job2._startYear = 2024;
        job2. _endYear =2025;

        Resume myResume = new Resume();
        myResume._name ="Joyce chzondo";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }   
}