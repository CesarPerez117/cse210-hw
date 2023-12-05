using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Exercise Record!");
        Console.WriteLine();

        // Running
        Running runningE = new Running("Running", "03 Nov 2022", 30, 4.8);
        // this will follow the example provided in webpage 
        Running running =  new Running("Running", "05 Oct 2023", 25, 2.2);

        // Cycling 
        Cycling cycling = new Cycling("Cycling", "02 Dec 2023", 62, 22);

        // Swimming 
        Swimming swimming = new Swimming("Swimming", "05 Jun 2023", 35, 0, 12);

        Console.WriteLine("Let's Display the Summary: ");

        // For Running Exercise
        Console.WriteLine(runningE.DisplaySummary());
        // The values will display is different than example. I tried my own will calculator and 
        // still different, but there is it. 
        Console.WriteLine();
        Console.WriteLine(running.DisplaySummary());
        Console.WriteLine();

        // For Cycling Exercise
        Console.WriteLine(cycling.DisplaySummary());
        Console.WriteLine();

        // For Swimming Exercise
        Console.WriteLine(swimming.DisplaySummary());
        //Console.WriteLine();
    }
}