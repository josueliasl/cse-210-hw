using System.Collections.Generic;

public class Activity
{
    private string _name;
    private string _description;
    protected int _duration;
    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"\n*** Welcome to the {_name} Activity ***\n");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"Expected duration: {_duration} seconds\n");
        Console.WriteLine($"Press Enter to begin...");
        Console.ReadLine();
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine($"\n*** Well done! ***\n");
        Console.WriteLine($"You have completed the {_name} Activity for {_duration} seconds.");
        Console.WriteLine("Great job! Take a moment to reflect before moving on.");
        int milliSeconds = _duration * 1000;
        Thread.Sleep(milliSeconds);
    }
    public void ShowSpinner(int seconds)
    {
        if (seconds <= 0) return;
        int totalTicks = seconds * 10;
        string[] spinner = new string[] {"|", "/", "-", "\\"};

        for (int i = 0; i <totalTicks; i ++)
        {
            Console.Write(spinner[i % spinner.Length]);
            Thread.Sleep(100);
            Console.Write("\b");
        }
        Console.Write(" \b");
    }

    public void ShowCountDown(int seconds)
    {
        if (seconds <= 0)
        {
            return;
        }
        for (int i = seconds; i> 0; i--)
        {
            Console.Write($"\r{i} ");
            Thread.Sleep(1000);
        }
        Console.Write("\r      ");
    }  
}