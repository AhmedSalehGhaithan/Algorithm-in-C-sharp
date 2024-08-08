using System;

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
    static int ReverseNumber(int number)
    {
        int reminder = 0;
        int sum = 0;
        int number2 = 0;
        while (number > 0)
        {
            reminder = number % 10;
            number = number / 10;
            sum += reminder;
            number2 = number2 * 10 + reminder;
        }
        return number2;
    }
    static void Main(string[] args)
    {
        Console.WriteLine($"The reverse number = {ReverseNumber(GetInputNumber())}");
    }
}
