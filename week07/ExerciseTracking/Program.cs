using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");

       Running running = new Running(5, 30);
       string summaryRunning = running.GetSummary();
       Console.WriteLine(summaryRunning);

       Cycling cycling = new Cycling(15, 30);
       string summaryCycling = cycling.GetSummary();
       Console.WriteLine(summaryCycling);

       Swimming swimming = new Swimming(20, 15);
       string summarySwimming = swimming.GetSummary();
       Console.WriteLine(summarySwimming); 
    }
}