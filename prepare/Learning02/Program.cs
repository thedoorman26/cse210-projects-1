using System;

class Program
{
    static void Main(string[] args)
    {

        Job job1 = new Job();
            job1._jobTitle = "Software Engineer";
            job1._company = "Qualcom";
            job1._startYear = 2011;
            job1._endYear = 2015;

        
        Job job2 = new Job();
            job2._jobTitle = "Quality Manager";
            job2._company = "Facebook";
            job2._startYear = 2015;
            job2._endYear = 2019;


        Resume resume1 = new Resume();
            resume1._name = "Lenora Stevens";
            resume1._jobs.Add(job1);
            resume1._jobs.Add(job2);

        resume1.showResumeDetails();

        

    }
}