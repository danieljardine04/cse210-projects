using System;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");
        Job job1 = new Job();
        Job job2 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear= 1994;
        job1._endYear = 2020;
        job2._startYear = 2022;
        job2._endYear = 2024;
        job2._company = "Apple";
        job2._jobTitle = "Manager";
        
        job1.DisplayMessage(job1);
        job2.DisplayMessage(job2);

        Resume resume = new Resume();
        resume._name = "Daniel Jardine";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.DisplayMessage();

        
        
    }
   
}