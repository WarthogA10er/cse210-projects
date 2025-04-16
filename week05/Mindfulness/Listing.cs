public class Listing:Activity
{
    private List<string> _prompts;
    public Listing()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _prompts = new List<string>{"Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"};
    }

    public void Run()
    {
        //Console.Clear();
        List<string> userList = new List<string>{};
        DisplayStartingMessage();
        GetRandomPrompt();
        Console.WriteLine("Ponder the prompt and prepare to write your thoughts.");
        ShowCountDown(5);
        
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        DateTime currentTime = DateTime.Now;
        while(currentTime < futureTime)
        {
            GetListFromUser(userList);
            currentTime = DateTime.Now;
        }
        ShowSpinner(3);
        Console.WriteLine($"You entered {(userList.Count)} thoughts.");
        
        DisplayEndingMessage();
        LogActivity();
    }

    public void GetRandomPrompt()
    {
        string randomPrompt = GetRandom(_prompts);
        Console.WriteLine(randomPrompt);
    }

    public void GetListFromUser(List<string> userList)
    {
        Console.Write(">");
        string userInput = Console.ReadLine();
        if(userInput != "")
        {
            userList.Add(userInput);
        }
    }
}