using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        Job job2 = new Job();
        job1._jobTitle = "Software engineer (Microsoft) 2019-2022";
        job1.Display();
        job2._jobTitle = "Blockchain engineer (Apple) 2022-2023";
        job2.Display();

        Resume resume1 = new Resume();

    }
}
