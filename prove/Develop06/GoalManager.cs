using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalManager(int score)
    {
        _score = score;
    }

    public void Start()
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Eternal Quest Program! :D");

        int inputNumber = -1;

        while (inputNumber != 6)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal.");
            Console.WriteLine("2. List Goals.");
            Console.WriteLine("3. Save Goals.");
            Console.WriteLine("4. Load Goals.");
            Console.WriteLine("5. Record Event.");
            Console.WriteLine("6. Quit");

            Console.Write("Select a choice from the menu: ");
            string answer = Console.ReadLine();
            inputNumber = int.TryParse(answer, out var number) ? number : -1;

            if (inputNumber == 1)
            {
                CreateGoal();
            }
            else if (inputNumber == 2)
            {
                ListGoalDetails();
            }
            else if (inputNumber == 3)
            {
                SaveGoals();
            }
            else if (inputNumber == 4)
            {
                LoadGoals();
            }
            else if (inputNumber == 5)
            {
                RecordEvent();
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Score: {_score}");
        Console.WriteLine("Goals Count: " + _goals.Count);
    }

    public void ListGoalNames()
    {
        Console.WriteLine("Goals:");
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void ListGoalDetails()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetStringRepresentation());
        }
    }
    public void CreateGoal()
    {
        Console.WriteLine("Enter goal type (SimpleGoal, EternalGoal, ChecklistGoal):");
        string goalType = Console.ReadLine();

        Console.Write("Enter the name of the goal: ");
        string name = Console.ReadLine();

        Console.Write("Enter a description: ");
        string description = Console.ReadLine();

        Console.Write("Enter the points associated with this goal: ");
        string points = Console.ReadLine();

        if (goalType.Equals("SimpleGoal", StringComparison.OrdinalIgnoreCase))
        {
            SimpleGoal newGoal = new SimpleGoal(name, description, points);
            _goals.Add(newGoal);
        }
        else if (goalType.Equals("EternalGoal", StringComparison.OrdinalIgnoreCase))
        {
            EternalGoal newGoal = new EternalGoal(name, description, points);
            _goals.Add(newGoal);
        }
        else if (goalType.Equals("ChecklistGoal", StringComparison.OrdinalIgnoreCase))
        {
            Console.Write("Enter the target number of completions: ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("Enter the bonus points for completing the goal: ");
            int bonus = int.Parse(Console.ReadLine());

            ChecklistGoal newGoal = new ChecklistGoal(name, description, points, target, bonus);
            _goals.Add(newGoal);
        }
        else
        {
            Console.WriteLine("Invalid goal type.");
            return;
        }

        Console.WriteLine("Goal created successfully!");
    }


    public void RecordEvent()
    {
        Console.Write("Enter the name of the goal to record an event for: ");
        string goalName = Console.ReadLine();

        foreach (var goal in _goals)
        {
            if (goal.GetDetailsString().Contains(goalName))
            {
                goal.RecordEvent();
                _score += goal.GetPoints();
                Console.WriteLine($"Score updated! New score: {_score}");
                return;
            }
        }

        Console.WriteLine("Goal not found.");
    }

    public void SaveGoals()
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            foreach (var goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved successfully!");
    }

    public void LoadGoals()
    {
        if (!File.Exists("goals.txt"))
        {
            Console.WriteLine("No saved goals found.");
            return;
        }

        using (StreamReader reader = new StreamReader("goals.txt"))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                var goal = SimpleGoal.LoadFromString(line);
                _goals.Add(goal);
            }
        }

        Console.WriteLine("Goals loaded successfully!");
        
    }
}
