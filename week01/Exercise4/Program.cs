using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {   
        List<int> numbers = new List<int>();
        int userGivenNumber = -1;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while(userGivenNumber != 0)
        {
        Console.Write("Enter Number: ");
        string numberAnswer = Console.ReadLine();
        userGivenNumber = int.Parse(numberAnswer);
        if (userGivenNumber != 0)
        {
            numbers.Add(userGivenNumber);
        }
        }

        // Core Requirement 1
        int addition = 0;
        foreach (int number in numbers)
        {
            addition += number;
        }
        Console.WriteLine($"The sum is: {addition}");

        // Core Requirement 2

        float average = ((float)addition) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        // Core Requirement 3
        int maximum = numbers[0];

        foreach (int number in numbers)
        {
            if(number > maximum)
            {
                maximum = number;
            }
        }
        Console.WriteLine($"The max is: {maximum}");
        
        
    }
}