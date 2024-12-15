using System;
namespace FitnessCenter
{
    public abstract class Activity
    {
        private string _type;
        private DateTime _date;
        private int _duration;

        public Activity(string type, DateTime date, int duration)
        {
            _type = type;
            _date = date;
            _duration = duration;
        }
        public int Duration
        {
            get => _duration;
            private set => _duration = value;
        }

        public abstract int GetDistance();

        public abstract int GetSpeed();

        public abstract int GetPace();

        public virtual string GetSummary()
        {
            return $"{_date:dd MMM yyyy} {_type} ({Duration} min): Distance: {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km";

        }
    }
}