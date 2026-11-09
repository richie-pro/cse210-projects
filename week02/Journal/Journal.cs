public class Journal
{
    // 1. The list that stores all our Entry objects in memory
    public List<Entry> _entries = new List<Entry>();

    // 2. Adds a new entry object to our list
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    // 3. Displays every entry currently in the journal
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    // 4. Saves all entries to a text file using a unique separator
    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                // We use a custom separator like ~|~ so commas or spaces in our text don't break things
                outputFile.WriteLine($"{entry._date}~|~{entry._promptText}~|~{entry._entryText}");
            }
        }
    }

    // 5. Loads entries from a text file and replaces the current list
    public void LoadFromFile(string filename)
    {
        if (File.Exists(filename))
        {
            string[] lines = File.ReadAllLines(filename);
            
            // Clear out whatever is currently in memory before loading new entries
            _entries.Clear();

            foreach (string line in lines)
            {
                // Split the line back into pieces using our custom separator
                string[] parts = line.Split("~|~");

                Entry newEntry = new Entry();
                newEntry._date = parts[0];
                newEntry._promptText = parts[1];
                newEntry._entryText = parts[2];

                _entries.Add(newEntry);
            }
        }
    }
}