using System;
namespace FitnessCenter
{
    public class Swimming : Activity
    {
        private int _laps;
        private const int LapDistance = 50;

        public Swimming(DateTime date, int duration, int laps) : base("Swimming", date, duration)
        {
            _laps = laps;
        }

        public override int GetDistance()
        {
            return 0;
        }

        public override int GetSpeed()
        {
            return 0;
        }

        public override int GetPace()
        {
            return 0;
        }
        
    }
}