using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome(); /* if the program just will send information when needed, 
        we just need to call the function  */

        string userName = PromptUserName(); /* if the function uses info and return that info, we need 
        store the info into variables in the main */
        int userNumber = PromptUserNumber();

        int squareNumber = SquareNumber(userNumber);

        DisplayResult(userName, squareNumber); /* the parameters will need to accomplish his order or will not work and cannot debug */
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int userNumber = int.Parse(Console.ReadLine());
        return userNumber;
    }

    static int SquareNumber(int number)
    {
        int squareNumber = number * number;
        return squareNumber;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}