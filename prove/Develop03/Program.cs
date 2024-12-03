using System;

// Stretch Challenge; Creativity Features Implemented:
// Scripture Library: Includes a collection of scriptures and selects one randomly for each run.

class Program
{
    static void Main(string[] args)
    {

        // Example library of scriptures
        var scriptures = new List<Scripture>{
            new Scripture(new Reference("Proverbs", "3", "5", "6"), "Trust in the Lord with all your heart and lean not on your own understanding."),
            new Scripture(new Reference("John", "3", "16"), "For God so loved the world that He gave His one and only Son, that whoever believes in Him shall not perish but have eternal life."),
            new Scripture(new Reference("Psalm", "23", "1", "2"), "The Lord is my shepherd; I shall not want. He makes me lie down in green pastures.")
            };

        // var scriptures = LoadScripturesFromFile("scriptures.txt");


        // Select a random scripture
        var random = new Random();
        var scripture = scriptures[random.Next(scriptures.Count)];

        // Example scripture
        // var reference = new Reference("Proverbs", "3", "5", "6");
        // var scriptureText = "Trust in the Lord with all your heart and lean not on your own understanding.";
        // var scripture = new Scripture(reference, scriptureText);

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

    // public static List<Scripture> LoadScripturesFromFile(string filePath)
    // {
    //     var scriptures = new List<Scripture>();
    //     foreach (var line in System.IO.File.ReadAllLines(filePath))
    //     {
    //         var parts = line.Split('|'); // Assume format: "Reference|Text"
    //         var reference = new Reference(parts[0].Split(' ')[0], parts[0].Split(' ')[1].Split(':')[0], parts[0].Split(' ')[1].Split(':')[1]);
    //         scriptures.Add(new Scripture(reference, parts[1]));
    //     }
    //     return scriptures;
    // }

}
