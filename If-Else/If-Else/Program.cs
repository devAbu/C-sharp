using System;
class Program
{
    static void Main(string[] args)
    {
        if(4 > 5)
        {
            Console.WriteLine("4 is bigger than 5");
        }

        Console.WriteLine("Please enter your first number");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter your second number");
        int secondNumber = int.Parse(Console.ReadLine());

        if(firstNumber < secondNumber)
        {
            Console.WriteLine("{0} is less than {1}", firstNumber, secondNumber);
        }
        else if(firstNumber > secondNumber)
        {
            Console.WriteLine("{0} is bigger than {1}", firstNumber, secondNumber);
        }
        else
        {
            Console.WriteLine("The numbers are equal");
        }

        switch (firstNumber)
        {
            case 1:
                Console.WriteLine("The number is one");
                break;
            case 5:
                Console.WriteLine("The number is five");
                break;
            default:
                Console.WriteLine("The number is something else");
                break;
        }

        // good practice:
        // if((a > b) && (a > c))
    }
}
