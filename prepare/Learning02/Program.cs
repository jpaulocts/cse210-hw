using System;

class Program
{
    static void Main(string[] args)
    {
       Job job1 = new Job();
       job1._jobTitle = "Chemical Technic";
       job1._company = "CPRH";
       job1._startYear = 2008;
       job1._endYear = 2013;

       Job job2 = new Job();
       job2._jobTitle = "Chemical Operations Technic";
       job2._company = "Petrobras";
       job2._startYear = 2013;
       job2._endYear = 2018;

       Job job3 = new Job();
       job3._jobTitle = "Forensic Cientist";
       job3._company = "Civil Police";
       job3._startYear = 2018;
       job3._endYear = 2023;


       job1.Display();
       job2.Display();
       job3.Display();

       Resume myResume = new Resume();
       myResume._name = "Paulo Cauas";
       myResume._jobs.Add(job1);
       myResume._jobs.Add(job2);
       myResume._jobs.Add(job3);

       myResume.Display();

    }   
}