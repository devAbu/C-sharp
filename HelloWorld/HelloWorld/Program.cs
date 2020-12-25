using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello World"); //Some Comment
        Console.WriteLine();
        Console.WriteLine("I'm learning C#");
        /*
         Multi
         Line 
         Comment
        */
        string name = "abu";
        string surname = "almo";
        int age = 23;

        Console.WriteLine(name + " " + surname + " is " + age + "years old");

        int number = 5;
        int numberToTwo = (int)Math.Pow(number, 2); // more make numberToTwo to duouble
        Console.WriteLine(numberToTwo);

        Console.WriteLine(Math.Cos(0));
        Console.WriteLine(Math.PI);
        Console.WriteLine(Math.Cos(Math.PI));
        Console.WriteLine(Math.Sqrt(9));
        Console.WriteLine(Math.Round(2.548)); // round to 3
        Console.WriteLine(Math.Round(2.248)); // round to 2
        Console.WriteLine(Math.Round(2.248, 2)); // two decimal digits

        Console.WriteLine(Math.Floor(2.548)); // 2
        Console.WriteLine(Math.Ceiling(2.548)); // 3
    }
}
