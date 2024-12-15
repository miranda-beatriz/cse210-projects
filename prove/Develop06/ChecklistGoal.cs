using System;

namespace GoalTracker
{
   public class ChecklistGoal : Goal
   {
      private int _amountCompleted;
      public int _target;
      public int _bonus;

      public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
      {
         _amountCompleted = 0;
         _target = target;
         _bonus = bonus;
      }

      public override void RecordEvent()
      {
         _amountCompleted++;
         Console.WriteLine($"Progress made on checklist goal '{_shortName}'. {_amountCompleted}/{_target} completed.");

         if (IsComplete())
         {
            Console.WriteLine($"Checklist goal '{_shortName}' completed with bonus {_bonus} points!");
         }
      }
      public override bool IsComplete()
      {
         return _amountCompleted == _target;
      }

      public override string GetDetailsString()
      {
         return $"[{(IsComplete() ? "X" : " ")}] {_shortName} ({_description}) -- " + $"Currently completed {_amountCompleted}/{_target}";

      }

      public override string GetStringRepresentation()
      {
         return $"Checklist Goal:{_shortName},{_description},{_points},{_bonus},{_amountCompleted},{_target} | ";
      }
   }
}