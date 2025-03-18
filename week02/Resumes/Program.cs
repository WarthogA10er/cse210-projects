using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Dennington Decor";
        job1._jobTitle = "Warehouse Hand";
        job1._startYear = "2020";
        job1._endYear = "2021";

        Job job2 = new Job();
        job2._company = "Blue Pearl";
        job2._jobTitle = "Veterinary Assistant";
        job2._startYear = "2022";
        job2._endYear = "2025";
    
        Resume resume1 = new Resume();
        resume1._name = "James Turner";

        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

       resume1.Display();
    }
}