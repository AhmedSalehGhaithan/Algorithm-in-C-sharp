using System;

public class Pronlem2_5
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
    static void PrintDigits(int number)
    {
        int reminder = 0;

        while (number > 0)
        {
            reminder = number % 10;
            number = number / 10;
            Console.Write(reminder);
        }
        Console.WriteLine();
    }
    static void Main(string[] args)
    {
        PrintDigits(GetInputNumber());
    }
}
