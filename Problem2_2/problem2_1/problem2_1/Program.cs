using System;

public class Pronlem2_1
{
     static void TableHeader()
    {
        Console.WriteLine("\n\n\t\t\t Maniplication table form 1 to 10\n\n");
      
        for(int i = 1; i <= 10; i++)
        {
            Console.Write($"\t{i}");
        }
        Console.WriteLine("\n-----------------------------------------------------------------------------------");
    }
    static string ColumnSeprator(int n)
    {
        if (n < 10)
            return ("   |");
        else
            return ("  |");
    }

    static void PrintMultiplicationTable() 
    {
        TableHeader();
        for (int i = 1; i <= 10; i++)
        {
            Console.Write($" {i} {ColumnSeprator(i)}\t");
            for(int j = 1; j <= 10; j++)
            {
                Console.Write($"{i*j}\t");
            }
            Console.WriteLine();
        }
    }
    static void Main(string[] args)
    {
        PrintMultiplicationTable();
    }
}