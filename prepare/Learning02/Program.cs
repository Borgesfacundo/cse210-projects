using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();

        job1._company = "Amazon";
        job1._jobTitle = "Administrative Assistant";
        job1._startYear = 2019;
        job1._endYear = 2020;


        Job job2 = new Job();

        job2._company = "Google";
        job2._jobTitle = "Front-End Developer";
        job2._startYear = 2020;
        job2._endYear = 2023;

        Resume resume = new Resume();
        resume._name = "Michael Jackson";

        resume._listOfJobs.Add(job1);
        resume._listOfJobs.Add(job2);


        resume.Display();
    }
}