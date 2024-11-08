using System;

// A >= 90
// B >= 80
// C >= 70
// D >= 60
// F < 60
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your Grade percentage?");
        int grade = int.Parse(Console.ReadLine());
        if (grade >= 90)
        {
            Console.Write("A");
        }
        else if (grade >= 80)
        {
            Console.Write("B");
        }
        else if (grade >= 70)
        {
            Console.Write("C");
        }
        else if (grade >= 60)
        {
            Console.Write("D");
        }
        else
        {
            Console.Write("F");
        }
    }
}