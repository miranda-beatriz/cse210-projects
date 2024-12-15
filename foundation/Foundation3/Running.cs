using System;
namespace FitnessCenter
{
    public class Running : Activity
    {
        private int _distance;

        public Running(DateTime date, int duration, int distance) : base("Running", date, duration)
        {
            _distance = distance;
        }

        public override int GetDistance()
        {
            return _distance;
        }

        public override int GetSpeed()
        {
            return (_distance * 60) / Duration;
        }

        public override int GetPace()
        {
            return Duration / _distance;
        }
    }
}