using System;

namespace MindfulnessApp
{

    public class BreathingActivity : Activity
    {
        public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.") { }


        public void Run()
        {
            DisplayStartingMessage();

            int breathingExercise = 0;

            while (breathingExercise < _duration)
            {

                Console.WriteLine("Breathe in...");
                ShowCountDown(3);
                Console.WriteLine("Breathe out...");
                ShowCountDown(3);
                breathingExercise += 6;
            }
            DisplayEndindMessage();

        }

    }
}

