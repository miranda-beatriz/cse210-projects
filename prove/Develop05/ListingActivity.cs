using System;

namespace MindfulnessApp
{

    public class ListingActivity : Activity
    {
        private int _count;

        private List<string> _prompts = new List<string>
        {
            "List people you appreciate.",
            "List things that make you happy.",
            "List places you love to visit.",
            "List your greatest achievements."
        };

        public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.") { }



        public void Run()
        {
            DisplayStartingMessage();
            string prompt = GetRandomPrompt();
            Console.WriteLine($"Prompt: {prompt}");
            Console.WriteLine("You have limited time to write as many items as possible. Let's begin!");
            ShowCountDown(3);

            List<string> userItems = GetListFromUser();

            _count = userItems.Count;

            Console.WriteLine($"You listed {_count} items:");

            foreach (string item in userItems)
            {
                Console.WriteLine($"- {item}");
            }

            DisplayEndindMessage();
        }

        public string GetRandomPrompt()
        {
            Random random = new Random();
            int index = random.Next(_prompts.Count);
            return _prompts[index];
        }

        public List<string> GetListFromUser()
        {
            List<string> items = new List<string>();
            DateTime endTime = DateTime.Now.AddSeconds(_duration);

            Console.WriteLine("Start listing items:");
            while (DateTime.Now < endTime)
            {
                string input = Console.ReadLine();
                if (!string.IsNullOrEmpty(input))
                {
                    items.Add(input);
                }
            }

            return items;
        }

    }
}