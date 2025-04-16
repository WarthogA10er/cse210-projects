public class Breathing:Activity
{
    public Breathing()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void Run()
    {
        //Console.Clear();
        DisplayStartingMessage();
        ShowSpinner(2);
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        DateTime currentTime = DateTime.Now;
        while(currentTime < futureTime)
        {
            
            Console.WriteLine("");
            Console.WriteLine("Breath in...");
            ShowCountDown(4);

            currentTime = DateTime.Now;
            if(currentTime > futureTime)
            {
                break;
            }

            Console.WriteLine("");
            Console.WriteLine("Hold...");
            ShowCountDown(4);
                        
            currentTime = DateTime.Now;
            if(currentTime > futureTime)
            {
                break;
            }

            Console.WriteLine("");
            Console.WriteLine("Breath out...");
            ShowCountDown(4);
                        
            currentTime = DateTime.Now;
            if(currentTime > futureTime)
            {
                break;
            }

            Console.WriteLine("");
            Console.WriteLine("Hold...");
            ShowCountDown(4);
                        
            currentTime = DateTime.Now;
            if(currentTime > futureTime)
            {
                break;
            }

        }
        DisplayEndingMessage();
        LogActivity();
    }
}