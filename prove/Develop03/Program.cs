using System;

class Program
{
    static void Main(string[] args)
    {
        // Example scripture
        var reference = new Reference("Proverbs", "3", "5", "6");
        var scriptureText = "Trust in the Lord with all your heart and lean not on your own understanding.";
        var scripture = new Scripture(reference, scriptureText);

        Console.Clear();
        Console.WriteLine(scripture);

        while (!scripture.AllWordsHidden)
        {
            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");
            var input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                Console.WriteLine("Goodbye!");
                break;
            }

            scripture.HideRandomWords();
            Console.Clear();
            Console.WriteLine(scripture);
        }

        if (scripture.AllWordsHidden)
        {
            Console.WriteLine("Congratulations! You memorized the scripture!");
        }
    }
}
