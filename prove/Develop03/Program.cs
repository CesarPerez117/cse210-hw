using System;

class Program
{
    static void Main(string[] args)
    {
        int choice = 0;
        Reference referenceSingle = new Reference();
        Reference referenceMultiple = new Reference();
        Scripture scriptureSingle = new Scripture();
        Scripture scriptureMultiple = new Scripture();
        
        
        string[] _singleScripture = {"John 3:16", 
        "For God so bloved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."};
        string[] _multipleScripture = {"Proverbs 3:5-6", 
        "Trust in the Lord with all thine heart; and lean not unto thine own understanding.", 
        "In all thy ways acknowledge him, and he shall direct thy paths."};
    
        
        do 
        {
            Console.WriteLine("Scripture Memorizer");
            Console.WriteLine("1. Memorize Single Vers" + "\n2. Memorize Multiple Vers" + "\n3. Quit");
            Console.Write("What would you like to do? ");
            choice = int.Parse(Console.ReadLine());
            Console.Clear();

            switch (choice)
            {
                case 1:
                    // Display single scripture and work with the hideWords
                    referenceSingle.SetScriptureReference(_singleScripture[0]);
                    referenceSingle.Display();
                    break;
                case 2:
                    // Display multi scripture and work with the hideWords
                    referenceMultiple.SetScriptureReference(_multipleScripture[0]);
                    referenceMultiple.Display();
                    break;
            }
        } while (choice != 3);

    }
}