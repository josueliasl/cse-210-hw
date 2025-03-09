using System;
//Please scroll down to see core requirement 3 and make it work
class Program
{
    static void Main(string[] args)
    {
    // Core requirement 1
        //Console.Write("What is the magic number? ");
        //string number = Console.ReadLine();
        //int magicNumber = int.Parse(number);
        //Console.Write("What is your guess? ");
        //string guessNumber = Console.ReadLine();
        //int guess = int.Parse(guessNumber);
        // if (guess > magicNumber)
        //{
        //    Console.WriteLine("Lower");
        //}
        //else if (guess < magicNumber)
        //{
        //    Console.WriteLine("Higher");
        //}
        //else 
        //{
        //    Console.WriteLine("You guessed it");
        //}

    // Core requirement 2
        //Console.Write("What is the magic number? ");
        //string number = Console.ReadLine();
        //int magicNumber = int.Parse(number);
        //int guess = -1;
        //while (guess != magicNumber)
        //{
        //Console.Write("What is your guess? ");
        //string guessNumber = Console.ReadLine();
        //guess = int.Parse(guessNumber);
        //
        // if (guess > magicNumber)
        //{
        //    Console.WriteLine("Lower");
        //}
        //else if (guess < magicNumber)
        //{
        //    Console.WriteLine("Higher");
        //}
        //else 
        //{
        //    Console.WriteLine("You guessed it");
        //}

        //}

//Core Requirment 3        
    Random randomGenerator = new Random();
    int magicNumber = randomGenerator.Next(1, 101);
    int guess = -1;
    while (guess != magicNumber)
    {
        Console.Write("What is your guess? ");
        string guessNumber = Console.ReadLine();
        guess = int.Parse(guessNumber);
        
         if (guess > magicNumber)
        {
            Console.WriteLine("Lower");
        }
        else if (guess < magicNumber)
        {
            Console.WriteLine("Higher");
        }
        else 
        {
            Console.WriteLine("You guessed it");
        }

    }
    }
}