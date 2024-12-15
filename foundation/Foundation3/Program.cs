using System;
namespace FitnessCenter
{
    class Program
    {
        static void Main(string[] args)
        {
            var activities = new List<Activity>
            {
                new Running(new DateTime(2024, 12, 13), 30, 5),
                new Cycling(new DateTime(2024, 12, 05), 60, 20),
                new Swimming(new DateTime(2024, 12, 23), 45, 40)
            };

            foreach (var activity in activities)
            {
                Console.WriteLine(activity.GetSummary());
            }

        }
    }
}
