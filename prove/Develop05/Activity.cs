using System;

namespace MindfulnessApp
{
    public class Activity
    {
        protected string _name;
        protected string _description;
        protected int _duration;

        public Activity(string name, string description)
        {
            _name = name;
            _description = description;
        }

        public void DisplayStartingMessage()
        {
            Console.Clear();
            Console.WriteLine($"Welcome to the {_name}!");
            Console.WriteLine(_description);
            Console.WriteLine();
            Console.Write("Enter the duration of the activity in seconds: ");
            _duration = int.Parse(Console.ReadLine());

            Console.WriteLine("Get ready to begin...");
            ShowSpinner(3);
        }

        public void DisplayEndindMessage()
        {
            Console.WriteLine("Great job!");
            ShowSpinner(3);

            Console.WriteLine($"You have completed the {_name} for {_duration} seconds.");
            Console.WriteLine();
        }

        public void ShowSpinner(int seconds)
        {
            List<string> animation = new List<string> { "|", "/", "-", "\\" };
            int total = seconds * 10;

            for (int i = 0; i < total; i++)
            {
                Console.Write(animation[i % animation.Count]);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }

            Console.WriteLine();
        }

        public void ShowCountDown(int seconds)
        {
            for (int i = seconds; i > 0; i--)
            {
                Console.WriteLine($"{i}");
                Thread.Sleep(1000);
                Console.Write("\b\b");

            }
        }


    }
}