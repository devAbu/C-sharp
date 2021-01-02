using System;
class Program
{
    static void Main()
    {
        // new way to construct strings with placeholders or by using the plus sign to concatenate them

        string shirtColor = "green";

        //string someString = "I have a " + shirtColor + " shirt";
        //Console.WriteLine(someString);
        //string someString = String.Format("I have a {0} shirt", shirtColor);
        //Console.WriteLine(someString);

        string someString = $"I have a {shirtColor} shrit";
        Console.WriteLine(someString);

        // Escaping
        string programFolder = "Program";
        string programName = "Program.exe";

        //string text = $"C:\\{programFolder}\\{programName}";
        string text = $@"C:\{programFolder}\{programName}";

        Console.WriteLine(text);

        // expressions and methods inside  an interpolated expression
        int number = 5;

        //string text2 = $"The {number} is {(number % 2 == 0 ? "even" : "old" )}";
        string text2 = $"The {number} is {checkEven(number)}";

        Console.WriteLine(text2);
    }

    static string checkEven(int num)
    {
        return (num % 2 == 0 ? "even" : "old");
    }
}
