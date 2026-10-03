using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");
        Console.Clear();
        int choice = 0;
        while (choice != 4)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Breathing Activity");
            Console.WriteLine("  2. Reflection Activity");
            Console.WriteLine("  3. Listing Activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");

            choice = int.Parse(Console.ReadLine());
            if (choice == 4)
            {
                Console.WriteLine("Goodbye!");
                break;
            }

            

            Console.Clear();

            if (choice == 1)
            {
                BreathingActivity breathing = new BreathingActivity(
                    "Breathing Activity",
                    "This activity will help you relax by walking you through breathing in and out slowly.",
                    0
                );

                breathing.Run();
            }
            else if (choice == 2)
            {
                ReflectionActivity reflection = new ReflectionActivity(
                    "Reflection Activity",
                    "This activity will help you reflect on times in your life when you have shown strength and resilience.",
                    0
                );

                reflection.Run();
            }
            else if (choice == 3)
            {
                List<string> prompts = new List<string>
                {
                    "Who are people that you appreciate?",
                    "What are personal strengths of yours?",
                    "Who are people that you have helped this week?",
                    "When have you felt the Holy Ghost this month?",
                    "Who are some of your personal heroes?"
                };
                ListingActivity listing = new ListingActivity(
                    "Listing Activity",
                    "This activity will help you reflect on the good things in your life by having you list as many things as you can.",
                    0,
                    0,
                    prompts
                );

                listing.Run();
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }
            Console.Clear();
            Console.WriteLine("Press Enter to return to the menu.");
            Console.ReadLine();
        }
    }
}