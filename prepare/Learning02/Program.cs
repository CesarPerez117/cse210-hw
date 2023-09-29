using System;

class Program
{
    static void Main(string[] args)
    {
        /*
        Class: Jobs
        Attributes:
        * _company : string
        * _jobTitle : string
        * _startYear : int
        * _endYear : int

        Methods:
        * Display() : void {Job Title (Company) StartYear-EndYear}
        ------------------------------------------------------------------
        Class: Resume
        Attributes:
        * _name : string
        * _jobs : List<Job>

        Methods:
        * Display() : void {Name (display each one of the jobs.)}
        -------------------------------------------------------------------
        */
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;
        /*job1.DisplayJob();*/

        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;
        /*job2.DisplayJob();*/

        Resume resume = new Resume();
        resume._name = "Allison Rose";
        resume._jobsList.Add(job1);
        resume._jobsList.Add(job2);
        resume.DisplayResume();

        
    }
}