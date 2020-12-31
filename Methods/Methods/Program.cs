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

        int result = MultiplyTwoNumber(firstNumber, secondNumber);
        Console.WriteLine(result);

        Console.WriteLine(Compare(name, lastName));

        //overloading - different implementation with the same name
        string someName = "abu";
        string someLastName = "Almo";

        PrintName(someName, someLastName);

        string city = "Sarajevo";

        PrintName(someName, someLastName, city);

        PrintName(someName, someLastName, city, ConsoleColor.Green);

        // variable number of argumnets
        Console.WriteLine(Sum(88));
        Console.WriteLine(Sum(1, 3));
        Console.WriteLine(Sum(1, 5));
        Console.WriteLine(Sum(7, 3));
        Console.WriteLine(Sum(12, 8));

        // optional arguments
        Console.WriteLine(Multiplication(1, 2));
        Console.WriteLine(Multiplication(1, 5));
        Console.WriteLine(Multiplication(7, 2, 1));

        int numberOne = 1; // value type
        //addOne(numberOne); // Doesn't work
        Console.WriteLine(numberOne);

        int[] numbersArray = { 1, 2, 3 }; // ref type
        AddOne(numbersArray); // WORKS
        Console.WriteLine(numbersArray[0]);

        AddOne(ref numberOne); // WORKS
        Console.WriteLine(numberOne);

        int someNumber;
        AssignValue(out someNumber);
        Console.WriteLine(someNumber);
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

    static int MultiplyTwoNumber(int firstNumber, int secondNumber)
    {
        return firstNumber * secondNumber;
    }

    static bool Compare(string firstString, string secondString)
    {
        bool isEqual = true;

        if(firstString.Length == secondString.Length)
        {
            for (int i = 0; i < firstString.Length; i++)
            {
                if(firstString[i] != secondString[i])
                {
                    isEqual = false;
                    break;
                }
            }
        }
        else
        {
            isEqual = false;
        }

        return isEqual;
    }

    //overloading
    static void PrintName(string firstName, string lastName)
    {
        Console.WriteLine(firstName + " " + lastName);
    }

    static void PrintName(string firstName, string lastName, string city)
    {
        Console.WriteLine(firstName + " " + lastName + " " + city);
    }

    static void PrintName(string firstName, string lastName, string city, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        Console.WriteLine(firstName + " " + lastName + " " + city);
        Console.ResetColor();
    }
    
    // variable number of argumnets
    static int Sum(params int[] numbers)
    {
        int sum = 0;

        foreach (var number in numbers)
        {
            sum += number;
        }

        return sum;
    }

    //optional arguments
    static int Multiplication(int num1, int num2, int num3 = 10)
    {
        return num1 * num2 * num3;
    }

    static void AddOne(ref int num) 
    {
        num++;
    }

    static void AssignValue(out int num)
    {
        num = 5;
    }

    static void AddOne(int[] num)
    {
        num[0]++;
    }
}
