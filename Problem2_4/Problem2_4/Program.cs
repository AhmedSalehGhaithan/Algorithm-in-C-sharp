using System;

public class Pronlem2_4
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
            if (number % i == 0)
            {
                sum += i;
            }
        }
        return number == sum;
    }


    static void PrintPerfectNumbersFrom1ToN()
    {
        int num = GetInputNumber();

        for(int i= 1; i < num; i++)
        {
            if (ISPerfictNumber(i))
            {
                Console.Write($"{i}\t");
            }
        }

        Console.WriteLine();
    }
    static void Main(string[] args)
    {
        PrintPerfectNumbersFrom1ToN();
    }
}