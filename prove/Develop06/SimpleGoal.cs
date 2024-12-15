using System;
using System.Collections.Concurrent;

namespace GoalTracker
{
    public class SimpleGoal : Goal
    {
        private bool _isComplete;

        public SimpleGoal(string name, string description, int points) : base(name, description, points)
        {
            _isComplete = false;
        }

        public override void RecordEvent()
        {
            _isComplete = true;
            Console.WriteLine($"Simple goal '{_shortName}' completed!");
        }
        public override bool IsComplete()
        {
            return _isComplete;
        }

        public override string GetDetailsString()
        {
            return $"[{(IsComplete() ? "X" : " ")}] {_shortName} ({_description}) ";

        }

        public override string GetStringRepresentation()
        {
            return $"Simple Goal:{_shortName},{_description},{_points},{IsComplete()}";

        }

    }
}