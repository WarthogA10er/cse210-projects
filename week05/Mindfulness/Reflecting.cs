public class Reflecting:Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public Reflecting()
    {
        _name = "Reflecting Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        _prompts = new List<string>{"Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."};
        _questions = new List<string>{"Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"};
    }

    public void Run()
    {
        //Console.Clear();
        DisplayStartingMessage();
        DisplayPrompt();
        ShowSpinner(2);

        DisplayPrompt();
        Console.WriteLine("Please take some time to reflect on the prompt and prepare to answer some thought provoking questions.");

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        DateTime currentTime = DateTime.Now;

        ShowSpinner(5);

        while(currentTime < futureTime)
        {
            DisplayQuestions();
            ShowSpinner(3);
            currentTime = DateTime.Now;
        }

        DisplayEndingMessage();
        LogActivity();
    }

    public string GetRandomPrompt()
    {
        string randomPrompt = GetRandom(_prompts);
        return randomPrompt;
    }

    public string GetRandomQuestion()
    {
        string randomQuestion = GetRandom(_questions);
        return randomQuestion;
    }

    public void DisplayPrompt()
    {
        string randomPrompt = GetRandomPrompt();
        Console.WriteLine(randomPrompt);
    }

    public void DisplayQuestions()
    {
        string randomQuestion = GetRandomQuestion();
        Console.WriteLine(randomQuestion);
    }
}