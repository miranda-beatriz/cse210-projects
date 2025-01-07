using System;

namespace GoalTracker
{
    public class EternalGoal : Goal
    {
        protected bool _isComplete;
        public EternalGoal(string name, string description, int points) : base(name, description, points)
        {
            _isComplete = false;
        }
        public override void RecordEvent()
        {

            _isComplete = true;
            Console.WriteLine($"Eternal Goal '{_shortName}' completed!");

        }
        public override bool IsComplete()
        {
            return false;
        }
        public override string GetDetailsString()
        {
            return $"[{(IsComplete() ? "X" : " ")}] {_shortName} ({_description})";

        }
        public override string GetStringRepresentation()
        {
            return $"Eternal Goal:{_shortName},{_description},{_points}";

        }
    }
}