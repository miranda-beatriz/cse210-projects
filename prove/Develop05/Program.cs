// I made a way that the random question and prompt didn´t repeat if had different question/ prompt avarible.
using System;

namespace MindfulnessApp
{
    using System;

    class Program
    {

        static void Main(string[] args)
        {
            bool running = true;
            while (running)
            {
                Console.WriteLine("Menu Options:");
                Console.WriteLine("1. Start Breathing Activity");
                Console.WriteLine("2. Start Reflection Activity");
                Console.WriteLine("3. Start Listing Activity");
                Console.WriteLine("4. Quit");
                Console.WriteLine("Select a choice from the menu: ");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.Run();

                }
                else if (choice == "2")
                {
                    ReflectionActivity reflection = new ReflectionActivity();
                    reflection.Run();
                }
                else if (choice == "3")
                {
                    ListingActivity listing = new ListingActivity();
                    listing.Run();
                }
                else if (choice == "4")
                {
                    Console.WriteLine("");
                    running = false;
                }
                else
                {
                    Console.WriteLine("Invalid option. Please try again.");
                    Console.ReadKey();
                }
            }

        }
    }
}