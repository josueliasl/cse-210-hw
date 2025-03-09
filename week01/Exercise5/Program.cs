using System;

class Program
{
    static void Main(string[] args)
    {
        WelcomeMessage();
        
        string userName = AskingForName();
        int userage = AskingForAge();

        int square = SquareNumber(userage);

        ShowResult(userName, square);
        }

        static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string AskingForName()
        {
            Console.Write("What is your name? ");
            string userName = Console.ReadLine();
            return userName;
        }
        static int AskingForAge()
        {
            Console.Write("What is your number? ");
            string userAge = Console.ReadLine();
            int number = int.Parse(userAge);
            return number;
        }
        static int SquareNumber(int number)
        {
            int square = number * number;
            return square;
        }
        static void ShowResult(string name, int square)
        {
            Console.WriteLine($"{name}, the square of your number is {square}");
        }
}