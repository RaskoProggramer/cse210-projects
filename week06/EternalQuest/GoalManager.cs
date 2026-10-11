using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager(List<Goal> goals, int score)
    {
        _goals = goals;
        _score = score;
    }

    public int GetScore()
    {
        return _score;
    }

    public List<Goal> GetGoals()
    {
        return _goals;
    }
    
    public void Start()
    {
        bool running = true;

        while (running)
        {
            DisplayPlayerInfo();

            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Goal Event");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Quit");

            Console.Write("Select an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateGoal();
                    break;

                case "2":
                    ListGoalDetails();
                    break;

                case "3":
                    RecordEvent();
                    break;

                case "4":
                    SaveGoal();
                    break;

                case "5":
                    LoadGoal();
                    break;

                case "6":
                    running = false;
                    Console.WriteLine("Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }

            if (running)
            {
                Console.WriteLine("\nPress Enter to return to the menu.");
                Console.ReadLine();
            }
        }
    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"\nCurrent Score: {_score}");
    }
    public void ListGoalNames()
    {
        Console.WriteLine("\nYour Goals:");

        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals created yet.");
            return;
        }

        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetShortName()} ");
        }
    }
    public void ListGoalDetails()
    {
        Console.WriteLine("\nGoal Details:");

        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals created yet.");
            return;
        }

        int number = 0;
        foreach (Goal goal in _goals)
        {
            number++;
            if (goal is CheckListGoal checklist)
            {
                Console.WriteLine($"{number}. {checklist.GetDetailsString()}");
            }
            else
            {
                Console.WriteLine($"{number}. {goal.GetStringRepresentation()}");
            }
        }
    }
    public void CreateGoal()
    {
        Console.WriteLine("\nChoose a goal type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Your choice: ");

        string choice = Console.ReadLine();

        Console.Write("Enter the goal name: ");
        string name = Console.ReadLine();

        Console.Write("Enter the goal description: ");
        string description = Console.ReadLine();

        Console.Write("Enter the points: ");
        string points = Console.ReadLine();

        switch (choice)
        {
            case "1":
                _goals.Add(new SimpleGoal(name, description, points));
                break;

            case "2":
                _goals.Add(new EternalGoal(name, description, points));
                break;

            case "3":
                Console.Write("Enter the completion target: ");

                if (!int.TryParse(Console.ReadLine(), out int target)
                    || target <= 0)
                {
                    Console.WriteLine("Target must be a positive number.");
                    return;
                }

                Console.Write("Enter the bonus points: ");

                if (!int.TryParse(Console.ReadLine(), out int bonus)
                    || bonus < 0)
                {
                    Console.WriteLine("Bonus must be zero or greater.");
                    return;
                }

                _goals.Add(new CheckListGoal(
                    name, description, points, target, bonus));
                break;

            default:
                Console.WriteLine("Invalid goal type.");
                return;
        }

        Console.WriteLine("Goal created successfully!");
    }
        
    
public void RecordEvent()
{
    if (_goals.Count == 0)
    {
        Console.WriteLine("You have no goals to record.");
        return;
    }

    ListGoalDetails();

    Console.Write("Which goal did you accomplish? ");
    if (!int.TryParse(Console.ReadLine(), out int choice) ||
        choice < 1 || choice > _goals.Count)
    {
        Console.WriteLine("Invalid goal selection.");
        return;
    }

    Goal goal = _goals[choice - 1];

    // Prevent earning points again for a completed simple goal
    if (goal is SimpleGoal && goal.IsComplete())
    {
        Console.WriteLine("This goal has already been completed.");
        return;
    }

    int pointsEarned = goal.GetPointsValue();

    goal.RecordEvent();

    _score += pointsEarned;

    // Add the checklist bonus when its target is reached
    if (goal is CheckListGoal checklist &&
        checklist.IsComplete())
    {
        _score += checklist.GetBonus();
        Console.WriteLine(
            $"Congratulations! You earned a bonus of 🌟🌟{checklist.GetBonus()}🌟🌟 points!");
    }

    Console.WriteLine($"You earned 🌟{pointsEarned}🌟 points!");
    Console.WriteLine($"Your total score is now {_score}.");
}
    public void SaveGoal()
    {
        List<Dictionary<string, object>> savedGoals =
        new List<Dictionary<string, object>>();

        foreach (Goal goal in _goals)
        {
            Dictionary<string, object> item =
            new Dictionary<string, object>();

            item["Name"] = goal.GetShortName();
            item["Description"] = goal.GetDescription();
            item["Points"] = goal.GetPoints();

            if (goal is SimpleGoal simple)
            {
                item["Type"] = "Simple";
                item["IsComplete"] = simple.IsComplete();
            }
            else if (goal is EternalGoal)
            {
                item["Type"] = "Eternal";
            }
            else if (goal is CheckListGoal checklist)
            {
                item["Type"] = "Checklist";
                item["Target"] = checklist.GetTarget();
                item["Bonus"] = checklist.GetBonus();
                item["AmountCompleted"] =
                checklist.GetAmountCompleted();
            }

            savedGoals.Add(item);
        }

        var saveData = new Dictionary<string, object>
        {
            ["Score"] = _score,
            ["Goals"] = savedGoals
        };

        string json = JsonSerializer.Serialize(saveData, new JsonSerializerOptions { WriteIndented = true });

        File.WriteAllText("goals.json", json);

        Console.WriteLine("Goals saved successfully!");
    }
    
public void LoadGoal()
{
    // Check whether the file exists
    if (!File.Exists("goals.json"))
    {
        Console.WriteLine("No saved goals found.");
        return;
    }

    // Read the JSON file
    string json = File.ReadAllText("goals.json");

    // Read the JSON data
    using JsonDocument document = JsonDocument.Parse(json);

    JsonElement root = document.RootElement;

    // Restore the player's score
    _score = root.GetProperty("Score").GetInt32();

    // Create a new list for the loaded goals
    _goals = new List<Goal>();

    // Read each saved goal
    foreach (JsonElement item in root.GetProperty("Goals").EnumerateArray())
    {
        string name = item.GetProperty("Name").GetString() ?? "";
        string description = item.GetProperty("Description").GetString() ?? "";
        string points = item.GetProperty("Points").GetString() ?? "";
        string type = item.GetProperty("Type").GetString() ?? "";

        // Recreate the correct goal type
        switch (type)
        {
            case "Simple":
                bool isComplete =
                    item.GetProperty("IsComplete").GetBoolean();

                _goals.Add(new SimpleGoal(
                    name, description, points, isComplete));
                break;

            case "Eternal":
                _goals.Add(new EternalGoal(
                    name, description, points));
                break;

            case "Checklist":
                int target = item.GetProperty("Target").GetInt32();
                int bonus = item.GetProperty("Bonus").GetInt32();
                int amountCompleted =
                    item.GetProperty("AmountCompleted").GetInt32();

                _goals.Add(new CheckListGoal(
                    name, description, points,
                    target, bonus, amountCompleted));
                break;

            default:
                Console.WriteLine($"Unknown goal type: {type}");
                break;
        }
    }

    Console.WriteLine("Goals loaded successfully!");
    Console.WriteLine($"Current score: {_score}");
    Console.WriteLine($"Goals loaded: {_goals.Count}");
}
}