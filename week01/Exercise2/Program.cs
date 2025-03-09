using System;

class Program
{
    static void Main(string[] args)
    {
        // Core requirement 1
        //Console.Write("Please upgrade your grade percentage: ");
        //string gradePercentage = Console.ReadLine();
        //int percentage = int.Parse(gradePercentage);
        //if (percentage >= 90)
        //{
        //    Console.WriteLine("A");
        //}
        //else if (percentage >= 80)
        //{
        //    Console.WriteLine("B");
        //}
        //else if (percentage >= 70)
        //{
        //    Console.WriteLine("C");
        //}
        //else if (percentage >= 60)
        //{
        //    Console.WriteLine("D");
        //}
        //else if (percentage < 60)
        //{
        //    Console.WriteLine("F");
        //}

        // Core requirement 3
        Console.Write("Please upgrade your grade percentage: ");
        string gradePercentage3 = Console.ReadLine();
        int percentage3 = int.Parse(gradePercentage3);

        string letter = "";
        if (percentage3 >= 90)
        {
            letter = "A";
        }
        else if (percentage3 >= 80)
        {
            letter = "B";
        }
        else if (percentage3 >= 70)
        {
            letter = "C";
        }
        else if (percentage3 >= 60)
        {
            letter = "D";
        }
        else if (percentage3 < 60)
        {
            letter = "F";
        }
        Console.WriteLine($"Your grade is: {letter}");
        
        // Core requirement 2
        if (percentage3 >= 70)
        {
            Console.WriteLine("Congratulations, you passed the class!");

        }
        else
        {
            Console.WriteLine("Nice try, you were close, you will do it better next time!");
        }
    
        
    }

    
    
}