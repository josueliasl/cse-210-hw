using System;

class Program
{
    static void Main(string[] args)
    {
        string directoryPath = "EntriesLogs/";
        if(!Directory.Exists(directoryPath))
        {
            Directory.CreateDirectory(directoryPath);
        }

        Journal theJournal = new Journal();
        Entry anEntry = new Entry();
        anEntry.Display();

        Console.WriteLine("Hello earning 02 World!");
        string chosen;
        int choice = 0;
        while (choice != 5)
        {
        Console.WriteLine("Please select one of the Following choices: ");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.Write("What would you like to do? ");
        chosen = Console.ReadLine();
        int.TryParse(chosen, out choice);

        if(choice == 1)
        {
            PromptGenerator promptGenerator = new PromptGenerator();
            string _promptText = promptGenerator.GetRandomPrompt();

            Entry addEntry = new Entry();
            addEntry._promptText = _promptText;

            Console.WriteLine(_promptText);
            addEntry._entryText = Console.ReadLine();
            
            theJournal.AddEntry(addEntry);
        }
        else if (choice == 2){
            theJournal.Display();
        }
        else if (choice == 3){
           string[] keptFiles = Directory.GetFiles("EntriesLogs/", "*.txt");

           Console.WriteLine("Available journal files: ");
           for (int i = 0; i < keptFiles.Length; i++)
           {
               Console.WriteLine($"{i + 1}. {Path.GetFileNameWithoutExtension(keptFiles[i])}");
           }

           Console.WriteLine("Enter the file name you are looking for without the '.txt': ");
           string choices = Console.ReadLine();
           string chosenFile = Path.Combine("EntriesLogs/", choices + ".txt");
           if (!File.Exists(chosenFile))
           {
             Console.WriteLine($"File {choices} doesn't exist.");
             return;
           }

        theJournal.LoadFromFile(chosenFile, theJournal._entries);
        Console.WriteLine("");
        theJournal.Display();
        }
        else if (choice == 4){
            Console.Write("Name the File: ");
            string fname = Console.ReadLine();
            string path = Path.Combine(directoryPath, fname + ".txt");
            theJournal.SaveToFile(path);

        }
        else if (choice == 5){
            Console.Write("Your journal has been closed.");
        }
        else if (choice >= 6){
            Console.Write("Please select one valid choice: ");
        }
        }
    }
}