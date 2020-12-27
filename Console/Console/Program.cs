using System;
using System.Threading;

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

        // Read a character from console
        Console.WriteLine("How old are you?");
        //int userNumber = Console.Read(); // (char)Console.Read()
        //Console.WriteLine("I'am {0} years old", userNumber); // ASCII code
        //char theAge = (char)userNumber;
        //Console.WriteLine("I'am {0} years old", theAge);

        // Read a line from console
        //string userInput = Console.ReadLine(); // must be string
        //int userInputNum = int.Parse(userInput); 
        //Console.WriteLine("I'am " + userInput + " years old");

        // Read pressed key from console
        ConsoleKeyInfo myKey = Console.ReadKey();
        Console.WriteLine("I pressed {0}", myKey.Key); // KeyChar
        Console.WriteLine("" + myKey.Modifiers); // ctrl, shift...

        // change color and how to clear it
        // change font color or background
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        Console.Clear();
        Console.WriteLine("Lorem Ipsum is simply dummy text of the printing and typesetting industry.");
        Console.WriteLine("Lorem Ipsum has been the industry's standard dummy text ever since the 1500s");
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("when an unknown printer took a galley of type and scrambled it to make a type specimen book.");
        Console.ForegroundColor = ConsoleColor.White; // or Console.ResetColor() - default color
        Console.WriteLine("It has survived not only five centuries,");
        Thread.Sleep(1500);
        Console.ResetColor();
        Console.Clear();

        // Easier way - method / function
        colorfulMessage("Hello");

        // Change the cursor setting and the console's title
        Console.CursorVisible = false; // true
        Console.SetCursorPosition(5, 5); // first is left, second is top
        Console.Title = "Abu";
        Console.WriteLine("It has survived not only five centuries,");
        Thread.Sleep(1500);
        Console.CursorVisible = true;

        // controle the size of the console
        //Console.WindowHeight = 20;
        //Console.WindowWidth = 150;
        Console.SetWindowSize(150, 20);
        //Console.BufferHeight = 20; // no scroll-bar
        //Console.BufferWidth = 50;
        Console.SetBufferSize(50, 20);
        //Console.WindowLeft = 5;
        //Console.WindowTop = 5;
        Console.SetWindowSize(5, 5);
    }
    static void colorfulMessage(string message)
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine(message);
        Console.ResetColor();
    }
}
