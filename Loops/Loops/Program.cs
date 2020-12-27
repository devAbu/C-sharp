using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("0 1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 ");

        Console.WriteLine("Please enter the first number");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the end number");
        int endNumber = int.Parse(Console.ReadLine());

        while (firstNumber <= endNumber )
        {
            Console.WriteLine(firstNumber);
            firstNumber++;
        }

        firstNumber = 0;
        do
        {
            Console.WriteLine(firstNumber);
            firstNumber++;
        } while (firstNumber <= endNumber);

        firstNumber = 0;
        for (int i = firstNumber; i <= endNumber; i++)
        {
            Console.WriteLine(i);
        }

        int[] array = { 1, 2, 3 };

        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }

        for (int i = array.Length-1; i >= 0; i--)
        {
            Console.WriteLine(array[i]);
        }

        foreach (var item in array)
        {
            Console.WriteLine(item);
        }

        string something = "colletions";
        foreach (var item in something)
        {
            Console.WriteLine(item);
        }

        // 1 
        // 1 2
        // 1 2 3
        // 1 2 3 4
        // 1 2 3 4 5
        // 1 2 3 4 5 6
        // 1 2 3 4 5 6 7
        Console.WriteLine("Nested LOOP");
        for (int i = 1; i <= 8; i++) // rows
        {
            for (int j = 1; j <= i ; j++)
            {
                Console.Write(j);
            }

            Console.WriteLine();
        }
    }
}
