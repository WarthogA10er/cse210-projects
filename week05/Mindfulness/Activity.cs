using System.Runtime.CompilerServices;
using System.Security.Principal;
using System.IO;
public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    protected Activity()
    {
        Console.WriteLine("Please enter how many seconds you would like to spend on this activity:");
        string duration = Console.ReadLine();
        int durationInt = int.Parse(duration);
        _duration = durationInt;
    }

    protected void DisplayStartingMessage()
    {
        Console.WriteLine(_description);
    }

    protected void DisplayEndingMessage()
    {
        //Console.Clear();
        Console.WriteLine("");
        Console.WriteLine("Well Done!");
        ShowSpinner(2);
        Console.WriteLine($"You have completed {_duration} more seconds of the {_name}.");
        Console.WriteLine("Press 'enter' when you are ready to continue.");
        Console.ReadLine();
    }

    protected void ShowSpinner(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(seconds);
        DateTime currentTime = DateTime.Now;
        while(currentTime < futureTime)
        {
            currentTime = DateTime.Now;
            Console.Write("|");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(500);
            Console.Write("\b \b");
        }
    }   

    protected void ShowCountDown(int seconds)
    {
        for(int i = seconds; i > -1; i--)
        {
            Console.Write("\b \b");
            Console.Write($"{(i)}");
            Thread.Sleep(1000);
        }
    }

    protected string GetRandom(List<string> list)
    {
        Random rnd = new Random();
        string randomString = list[rnd.Next(list.Count)];
        return randomString;
    }

    public void LogActivity()
    {
        using (StreamWriter writer = new StreamWriter("Log.txt", append: true))
        {
            writer.WriteLine($"{_name}:{_duration}");
        }
    }
}