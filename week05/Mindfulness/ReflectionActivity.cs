class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity(string name, string description, int duration) : base(name, description, duration)
    {
    }

     public void Run()
    {
        Console.Clear();
        DisplayStartingMessage();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            DisplayPrompt();
            Console.WriteLine("When you have something in mind, ponder each question.");
            Console.WriteLine();

            int count = 0;

            while (count < _questions.Count &&
                   DateTime.Now < endTime)
            {
                DisplayQuestions();

                count++;
            }
        }

        DisplayEndingMessage();
    }
    public string GetRandomPrompt()
    {
        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count)];
        return prompt;
    }
     public string GetRandomQuestion()
    {
        Random random = new Random();

        string question = _questions[random.Next(_questions.Count)];

        return question;
    }
    public void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($"--- {prompt} ---");
        ShowSpinner(3);
    }
    public void DisplayQuestions()
    {
        foreach (string question in _questions)
        {
            int duration = GetDuration() / _questions.Count;
            Console.Write($"> {question} ");
            ShowSpinner(duration);
            Console.WriteLine();
        }
    }
}
