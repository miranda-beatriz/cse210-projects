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
            return -1;
        }

        public override int GetPace()
        {
            return 1;
        }
    }
}