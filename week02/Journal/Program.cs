// I added a goodbye message when the user chooses to quit the program.
// Instead of using a standard comma, I used a special separator (~|~ 
// when saving and loading files. This keeps the program from breaking 
// if someone types commas or special punctuation inside their journal writing
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project!");

        Journal theJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        
        string choice = "";

        // 2. Run the menu loop until the user chooses "5" (Quit)
        while (choice != "5")
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            
            choice = Console.ReadLine();

            if (choice == "1")
            {
                // Step A: Get a random prompt from our PromptGenerator
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine($"\n{prompt}");
                Console.Write("> ");
                string userResponse = Console.ReadLine();

                // Step B: Get today's date as a short string
                string currentDate = DateTime.Now.ToShortDateString();

                
                Entry newEntry = new Entry();
                newEntry._date = currentDate;
                newEntry._promptText = prompt;
                newEntry._entryText = userResponse;

                
                theJournal.AddEntry(newEntry);
            }
            else if (choice == "2")
            {
                
                theJournal.DisplayAll();
            }
            else if (choice == "3")
            {
                
                Console.Write("What is the filename? ");
                string filename = Console.ReadLine();
                theJournal.SaveToFile(filename);
                Console.WriteLine("Journal saved successfully!");
            }
            else if (choice == "4")
            {
                // Ask for a filename and load
                Console.Write("What is the filename? ");
                string filename = Console.ReadLine();
                theJournal.LoadFromFile(filename);
                Console.WriteLine("Journal loaded successfully!");
            }
            else if (choice == "5")
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
            }

            Console.WriteLine(); // Blank line for spacing between menu loops
        }
    }
}