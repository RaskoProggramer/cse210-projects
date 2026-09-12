class PromptGenerator
{
    public List<string> _prompts = new List<String>();

    public PromptGenerator()
    {
        _prompts.Add("Who was the most interesting person I interacted with today? ");
        _prompts.Add("What was the best part of my day? ");
        _prompts.Add("How did I see the hand of the Lord in my life today? ");
        _prompts.Add("What was the strongest emotion I felt today? ");
        _prompts.Add("If I had one thing I could do over today, what would it be? ");
        _prompts.Add("What am I grateful for today? ");
        _prompts.Add("What problem did you solve today? ");
        _prompts.Add("WHat was most challenging for you today? ");
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        return _prompts[random.Next(_prompts.Count)];
    }
}