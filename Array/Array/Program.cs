using System;
class Program
{
    static void Main(string[] args)
    {
        string someArray = "array"; // array of char
        Console.WriteLine(someArray[0]);

        //string[] stringArray = new string[5];
        //stringArray[0] = "abu";
        //stringArray[1] = "combe";
        //stringArray[2] = "kum";

        string[] stringArray = { "abu", "combe", "kum" };
        Console.WriteLine(stringArray[0]);
        Console.WriteLine(stringArray.Length);

        int[] numArray = { 0, 5, 10 };
        Console.WriteLine(numArray[2]);
        Console.WriteLine(numArray.Length);

        // Convert any data type to string
        int someCrazyNumber = 456789;
        Console.WriteLine(someCrazyNumber);
        Console.WriteLine(someCrazyNumber.GetType());

        string numberToString = someCrazyNumber.ToString();
        Console.WriteLine(numberToString);
        Console.WriteLine(numberToString.GetType());

        bool theTrue = true;
        Console.WriteLine(theTrue.ToString()[2]);

        // tips and tricks - string
        // Contains, Index of, Last index of, lower/uppercase, to char array, new string

        string coffeeMug = "coffE";

        Console.WriteLine(coffeeMug.Contains("w")); // TRUE OR FALSE
        Console.WriteLine(coffeeMug.Contains("off"));

        Console.WriteLine(coffeeMug.IndexOf("a")); // the index of char....or -1
        Console.WriteLine(coffeeMug.IndexOf("of")); // The first = 1 - o
        Console.WriteLine(coffeeMug.LastIndexOf("f")); // the last = 3 - the last f

        Console.WriteLine(coffeeMug.ToLower());
        Console.WriteLine(coffeeMug.ToUpper());

        Console.WriteLine(coffeeMug.IndexOf("e")); // -1...because we have E not e
        Console.WriteLine(coffeeMug.ToLower().IndexOf("e"));

        char[] coffeCharArray = coffeeMug.ToCharArray();

        Console.WriteLine(new string('-', 3));

        // Converting, parsing, Casting
        int someNumber = 5;
        string word = "7";
        char x = '5';
        float floating = 3.14f;

        int someInt = (int)floating; // casting
        string convertedChar = x.ToString(); // (string)x -- ERROR

        // CONVERTING - will not give an error if it is null
        someNumber = Convert.ToInt32(word); // (int)word -- ERROR
        someNumber = (int)Char.GetNumericValue(x);

        // PARSING - will give an error if it is null
        someNumber = int.Parse(word);

        // RANDOM NUMBER
        Random rng = new Random();
        Console.WriteLine(rng.Next());
        Console.WriteLine(rng.Next(0, 10)); // between 0 and 10
    }
}
