using System;

//   Enter a list of numbers, type 0 when finished.
//   Enter number: 18
//   Enter number: 36
//   Enter number: 2
//   Enter number: 48
//   Enter number: 6
//   Enter number: 12
//   Enter number: 9
//   Enter number: 0
//   The sum is: 131
//   The average is: 18.714285714285715
//   The largest number is: 48

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> sum = new List<int>();
        int num;
        do
        {
            Console.Write("Enter number: ");

            num = int.Parse(Console.ReadLine());
            sum.Add(num);

        } while (num != 0);

        if (num == 0)
        {
            int maxNum = sum.Max();
            double avgNum = sum.Average();
            double totalNum = sum.Sum();
            Console.WriteLine($"The sum is: {totalNum}");
            Console.WriteLine($"The average is: {avgNum}");
            Console.WriteLine($"The largest number is: {maxNum}");

        }
    }
}