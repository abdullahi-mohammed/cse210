using System;

class Program

// What is your first name? Scott
// What is your last name? Burton

// Your name is Burton, Scott Burton.
{
    static void Main(string[] args)
    {

        Console.WriteLine("What is your first name?");
        string firstName = Console.ReadLine();

        Console.WriteLine("What is your last name?");
        string lastName = Console.ReadLine();

        Console.Write($"Your name is {lastName}, {firstName} {lastName}.");
    }
}