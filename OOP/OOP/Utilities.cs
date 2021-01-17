using System;

namespace OOP
{
    static class Utilities // can not has a contructor
    {
        //public Utilities() { } // ERROR

        public static void ColorfulWriteLine(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
