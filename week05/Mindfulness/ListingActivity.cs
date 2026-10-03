class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompt;
    public ListingActivity(string name, string description, int duration, int count, List<string> prompt) : base(name, description, duration)
    {
        _count = count;
        _prompt = prompt;
    }

   public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine(
            "List as many responses as you can to the following prompt:"
        );
        DateTime current = DateTime.Now;
        DateTime future = current.AddSeconds(GetDuration());

        while (DateTime.Now < future)
        {
            GetRandomPrompt();
            List<string> userList = GetListFromUser();
            _count = userList.Count;
        }
        Console.WriteLine();
        Console.WriteLine($"You listed {_count} items.");

        DisplayEndingMessage();
    }
    public void GetRandomPrompt()
    {
        if (_prompt.Count == 0)
        {
            Console.WriteLine("There are no more prompts available.");
            return;
        }
        Random random = new Random();
        string prompt = _prompt[random.Next(_prompt.Count)];
        Console.WriteLine(prompt);
        _prompt.Remove(prompt);
    }
    public List<string> GetListFromUser()
    {
        List<string> userList = new List<string>();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());

        string input = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(input))
        {
            userList.Add(input);
        }
        
        return userList;
    }
}