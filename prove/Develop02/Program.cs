// to Exceeding Requirements I decided to create a password to be able to open the entries, many people are afraid of writing a diary and someone reading something they shouldn't 
// and the password helps protect that, to create the password I had to research a little more than just the week's material to arrive in the result.

using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        int password = 0;
        string passwordFilePath = "password.txt";

        if (File.Exists(passwordFilePath))
        {
            string savedPassword = File.ReadAllText(passwordFilePath);
            if (int.TryParse(savedPassword, out int savedPasswordInt))
            {
                password = savedPasswordInt;
            }
        }




        Console.WriteLine("Hello! Please select one of the options below:");
        Console.WriteLine("0. Password");
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

            if (choice == 0)
            {
                Console.Write("Please set a password (numbers only): ");
                password = int.Parse(Console.ReadLine());
                File.WriteAllText(passwordFilePath, password.ToString());
                Console.WriteLine("Password has been set successfully!");
            }
            else if (choice == 2 || choice == 3 || choice == 4)
            {
                if (password == 0)
                {
                    Console.WriteLine("No password is set. Please set a password first.");
                    continue;
                }
                Console.Write("Enter password: ");
                int inputPassword = int.Parse(Console.ReadLine());

                if (inputPassword != password)
                {
                    Console.WriteLine("Wrong password.");
                    continue;

                }

            }

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