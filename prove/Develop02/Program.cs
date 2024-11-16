using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        Console.WriteLine("Hello! Please select one of the options below:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");

        int choice = -1;


        while (choice != 5)

        {
            Console.Write("What would you like to do?");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();

                PromptGenerator promptGenerator = new PromptGenerator();
                string promptQuestion = promptGenerator.GetRandomPrompt();
                Console.Write(promptQuestion);

                string response = Console.ReadLine();

                Entry newEntry = new Entry
                {
                    _date = dateText,
                    _promptText = promptQuestion,
                    _entryText = response
                };
                journal.AddEntry(newEntry);
            }
            else if (choice == 2)
            {
                Console.WriteLine("Journal Entries:");
                journal.DisplayAll();
            }
            else if (choice == 3)
            {
                Console.Write("Enter a filename to load the journal: ");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
            }
            else if (choice == 4)
            {
                Console.Write("Enter a filename to save the journal: ");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
            }
            else if (choice > 5)
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 5.");
            }
        }




    }
}