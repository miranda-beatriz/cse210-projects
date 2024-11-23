using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("1 Nephi", 3, 7);
        Scripture scripture = new Scripture(reference, "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.");

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