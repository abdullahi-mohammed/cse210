using System;

// Welcome to the program!
// Please enter your name: Brother Burton
// Please enter your favorite number: 42
// Brother Burton, the square of your number is 1764

class Program
{

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");

    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int favNum = int.Parse(Console.ReadLine());
        return favNum;
    }

    static int SquareNumber(int num)
    {
        int favNumSquared = num * num;
        return favNumSquared;
    }

    static void DisplayResult(string name, int favNumSquared)
    {
        Console.WriteLine($"{name}, the square of your number is {favNumSquared}");
    }
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int favNum = PromptUserNumber();
        int favNumSquared = SquareNumber(favNum);

        DisplayResult(name, favNumSquared);
    }
}