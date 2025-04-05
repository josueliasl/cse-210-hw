using System.Collections.Generic;
using System.Timers;

public class ListingActivity : Activity
{
    private List<string> _prompts;
    public ListingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?",
        };
    }
    public void Run()
    {
        DisplayStartingMessage();

        string prompt = GetRandomPrompt();
        Console.WriteLine(prompt);
        
        List<string> userResponses = GetListFromUser();
        Console.WriteLine("Your responses: "); 
        foreach (var response in userResponses)
        {
            Console.WriteLine($"- {response}");
        }

        DisplayEndingMessage();
    }
    public string GetRandomPrompt()
    {
        Random randomPrompt = new Random();
        int randomPromptIndex = randomPrompt.Next(0, _prompts.Count);
        return _prompts[randomPromptIndex];
    }

    public List<string> GetListFromUser()
    {
        List<string> userList = new List<string>();
        Console.WriteLine("Start listing your answers (type done when done)");
        DateTime startTime = DateTime.Now;
        int timerduration = _duration;
        DateTime endTime = startTime.AddSeconds(timerduration);

        while (DateTime.Now < endTime)
        {
            string input = Console.ReadLine();

            if (input.ToLower() == "done")
            {
                break;
            }

            userList.Add(input);

            TimeSpan remainingTime = endTime - DateTime.Now;
            Console.WriteLine($"Time remaining: {remainingTime.Seconds} seconds.");
        }

        Console.WriteLine("Time's up or you are done");
        return userList;
    }

}