using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userAnswer = Console.ReadLine();
        int userPercentage = int.Parse(userAnswer);
        string letter = "";

        if (userPercentage >= 90 && userPercentage < 100)
        {
            letter = "A";

            if (userPercentage >= 97)
            {
                letter = "A+";
            }
            else if (userPercentage <= 93)
            {
                letter = "A-";
            }
        }
        else if (userPercentage >= 80 && userPercentage < 90)
        {
            letter = "B";

            if (userPercentage >= 87)
            {
                letter = "B+";
            }
            else if (userPercentage <= 83)
            {
                letter = "B-";
            }
        }
        else if (userPercentage >= 70 && userPercentage < 80)
        {
            letter = "C";

            if (userPercentage >= 77)
            {
                letter = "C+";
            }
            else if (userPercentage <= 73)
            {
                letter = "C-";
            }
        }
        else if (userPercentage >= 60 && userPercentage < 70)
        {
            letter = "D";

            if (userPercentage >= 67)
            {
                letter = "D+";
            }
            else if (userPercentage <= 63)
            {
                letter = "D-";
            }
        }
        else if (userPercentage < 60)
        {
            letter = "F";
        }
        else
        {
            Console.WriteLine("Syntax Error");
        }

        Console.WriteLine($"Your grade is: {letter}");

        if (userPercentage > 70)
        {
            Console.WriteLine("Congratulations, you have pass the course!");
        }
        else if (userPercentage < 70)
        {
            Console.WriteLine("Sorry, you fail the course. Encourage next time.");
        }
    }
}