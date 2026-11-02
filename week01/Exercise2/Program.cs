using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.Write("What is your grade? ");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);
        string letter = "";

        if (grade >= 90)
        {
            letter = "A";
        }
        
        else if (grade >= 80)
        {
            letter = "B";
        }

        else if (grade >= 70)
        {
            letter = "C";
        }

        else if (grade >= 60)
        {
            letter = "D";
        }

        else 
        {
            letter = "F";
            
        }
        Console.WriteLine($"This is your grade - {letter}");
        if (grade >= 70)
        {
            Console.WriteLine("You passed the course, Congradulations!");
        }
        else
        {
            Console.WriteLine("You did not pass, but there's always next time!");
        }
        
    }
}