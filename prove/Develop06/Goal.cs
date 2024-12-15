using System;

namespace GoalTracker
{
    public abstract class Goal
    {
        protected string _shortName;
        protected string _description;
        public int _points;

        public Goal(string name, string description, int points)
        {
            _shortName = name;
            _description = description;
            _points = points;
        }

        public abstract void RecordEvent();
        public abstract bool IsComplete();
        public virtual string GetDetailsString()
        {
            return $"{_shortName}: {_description} {_points} points";
        }

        public virtual string GetDetailsSimple()
        {
            return $"{_shortName}";
        }

        public abstract string GetStringRepresentation();
    }
}