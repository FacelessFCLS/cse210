public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public void NewEntry()
    // Get and store current date
    {
        DateTime currentDate = DateTime.Now;
        _date = currentDate.ToShortDateString();

        console.WriteLine();
        _promptText genRandom = new _promptText();
        _promptText = genRandom.GetRandomPrompt();

        Console.WriteLine(_promptText);
        Console.Write("> ");
        _entryText = Console.ReadLine();
    }

    public void DisplayEntry()
    {
        Console.WriteLine();
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}");
        Console.WriteLine();
    }
}