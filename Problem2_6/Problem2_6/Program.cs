using System;

public class Pronlem2_6
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
    static int PrintDigits(int number)
    {
        int reminder = 0;
        int sum = 0;
        while (number > 0)
        {
            reminder = number % 10;
            number = number / 10;
            sum += reminder;
        }
        return sum;
    }
    static void Main(string[] args)
    {
        Console.WriteLine($"The sum = {PrintDigits(GetInputNumber())}");
        ;
    }
}
