using System;

class Program
{
    static void Main()
    {
        PrintNames("Abu", "Almo");
        PrintNames("Oba", "Almo");
        PrintNames("Kum", "Is");
        PrintNames("Tarik", "Dizda");

        Console.WriteLine("Please enter your name:");
        string name = Console.ReadLine();
        Console.WriteLine("Please enter your last name:");
        string lastName = Console.ReadLine();

        PrintNames(name, lastName);

        Console.WriteLine("Enter first number:");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number:");
        int secondNumber = int.Parse(Console.ReadLine());

        numbers(firstNumber, secondNumber);
    }

    static void PrintNames(string name, string lastname) // void - the method will not return anything
    {
        Console.WriteLine("My name is {0}", name);
        Console.WriteLine("My last name is {0}", lastname);
        Console.WriteLine("I'm learning C#");
    }

    static void numbers(int number1, int number2)
    {
        if (number1 > number2)
        {
            Console.WriteLine("{0} is bigger than {1}", number1, number2);
        }
        else
        {
            Console.WriteLine("{0} is bigger than {1}", number2, number1);
        }
    }
}
