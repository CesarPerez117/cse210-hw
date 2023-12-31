using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}");

        /*Assignment
        Prompt the user for their first name. Then, prompt them for their last name. Display the text back all on one line saying, 
        "Your name is last-name, first-name, last-name" as shown:

        What is your first name? Scott
        What is your last name? Burton

        Your name is Burton, Scott Burton.

        What is your first name? Brigham
        What is your last name? Young

        Your name is Young, Brigham Young.

        Make sure to be precise! You should have the spacing, comma, and period appear exactly as shown in the examples.
        */
    }
}