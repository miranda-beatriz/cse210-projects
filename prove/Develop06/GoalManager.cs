using System;

namespace GoalTracker
{
    public class GoalManager
    {
        private List<Goal> _goals;
        private int _score;

        public static void Main(string[] args)
        {
            GoalManager goalManager = new GoalManager();
            goalManager.Start();
        }

        public GoalManager()
        {
            _goals = new List<Goal>();
            _score = 0;
        }

        public void Start()
        {
            while (true)
            {
                DisplayPlayerInfo();

                Console.WriteLine("\nMenu Options:");
                Console.WriteLine("1. Create New Goal");
                Console.WriteLine("2. List Goals");
                Console.WriteLine("3. Save Goals");
                Console.WriteLine("4. Load Goals");
                Console.WriteLine("5. Record Event");
                Console.WriteLine("6. Quit");

                Console.Write("Select a choice from the menu: ");
                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }

                if (choice == 1)
                {
                    CreateGoal();
                }
                else if (choice == 2)
                {
                    ListGoalNames();
                }
                else if (choice == 3)
                {
                    SaveGoals();
                }
                else if (choice == 4)
                {
                    LoadGoals();
                }
                else if (choice == 5)
                {
                    RecordEvent();
                }
                else if (choice == 6)
                {
                    Console.WriteLine("Exiting program. Goodbye!");
                    return;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                }
            }
        }

        public void DisplayPlayerInfo()
        {
            Console.WriteLine($"\nYou have {_score} points.\n");
        }

        public void ListGoalNames()
        {
            if (_goals.Count == 0)
            {
                Console.WriteLine("No goals available.");
                return;
            }

            Console.WriteLine("\nGoals:");

            int counter = 1;

            foreach (var goal in _goals)
            {
                Console.WriteLine($"{counter}. {goal.GetDetailsString()}");
                counter++;
            }

        }

        public void ListGoalDetails()
        {
            foreach (var goal in _goals)
            {
                Console.WriteLine(goal.GetStringRepresentation());
            }
        }

        public void CreateGoal()
        {
            Console.WriteLine("\nThe types of Goals are:");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");
            Console.Write("Which type of goal would you like to create? ");

            string type = Console.ReadLine();
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            if (!int.TryParse(Console.ReadLine(), out int points))
            {
                Console.WriteLine("Invalid input. Points must be a number.");
                return;
            }

            if (type == "1")
            {
                _goals.Add(new SimpleGoal(name, description, points));
            }
            else if (type == "2")
            {
                _goals.Add(new EternalGoal(name, description, points));
            }
            else if (type == "3")
            {
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                if (!int.TryParse(Console.ReadLine(), out int target))
                {
                    Console.WriteLine("Invalid input. Target must be a number.");
                    return;
                }
                Console.Write("What is the bonus for accomplishing it that many times? ");
                if (!int.TryParse(Console.ReadLine(), out int bonus))
                {
                    Console.WriteLine("Invalid input. Bonus must be a number.");
                    return;
                }
                _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
            }
            else
            {
                Console.WriteLine("Invalid goal type.");
            }
        }

        public void RecordEvent()
        {
            if (_goals.Count == 0)
            {
                Console.WriteLine("No goals available to record an event.");
                return;
            }

            Console.WriteLine("\nSelect a goal to record an event:");
            for (int i = 0; i < _goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsSimple()}");
            }

            Console.Write("Enter the goal number: ");
            if (!int.TryParse(Console.ReadLine(), out int goalIndex) || goalIndex < 1 || goalIndex > _goals.Count)
            {
                Console.WriteLine("Invalid input. Please select a valid goal number.");
                return;
            }

            Goal selectedGoal = _goals[goalIndex - 1];
            selectedGoal.RecordEvent();

            if (selectedGoal is EternalGoal)
            {

                Console.WriteLine($"Congratulations! You have earned {selectedGoal._points} points. Bonus {selectedGoal._points}");
                _score += selectedGoal._points * 2;

            }
            else if (selectedGoal is ChecklistGoal)
            {
                if (selectedGoal is ChecklistGoal checklistGoal)
                {
                    if (checklistGoal.IsComplete() && checklistGoal._target == 3)
                    {
                        Console.WriteLine($"Congratulations! You have earned {checklistGoal._bonus + checklistGoal._points} points.");
                        _score += checklistGoal._bonus + checklistGoal._points;
                    }
                    else
                    {
                        Console.WriteLine($"Congratulations! You have earned {checklistGoal._points} points.");
                        _score += checklistGoal._points;
                    }
                }

            }
            else if (selectedGoal.IsComplete())
            {

                Console.WriteLine($"Congratulations! You have earned {selectedGoal._points} points.");
                _score += selectedGoal._points;

            }

        }
        public void SaveGoals()
        {

            Console.Write("Enter the file name to save goals: ");
            string fileName = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(fileName))
            {
                Console.WriteLine("Invalid file name. Please try again.");
                return;
            }

            if (!fileName.EndsWith(".txt"))
            {
                fileName += ".txt";
            }

            string filePath = fileName;

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine($"Score: {_score}");

                foreach (var goal in _goals)
                {
                    writer.WriteLine(goal.GetStringRepresentation());
                }
            }

            Console.WriteLine($"Goals saved successfully in '{fileName}'.");

        }
        public void LoadGoals()
        {

            Console.Write("Enter the file name to load goals: ");
            string fileName = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(fileName))
            {
                Console.WriteLine("Invalid file name. Please try again.");
                return;
            }

            if (!fileName.EndsWith(".txt"))
            {
                fileName += ".txt";
            }

            string filePath = fileName;

            if (!File.Exists(filePath))
            {
                Console.WriteLine("The file does not exist. Please try again.");
                return;
            }

            using (StreamReader reader = new StreamReader(filePath))
            {
                string scoreLine = reader.ReadLine();
                if (scoreLine != null && scoreLine.StartsWith("Score:"))
                {
                    string scoreString = scoreLine.Substring(6).Trim();
                    if (int.TryParse(scoreString, out int loadedScore))
                    {
                        _score = loadedScore; // Carregar o score
                        Console.WriteLine($"Loaded Score: {_score}");
                    }
                    else
                    {
                        Console.WriteLine("Invalid score in the file. Score could not be loaded.");
                    }
                }

                _goals.Clear();

                while (!reader.EndOfStream)
                {
                    string goalLine = reader.ReadLine();
                    if (!string.IsNullOrEmpty(goalLine))
                    {
                        Goal goal = ParseGoal(goalLine);
                        if (goal != null)
                        {
                            _goals.Add(goal);
                        }
                    }
                }
            }

            Console.WriteLine("Goals loaded successfully.");

        }

        private Goal ParseGoal(string goalLine)
        {
            string[] parts = goalLine.Split(',');
            if (parts.Length >= 3)
            {
                string name = parts[0];
                string description = parts[1];
                if (int.TryParse(parts[2], out int points))
                {
                    return new SimpleGoal(name, description, points);
                }
            }
            return null;
        }

    }
}