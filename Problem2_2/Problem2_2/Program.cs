using System;

public class Pronlem2_1
{

    static int GetInputNumber()
    {
        int number=1;
        do
        {
            Console.WriteLine("Enter the number");
            number = int.Parse(Console.ReadLine());
        } while (number <= 0);

        return number;
    }

    static bool checkPrimeNumber(int number)
    {
        if (number <= 1)
        {
            return false;
        }
        //The loop condition is i * i <= num, which means the loop will
        //continue until i squared is greater than the input number.
        //This condition is based on the fact that if a number num is divisible
        //by any number between 2 and its square root, it is not a prime number.
        for (int i = 2; i*i <= number; i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }
        return true;
    }
   
    static void PrintPrimeNumberFromTo()
    {
        int num = GetInputNumber();
        for (int i=0;i<= num; i++)
        {
            if (checkPrimeNumber(i))
            {
                Console.Write($"{i}\t");
            }
        }
        Console.WriteLine();

    }
    static void Main(string[] args)
    {
        PrintPrimeNumberFromTo();


    }
}