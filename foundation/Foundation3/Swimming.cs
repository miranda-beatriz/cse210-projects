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
            return (_laps * LapDistance) / 1000;
        }

        public override int GetSpeed()
        {
            return (GetDistance() * 60) / Duration;
        }

        public override int GetPace()
        {
            return Duration / GetDistance();
        }

    }
}