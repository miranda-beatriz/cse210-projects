using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture = new Scripture(reference, "Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths.");

        string userInput = "";

        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("Press Enter to continue or type 'Quit' to finish:");
        userInput = Console.ReadLine();

        while (userInput.ToLower() != "quit")
        {
            Console.Clear();

            scripture.HideRandomWords(1);
            Console.WriteLine(scripture.GetDisplayText());

            string lastHiddenWord = scripture.GetLastHiddenWord();


            if (!string.IsNullOrEmpty(lastHiddenWord))
            {
                Console.WriteLine("Which word disappeared?");
                string guess = Console.ReadLine();

                if (guess.Equals(lastHiddenWord, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Correct!");
                }
                else
                {
                    Console.WriteLine($"Incorrect. The Correct word was: {lastHiddenWord}");
                }
            }
            else
            {
                Console.WriteLine("No more words to hide!");
            }

            if (scripture.IsCompletelyHidden())
            {
                Environment.Exit(0);
            }

            Console.WriteLine("Press Enter to continue or type 'Quit' to finish:");
            userInput = Console.ReadLine();

        }




    }
}