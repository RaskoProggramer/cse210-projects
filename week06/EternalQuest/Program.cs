using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the EternalQuest Project.");
        Console.WriteLine("");

        List<Goal> goals = new List<Goal>();
        GoalManager manager = new GoalManager(goals, 0);

        manager.Start();
    }
}