using System;

public class Pronlem2_3
{

    static int GetInputNumber()
    {
        int number = 1;
        do
        {
            Console.WriteLine("Enter the number");
            number = int.Parse(Console.ReadLine());
        } while (number <= 0);

        return number;
    }

    static bool ISPerfictNumber(int number)
    {
        int sum = 0;
        for (int i = 1; i < number; i++)
        {
            if(number % i == 0)
            {
                sum += i;
            }
        }
        return number==sum;
    }

    static void PrintResults(int number)
    {
        string message = (ISPerfictNumber(number)) ? ("Prefect") : ("Not Prefect");
        Console.WriteLine($"The number is {message}");

    }
    static void Main(string[] args)
    {
       PrintResults(GetInputNumber());
    }
}