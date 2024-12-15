// For the eternal goal I double the points each time the user complete the goal to motivate the user
using System;

namespace GoalTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            GoalManager goalManager = new GoalManager();
            goalManager.Start();
        }
    }
}
