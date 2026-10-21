using System.Runtime.CompilerServices;

class Journal
{
    public List<JournalEntry> entries = new List<JournalEntry>();

    public void DisplayJournal()
    {
        foreach(JournalEntry entry in entries)
        {
            entry.DisplayJournalEntry();
        }
    }

    public void CreateEntry()
    {
        JournalEntry newEntry = new JournalEntry();
        newEntry.CreateJournalEntry();
        entries.Add(newEntry);

    }
    public void WriteToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach(JournalEntry entry in entries)
            {
                outputFile.WriteLine(entry.CreateFileSystemString());
            }
        }
    }

    public void ReadFromFile(string filename)
    {
        
        if (File.Exists(filename))
        {
            entries.Clear();
            string[] lines = System.IO.File.ReadAllLines(filename);

            foreach(string line in lines)
            {
                string[] parts = line.Split("#");
                if (parts.Length != 3)
                {
                    continue;
                }

                string date = parts[0];
                string question = parts[1];
                string entryText = parts[2];

                JournalEntry entry = new JournalEntry(date, question, entryText);
                entries.Add(entry);
            }
        }
        else
        {
            Console.WriteLine("Error: File not Found");
        }
    }
        public string FileHelper(string fixfilename)
    {
        if (!fixfilename.EndsWith(".txt", StringComparison.OrdinalIgnoreCase))
        {
            fixfilename += ".txt";
        }

        return fixfilename;
    }
}