using System.ComponentModel.Design;
using System.Net.Quic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

public class GoalManager
{
    private List<Goal> _goals;
    public int _score;

    public GoalManager()
    {
        _score = 0;
        _goals = new List<Goal>{};
    }

    public void Start()
    {
        while(true)
        {
            //Console.Clear();
            DisplayPlayerInfo();
            Console.WriteLine("EternalQuest Menu:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. Record Event");
            Console.WriteLine("3. Show Goal Details");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Quit");
            string menu = Console.ReadLine();

            if(menu == "1")
            {
                CreateGoal();
            }

            else if(menu == "2")
            {
                RecordEvent();
            }

            else if(menu == "3")
            {
                ListGoalDetails();
            }

            else if(menu == "4")
            {
                SaveGoals();
            }

            else if(menu == "5")
            {
                LoadGoals();
            }

            else if(menu == "6")
            {
                break;
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine(_score);
        ListGoalNames();
    }

    public void ListGoalNames()
    {
        if (_goals.Count() == 0)
        {
            Console.WriteLine("There are no goals.");
        }
        
        foreach(Goal goal in _goals)
        {
            string detail = goal.GetDetailsString();
            Console.WriteLine(detail);
        }
    }

    public void ListGoalDetails()
    {
        if (_goals.Count() == 0)
        {
            Console.WriteLine("There are no goals.");
        }

        foreach(Goal goal in _goals)
        {
            string detail = goal.GetDetailsString();
            Console.WriteLine(detail);
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("What kind of goal would you like to make?");
        Console.WriteLine("1. Simple");
        Console.WriteLine("2. Checklist");
        Console.WriteLine("3. Eternal");
        Console.WriteLine("4. Stop a Habit");
        string menu = Console.ReadLine();

        if(menu == "1")
        {
            Console.WriteLine("Please enter a name for your simple goal.");
            string name = Console.ReadLine();
            Console.WriteLine("Please enter a short description for your simple goal.");
            string description = Console.ReadLine();
            Console.WriteLine("Please enter the amount of points you should gain when you complete this goal.");
            string pointsString = Console.ReadLine();
            int points = int.Parse(pointsString);
            SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
            _goals.Add(simpleGoal);
        }

        else if(menu == "2")
        {
            Console.WriteLine("Please enter a name for your checklist goal.");
            string name = Console.ReadLine();
            Console.WriteLine("Please enter a short description for your checklist goal.");
            string description = Console.ReadLine();
            Console.WriteLine("Please enter the amount of points you should gain each time you complete a part of this goal.");
            string pointsString = Console.ReadLine();
            int points = int.Parse(pointsString);
            SimpleGoal newGoal = new SimpleGoal(name, description, points);
            Console.WriteLine("Please enter the total number of times you would like to accomplish this goal.");
            string targetString = Console.ReadLine();
            int target = int.Parse(targetString);
            Console.WriteLine("Please enter the number of bonus points you should receive after completing total number of this goal.");
            string bonusString = Console.ReadLine();
            int bonus = int.Parse(bonusString);

            ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, target, bonus);
            _goals.Add(checklistGoal);
        }

        else if (menu == "3")
        {
            Console.WriteLine("Please enter a name for your eternal goal.");
            string name = Console.ReadLine();
            Console.WriteLine("Please enter a short description for your eternal goal.");
            string description = Console.ReadLine();
            Console.WriteLine("Please enter the amount of points you should gain when you complete a step in this goal.");
            string pointsString = Console.ReadLine();
            int points = int.Parse(pointsString);
            EternalGoal eternalGoal = new EternalGoal(name, description, points);
            _goals.Add(eternalGoal);
        }

        else if (menu == "3")
        {
            Console.WriteLine("Please enter the name of the habit you would like to stop.");
            string name = Console.ReadLine();
            Console.WriteLine("Please enter a short description of the habit.");
            string description = Console.ReadLine();
            Console.WriteLine("Please enter the amount of points you should lose when you continue this habit.");
            string pointsString = Console.ReadLine();
            int points = int.Parse(pointsString);
            StopHabit stopHabit = new StopHabit(name, description, points);
            _goals.Add(stopHabit);
        }
    }

    public void CreateGoal(string goal, string info)
    {
        if(goal == "SimpleGoal")
        {
        string[] parts = info.Split('|');

        string isComplete = parts[0];
        string shortName = parts[1];
        string description = parts[2];
        string pointsString = parts[3];
        int points = int.Parse(pointsString);

        SimpleGoal simpleGoal = new SimpleGoal(isComplete, shortName, description, points);
        _goals.Add(simpleGoal);
        }

        else if (goal == "EternalGoal")
        {
        string[] parts = info.Split('|');

        string shortName = parts[0];
        string description = parts[1];
        string pointsString = parts[2];
        int points = int.Parse(pointsString);

        EternalGoal eternalGoal = new EternalGoal(shortName, description, points);
        _goals.Add(eternalGoal);
        }

        else if (goal == "ChecklistGoal")
        {
            string[] parts = info.Split('|');

        string isComplete = parts[0];
        string shortName = parts[1];
        string description = parts[2];
        string pointsString = parts[3];
            int points = int.Parse(pointsString);
        string amountCompletedString = parts[4];
            int amountCompleted = int.Parse(amountCompletedString);
        string targetString = parts[5];
            int target = int.Parse(targetString);
        string bonusString = parts[6];
            int bonus = int.Parse(amountCompletedString);

        ChecklistGoal checklistGoal = new ChecklistGoal(isComplete, shortName, description, points, amountCompleted, target, bonus);
        _goals.Add(checklistGoal);
        }

        else if(goal == "StopHabit")
        {
        string[] parts = info.Split('|');

        string shortName = parts[0];
        string description = parts[1];
        string pointsString = parts[2];
        int points = int.Parse(pointsString);

        StopHabit stopHabit = new StopHabit(shortName, description, points);
        _goals.Add(stopHabit); 
        }
    }

    public void RecordEvent()
    {
        Console.WriteLine("What goal are you recording?");
        for( int i = 0; i < _goals.Count(); i++)
        {
            Goal goal = _goals[i];

            Console.WriteLine($"{(i+1)}. {goal.GetDetailsString()}");
        }

        string choice = Console.ReadLine();
        int choiceInt = int.Parse(choice);
        int index = choiceInt - 1;
        Goal chosenGoal = _goals[index];
        int points = chosenGoal.RecordEvent();
        _score += points;
    }

    public void SaveGoals()
    {
        Console.WriteLine("What file would you like to save to?");
        string filename = Console.ReadLine();
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                string representation = goal.GetStringRepresentation();
                writer.WriteLine(representation);
            }
        }
    }

    public void LoadGoals()
    {
        Console.WriteLine("What file would you like to load from?");
        string filename = Console.ReadLine();
        using (StreamReader reader = new StreamReader(filename))
        {
            Console.WriteLine(filename);
            string line;
            string scoreString = reader.ReadLine();
            _score = int.Parse(scoreString);
            Console.WriteLine(_score);
            while ((line = reader.ReadLine()) != null)
            {
                Console.WriteLine(line);
                string[] parts = line.Split(':');
                string goal = parts[0];
                string info = parts[1];
                CreateGoal(goal, info);
            }
        }
    }
}