using System.Collections.Generic;
public class PromptGenerator
{
    public List<string> Prompts;

    public PromptGenerator()
    {
        Prompts = new List<string>()
        { 
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        };
    }
    public string GetRandomPrompt()
    {
        Random randomPrompt = new Random();
        int randomPromptIndex = randomPrompt.Next(0, Prompts.Count);
        return Prompts[randomPromptIndex];
        
    }
}