using System;
class Program
{
    static void Main()
    {
        Console.Write("Write ");
        Console.Write("Same Line"); // we can add \n - end line

        Console.WriteLine("Write with end line");

        // FORMATTING STRING THE CORRECT WAY
        string freshJuice = "Lets make fresh juice from Bananas";
        string strawbery = "strawberry";
        int number = 500;

        Console.WriteLine("{0} and {1}", freshJuice, strawbery);
        Console.WriteLine("{0, 15}", strawbery); // 10 for the "strawberry", 5 spaces from left

        Console.WriteLine("{0, 10:C1}", number); // currency - number after C...decimal digits

        // Special characters - escaping
        Console.WriteLine("C:\\Documents\\SomeTextFile.txt"); // C:\Documents\SomeTextFile.txt -- ERROR \
        Console.WriteLine(@"C:\Documents\SomeTextFile.txt");
        Console.WriteLine("Some text that needs \"quatation marks\"!"); // without \ - ERROR
        Console.WriteLine(@"Some text that needs ""quatation marks""!");
        Console.WriteLine("Some text that needs a 'single quatation mark' ");
    }
}
