using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Pronlem2_7
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

    static int CountNumbers(int number,int number2)
    {
        int reminder = 0;
        int sum = 0;
        int timesRepeat = 0;
        while (number > 0)
        {
            reminder = number % 10;
            number = number / 10;
            if (reminder == number2)
            {
                timesRepeat++;
            }

        }
        return timesRepeat;

    }
    static void PrintNumbersWithCounts(int number)
    {
        for (int i= 0; i < 10; i++){

            int digiitFrequency = CountNumbers(number, i);
            if (digiitFrequency > 0)
            {
                Console.WriteLine($"Number {i} Repeated {digiitFrequency} times");
            }
        }
    }
    static void Main(string[] args)
    {
        PrintNumbersWithCounts(GetInputNumber());
    }
}
