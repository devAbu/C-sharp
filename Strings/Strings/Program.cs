using System;
using System.Text;

class Program
{
    static void Main()
    {
        // Extract substring from a string
        string directoryPath = @"C:\Program Files\Winamp.exe";

        string pathToFile = directoryPath.Substring(0, directoryPath.LastIndexOf('\\') + 1);
        string fileName = directoryPath.Substring(directoryPath.LastIndexOf('\\') + 1, directoryPath.LastIndexOf('.') - directoryPath.LastIndexOf('\\') -1);
        string fileType = directoryPath.Substring(directoryPath.LastIndexOf('.'));

        Console.WriteLine(pathToFile);
        Console.WriteLine(fileName);
        Console.WriteLine(fileType);

        // Splitting a string with specific conditions
        string drinks = "coffee - water!!! cocaCola     pepsi# milkshake.. beer wine whisky";

        char[] splitCharacter = {'!', ' ', '@', '#', '.', ',', '/', '\\', '-' };
        string[] splitDrinks = drinks.Split(splitCharacter, StringSplitOptions.RemoveEmptyEntries);

        foreach (var drink in splitDrinks)
        {
            Console.WriteLine(drink);

        }

        // Replacing a substring with a string
        string drinks2 = "coffee water cocaCola pepsi milkshake beer wine whisky";

        string replacedString = drinks2.Replace('a', '2');
        Console.WriteLine(replacedString);

        string replacedString2 = drinks2.Replace("water", "!!!!");
        Console.WriteLine(replacedString2);

        // Remove substring from a string
        string removeDrinks = drinks2.Remove(drinks2.IndexOf("water"));
        Console.WriteLine(removeDrinks);
        string safeWord = "water";
        string removeDrinks2 = drinks2.Remove(drinks2.IndexOf("water") + safeWord.Length);
        Console.WriteLine(removeDrinks2);
        string removeDrinks3 = drinks2.Remove(drinks2.IndexOf("water") + safeWord.Length, drinks2.IndexOf("whisky") - (drinks2.IndexOf("water") + safeWord.Length) -1);
        Console.WriteLine(removeDrinks3);

        // Trimming whitespaces and other characters
        string drinks3 = "     coffee water cocaCola pepsi milkshake beer wine whisky!!!!...!!!   ";
        Console.WriteLine(drinks3.Trim());
        Console.WriteLine(drinks3.Trim('!'));
        char[] charsToTrim = { '!', ' ', '.' };
        Console.WriteLine(drinks3.Trim(charsToTrim));
        Console.WriteLine(drinks3.TrimEnd());
        Console.WriteLine(drinks3.TrimStart());

        // String Builder - standard concatenate is slower
        StringBuilder sb = new StringBuilder();

        sb.Append("speakers");
        sb.Append(5); // automatically converted to string
        sb.Append("display");

        string stringBuilderString = sb.ToString();

        Console.WriteLine(sb);
        Console.WriteLine(stringBuilderString);

        // is it faster?
        DateTime start = DateTime.Now;
        string testOne = Concatenator('a', 50000);
        DateTime end = DateTime.Now;

        Console.WriteLine(end - start);

        DateTime start2 = DateTime.Now;
        string testOne2 = ConcatenatorSB('a', 50000000);
        DateTime end2 = DateTime.Now;

        Console.WriteLine(end2 - start2);
    }

    static string Concatenator(char character, int count)
    {
        string someString = "";

        for (int i = 0; i < count; i++)
        {
            someString += character;
        }

        return someString;
    }

    static string ConcatenatorSB(char character, int count)
    {
        StringBuilder someString = new StringBuilder();

        for (int i = 0; i < count; i++)
        {
            someString.Append(character);
        }

        return someString.ToString();
    }
}
