using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Scripture Memorizer Project.");

        Reference reference = new Reference("Proverbs", 3, 5, 6);
        string text = "Trust in the Lord with all thine heart and lean not unto thine own understanding";
        Scripture scripture = new Scripture(reference, text);

        string userInput = "";

        while (userInput.ToLower() != "quit")
        {
            Console.Clear();
            
            // 1. Print the Reference in bright Cyan
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(reference.GetDisplayText());
            Console.ResetColor(); // Always reset so other text isn't affected
            Console.WriteLine(); // Blank line for spacing

            // 2. Print the scripture words (we can loop through them to color hidden vs visible!)
            // (We will add a quick method for this in Step 2)
            scripture.DisplayColoredScripture();
            
            // 3. Check if all words are hidden
            if (scripture.IsCompletelyHidden())
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n\n🎉 Amazing job! You have completely memorized the scripture!");
                Console.ResetColor();
                break; 
            }
            
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\n\n[Press Enter to continue | Type 'quit' to exit]");
            Console.ResetColor();
            
            userInput = Console.ReadLine();

            if (userInput.ToLower() != "quit")
            {
                scripture.HideRandomWords(3);
            }
        }
    }
}
