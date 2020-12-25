using System;
using System.Text;
using System.Threading;

class Program
{
    static void Main()
    {
        int number = 5; // integer

        Console.WriteLine(number);

        Console.WriteLine("What is your name?");
        string firstName = Console.ReadLine(); // string for text

        Console.WriteLine("Your age?");
        int age = int.Parse(Console.ReadLine());

        Console.WriteLine(firstName + " is " + age + " years old");
        Console.WriteLine("{0} is {1} years old", firstName, age);

        char grade = 'A';
        Console.WriteLine(grade);

        bool answer = true;
        Console.WriteLine(answer);

        float someNumber = 3.14F;
        Console.WriteLine(someNumber);
        Thread.Sleep(1500);

        double someNumber2 = 3.14;
        Console.WriteLine(someNumber2);

        Console.WriteLine("Min value - INT : " + int.MinValue);
        Console.WriteLine("Max value - INT : " + int.MaxValue);

        uint posNumber = 5; // uint can't be negative (-1,-20)
        Console.WriteLine("Min value - UINT : " + uint.MinValue);
        Console.WriteLine("Min value - UINT : " + uint.MinValue);

        byte someByte = 100; // max 255 - can't be negative
        Console.WriteLine("Min value - BYTE : " + byte.MinValue);
        Console.WriteLine("Min value - BYTE : " + byte.MinValue);

        sbyte negativeByte = -25; // can be positive or negative
        Console.WriteLine("Min value - SBYTE : " + sbyte.MinValue);
        Console.WriteLine("Min value - SBYTE : " + sbyte.MinValue);

        long bigNumber = 326549412314545847;
        Console.WriteLine("Min value - LONG : " + long.MinValue);
        Console.WriteLine("Min value - LONG : " + long.MinValue);

        ulong bigNumber2 = 322341548531; //can't be negative
        Console.WriteLine("Min value - ULONG : " + ulong.MinValue);
        Console.WriteLine("Min value - ULONG : " + ulong.MinValue);

        Console.WriteLine("Min value - float : " + float.MinValue);
        Console.WriteLine("Min value - float : " + float.MinValue);

        double someDouble = 2.5d;
        Console.WriteLine("Min value - double : " + double.MinValue);
        Console.WriteLine("Min value - double : " + double.MinValue);

        decimal decimalNumber = 2.0m;
        Console.WriteLine("Min value - decimal : " + decimal.MinValue);
        Console.WriteLine("Min value - decimal : " + decimal.MinValue);

        bool isEqual = (5 == 4);
        Console.WriteLine(isEqual);

        char specialCharacter = '\u0026'; // ASCII table
        Console.WriteLine(specialCharacter);

        Console.WriteLine("♣");

        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;

        Console.WriteLine("♣");

        //Object
        object someObject = "Smartphone"; // we can store anything - the data type can be changed
        Console.WriteLine(someObject);
        someObject = 15;
        Console.WriteLine(someObject);
        someObject = true;
        Console.WriteLine(someObject);

        var someVar = "smartPhone"; // can be anything - the data type can't be changed
        Console.WriteLine(someVar);
        //someVar = 5; --> ERROR
    }
}
