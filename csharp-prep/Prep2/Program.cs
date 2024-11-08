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
            Console.WriteLine("A");
            Console.Write($"Congratulations on passing the course with a grade of {grade}");
        }
        else if (grade >= 80)
        {
            Console.WriteLine("B");
            Console.Write($"Congratulations on passing the course with a grade of {grade}");
        }
        else if (grade >= 70)
        {
            Console.WriteLine("C");
            Console.Write($"Congratulations on passing the course with a grade of {grade}");
        }
        else if (grade >= 60)
        {
            Console.WriteLine("D");
            Console.Write($"You tried but there is room for improvement");
        }
        else
        {
            Console.WriteLine("F");
            Console.Write($"You can do better next time");
        }

        // if (grade >= 70)
        // {
        //     Console.Write($"Congratulations on passing the course with a grade of {grade}");
        // }
        // else
        // {

        // }
    }
}