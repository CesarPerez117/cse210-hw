using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assingment1 = new Assignment("Samuel Bennett","Multiplication");
        Console.WriteLine(assingment1.GetSummary());

        Console.WriteLine();

        //MathAssignment mathAssignment1 = new MathAssignment("Roberto Rodriguez","Fractions","7.3","8-19");
        MathAssignment mathAssignment1 = new MathAssignment();
        Console.WriteLine(mathAssignment1.GetSummary());
        Console.WriteLine(mathAssignment1.GetHomeworkList());

        Console.WriteLine();

        WritingAssignment writingAssignment1 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(writingAssignment1.GetSummary());
        Console.WriteLine(writingAssignment1.GetWritingInformation());

    }
}