using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment al = new Assignment("Bonnie Gilbert", "Multiplication");
        Console.WriteLine(al.GetSummary());

        MathAssignment a2 = new MathAssignment("Taylor Bennet", "Fraction", "7.3", "8-19");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssigment a3 = new WritingAssigment("Mary Walter", "European History", "The Causes of World War 2");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }
}