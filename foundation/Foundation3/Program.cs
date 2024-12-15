using System;
namespace FitnessCenter
{
    class Program
    {
        static void Main(string[] args)
        {
            var activities = new List<Activity>
            {
                new Running(new DateTime(2024, 13, 12), 30, 5),
                new Cycling(new DateTime(2024, 05, 12), 60, 20),
                new Swimming(new DateTime(2024, 23, 12), 45, 40)
            };

            foreach (var activity in activities)
            {
                Console.WriteLine(activity.GetSummary());
            }

        }
    }
}
