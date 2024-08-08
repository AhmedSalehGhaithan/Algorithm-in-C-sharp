using System;

public class Pronlem2_8
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
    static int ReverseNumber(int number,int numRep)
    {
        int reminder = 0;
        int sum = 0;
        int timesRepeat = 0;
        while (number > 0)
        {
            reminder = number % 10;
            number = number / 10;
          if(reminder == numRep)
            {
                timesRepeat++;
            }
            
        }
        return timesRepeat;
    }
    static void Main(string[] args)
    {
        Console.WriteLine($"The reverse number = {ReverseNumber(GetInputNumber(),2)}");
    }
}
