using System;

namespace MindfulnessApp
{
    public class ReflectionActivity : Activity
    {
        private Queue<string> _availablePrompts;
        private Queue<string> _availableQuestions;
        public ReflectionActivity() : base("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
        {
            _availablePrompts = new Queue<string>(_prompts);
            _availableQuestions = new Queue<string>(_questions);
        }
        private List<string> _prompts = new List<string>
        {
            "Think of a time when you helped someone.",
            "Think of a time when you overcame a challenge.",
            "Think of a moment that made you feel grateful.",
            "Think of an accomplishment you are proud of.",
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        private List<string> _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "What did you learn from this experience?",
            "How did you feel during this experience?",
            "How has this experience impacted you today?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };


        public void Run()
        {
            DisplayStartingMessage();
            string prompt = GetNextPrompt();
            Console.WriteLine("\nConsider the following prompt:");
            Console.WriteLine($"\n--- {prompt} ---");
            Console.WriteLine("\nWhen you have something in mind, press Enter to continue.");
            Console.ReadLine();

            int elapsed = 0;
            while (elapsed < _duration)
            {
                string question = GetNextQuestion();
                Console.WriteLine(question);
                ShowSpinner(8);
                elapsed += 3;
            }

            DisplayEndindMessage();
        }

        public string GetRandomPrompt()
        {
            Random random = new Random();

            int index = random.Next(_prompts.Count);

            return _prompts[index];
        }

        public string GetRandomQuestion()
        {
            Random random = new Random();
            int index = random.Next(_questions.Count);

            return _questions[index];
        }

        public void DisplayPrompt()
        {
            string prompt = GetRandomPrompt();
            Console.WriteLine($"Prompt to reflection: {prompt}");
        }

        public void DisplayQuestions()
        {
            Console.WriteLine("Answer the questions below:");
            foreach (string question in _questions)
            {
                Console.WriteLine($"- {question}");
            }
        }
        private string GetNextPrompt()
        {
            if (_availablePrompts.Count == 0)
            {
                _availablePrompts = new Queue<string>(_prompts);
            }
            return _availablePrompts.Dequeue();
        }

        private string GetNextQuestion()
        {
            if (_availableQuestions.Count == 0)
            {
                _availableQuestions = new Queue<string>(_questions);
            }
            return _availableQuestions.Dequeue();
        }
    }
}