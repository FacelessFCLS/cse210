public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry e in _entries)
        {
            e.DisplayEntry();
        }
    }

    public void SaveToFile(string filename)
    {
        Console.WriteLine("Save to File...");
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry e in _entries)
            {
                outputFile.WriteLine($"{e._date}|{e._promptText}|{e._entryText}");
            }
        }
        Console.WriteLine("File Saved.");
        Console.WriteLine();
    }

    public void LoadFromFile(string filename)
    {
        Console.WriteLine("Load from File...");
        _entries.Clear();
        foreach (string line in File.ReadAllLines(filename))
        {
            string[] parts = line.Split('|');
            Entry e = new Entry();
            e._date = parts[0];
            e._promptText = parts[1];
            e._entryText = parts[2];
            _entries.Add(e);
        }
        Console.WriteLine("File Loaded.");
        Console.WriteLine();
    }
}