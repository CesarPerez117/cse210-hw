using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Event Planning Tool.");

        // Child classes events calling
        // Order(string eventType, string eventTitle, string eventDescription, string eventDate, string eventTime, string speaker, int capacity)
        Lecture lecture = new Lecture("Lecture", "Jules Verne: Ahead of his time", "Develop an analisis about the author and his ideas of the future", "12th October", "07:00 PM", "Maria Angelato", 200);
        Outdoor outdoor = new Outdoor("Outdoor Gathering", "Hamsters Showtime", "Expectate the most trained Hamsters of Oregon", "25th November", "08:00 AM", "Cloudy");
        Reception reception = new Reception("Reception", "Honorary Graduation", "You were invited to attempt to the High Scored Students graduation", "10th January, 2024", "05:00 PM", "graduations@byui.edu");
        // Address
        string address1 = lecture.GetAddress("10 Jimenez Guzman", "Molinos", "San Pedro","Rep. Dom.");
        string address2 = outdoor.GetAddress("722 Hereford St","Portland","Oregon","USA");
        string address3 = reception.GetAddress("525 S Center St","Rexburg","Idaho","USA");

        // Lecture Event Section
        Console.WriteLine("- - - - - - - - - - - - - - - -");
        Console.WriteLine("Lecture Event");
        Console.WriteLine("- - - - - - - - - - - - - - - -");
        Console.WriteLine("Standar Details:\n");
        Console.WriteLine(lecture.StandarDetails(address1));
        Console.WriteLine();
        Console.WriteLine("Full Details:\n");
        Console.WriteLine(lecture.FullDetails());
        Console.WriteLine();
        Console.WriteLine("Short Details:\n");
        Console.WriteLine(lecture.ShortDescription());
        Console.WriteLine();


        // Outdoor Event Section
        Console.WriteLine("- - - - - - - - - - - - - - - -");
        Console.WriteLine("Outdoor Gathering Event");
        Console.WriteLine("- - - - - - - - - - - - - - - -");
        Console.WriteLine("Standar Details:\n");
        Console.WriteLine(outdoor.StandarDetails(address2));
        Console.WriteLine();
        Console.WriteLine("Full Details:\n");
        Console.WriteLine(outdoor.FullDetails());
        Console.WriteLine();
        Console.WriteLine("Short Details:\n");
        Console.WriteLine(outdoor.ShortDescription());
        Console.WriteLine();


        // Reception Event Section
        Console.WriteLine("- - - - - - - - - - - - - - - -");
        Console.WriteLine("Reception Event");
        Console.WriteLine("- - - - - - - - - - - - - - - -");
        Console.WriteLine("Standar Details:\n");
        Console.WriteLine(reception.StandarDetails(address3));
        Console.WriteLine();
        Console.WriteLine("Full Details:\n");
        Console.WriteLine(reception.FullDetails());
        Console.WriteLine();
        Console.WriteLine("Short Details:\n");
        Console.WriteLine(reception.ShortDescription());
        Console.WriteLine();
    }
}