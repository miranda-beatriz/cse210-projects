using System;
namespace FitnessCenter
{
    public class Cycling : Activity
    {
        private int _speed;

        public int Speed
        {
            get => _speed;
            private set => _speed = value;
        }

        public Cycling(DateTime date, int duration, int speed)
            : base("Cycling", date, duration)
        {
            Speed = speed;
        }

        public override int GetDistance() => Speed * Duration / 60;

        public override int GetSpeed() => Speed;

        public override int GetPace() => 60 / Speed;
    }

}