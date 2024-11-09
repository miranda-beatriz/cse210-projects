using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What it´s your grade porcentage? ");
        string studentGrade = Console.ReadLine();

        int x = int.Parse(studentGrade);
        string grade = "";



        if (x >= 90)
        {
            grade = "A";
        }
        else if (x >= 80)
        {
            grade = "B";
        }
        else if (x >= 70)
        {
            grade = "C";
        }
        else if (x >= 60)
        {
            grade = "D";
        }
        else
        {
            grade = "F";
        }

        Console.WriteLine($"Your grade is: {grade}");

        if (x >= 70)
        {
            Console.WriteLine("Congratulations! You passed!");
        }
        else
        {
            Console.WriteLine("Good luck on the next time!");
        }
    }
}