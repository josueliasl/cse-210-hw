using System.Collections.Generic;

public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    {
    }
    public void Run()
    {
        DisplayStartingMessage();
        int inhaleTime = 4;
        int holdTime = 4;
        int exhaleTime = 4;
        int cycleDuration = inhaleTime + holdTime + exhaleTime;
        int numCycles = _duration / cycleDuration;

        for (int i = 0; i <numCycles; i++)
        {
            Console.WriteLine("Inhale...");
            ShowCountDown(inhaleTime);

            Console.WriteLine("Hold...");
            ShowCountDown(holdTime);

            Console.WriteLine("Exhale...");
            ShowCountDown(exhaleTime);
        }

        DisplayEndingMessage();
    }
}