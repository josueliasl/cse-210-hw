using System;
//I added a counting for everytime my classes are used, it's keeping track of them.
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello reflecting World 05!");
        string chosen;
        int choice = 0;

        int breathingCount = 0;
        int listingCount = 0;
        int reflectingCount = 0;
        while (choice != 4)
        {
        Console.WriteLine("Please select one of the Following choices: ");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Listing Activity");
        Console.WriteLine("3. Reflecting Activity");
        Console.WriteLine("4. Quit");
        Console.Write("What would you like to do? ");
        chosen = Console.ReadLine();
        int.TryParse(chosen, out choice);

        if(choice == 1)
        {
            breathingCount++;
            BreathingActivity breathingActivity = new BreathingActivity("Breathing", "This is for relaxation", 12);
            breathingActivity.Run();
        }

        else if (choice == 2){
            listingCount++;
            ListingActivity listingActivity = new ListingActivity("Listing", "Please answer the question", 25);
            listingActivity.Run();
        }

        else if (choice == 3){
            reflectingCount++;
            ReflectingActivity reflectingActivity = new ReflectingActivity("Personal Growth experience", "Please respond the question...", 45);
            reflectingActivity.Run();
        }
        else if (choice == 4){
            Console.WriteLine();
            Console.WriteLine("Your mindfulness Program is closed.");
        }
        else{
            Console.WriteLine();
            Console.WriteLine("Please select a valid option.");
        }
        
        Console.WriteLine($"You took the breathing activity {breathingCount} times");
        Console.WriteLine($"You took the listing activity {listingCount} times");
        Console.WriteLine($"You took the reflecting activity {reflectingCount} times");
        }
    }
}
