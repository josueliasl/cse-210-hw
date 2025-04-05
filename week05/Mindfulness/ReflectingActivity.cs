using System.Collections.Generic;
using System.Timers;

public class ReflectingActivity : Activity
{

    private List<string> _prompts;
    private List<string> _questions;
    public ReflectingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless.",
        };

        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?",
        };
    }
    public void Run()
    {
        DisplayStartingMessage();
        GetRandomQuestion();
        DisplayQuestions();
        string prompt = GetRandomPrompt();
        Console.WriteLine(prompt);
        
        List<string> userResponses = userPrompts();
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

    public string GetRandomQuestion()
    {
        Random randomquestion = new Random();
        int randomquestionIndex = randomquestion.Next(0, _questions.Count);
        return _questions[randomquestionIndex];
    }

    public void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine(prompt);
        
    }

    public void DisplayQuestions()
    {
        string question = GetRandomQuestion();
        Console.WriteLine(question);
        
    }
    public List<string> userPrompts()
    {
        List<string> userList = new List<string>();
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
            Console.WriteLine($"Time remaining: {Math.Max(remainingTime.Seconds, 0)} seconds.");
        }
        return userList;
    }
}