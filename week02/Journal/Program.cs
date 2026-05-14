using System;

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        int menuChoice;

        Console.WriteLine("Welcome to the Journal Program!");
        do
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Write a new journal entry");
            Console.WriteLine("2. Display all journal entries");
            Console.WriteLine("3. Save journal to file");
            Console.WriteLine("4. Load journal from file");
            Console.WriteLine("5. Exit");
            Console.Write("Please enter your choice: ");
            menuChoice = int.Parse(Console.ReadLine());
            if (menuChoice == 1)
            {
                Entry myEntry = new Entry();
                myEntry.NewEntry();
                myJournal.AddEntry(myEntry);
            }
            else if (menuChoice == 2)
            {
                myJournal.DisplayEntry();
            }
            else if (menuChoice == 3)
            {
                Console.Write("Please enter the filename: ");
                string filename = Console.ReadLine();
                myJournal.SaveToFile(filename);
            }
            else if (menuChoice == 4)
            {
                Console.Write("Please enter the filename: ");
                string filename = Console.ReadLine();
                myJournal.LoadFromFile(filename);
            }
            else
            {
                break;
            }
        } while (menuChoice != 5);
    }
}