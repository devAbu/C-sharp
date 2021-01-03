using System;
using System.IO;

class Program
{
    static void Main()
    {
        //int number = int.Parse(Console.ReadLine()); // if we enter string we will get an error/exception

        // Ignore the error
        //try
        //{
        //    int number = int.Parse(Console.ReadLine());
        //}
        //catch (Exception)
        //{


        //}
        try
        {
            int number = int.Parse(Console.ReadLine()); // can not be access outside the try block
        }
        catch (FormatException)
        {
            Console.WriteLine("Your input is incorrect, please input a number");
        }

        // The first reason is that this is guarding your code - defensive programming
        // The second resaon is for a better user experience

        // Catch Multiple exceptions
        try
        {
            int number = int.Parse(Console.ReadLine());
            int divided = 5 / number;

            Console.WriteLine($"Five divided by {number} is: {divided}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Please enter a number");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("It can not be divided by 0");
        }
        catch (Exception) //any exception
        {
            Console.WriteLine("This is some generic exception");
        }

        // Use the exception as a variable

        try
        {
            int number = int.Parse(Console.ReadLine());
            int divided = 5 / number;

            Console.WriteLine($"Five divided by {number} is: {divided}");
        }
        catch (FormatException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine(ex.Message);
        }

        // Finally -  Real World example
        StreamWriter sw = null;
        try
        {
            sw = File.AppendText(Directory.GetCurrentDirectory() + @"\test.txt");

            int number = int.Parse(Console.ReadLine());
            int divided = 5 / number;

            sw.WriteLine(number);
            

            Console.WriteLine($"Five divided by {number} is: {divided}");
        }
        catch (FormatException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally 
        { 
            sw.Close(); 
        }

        try
        {
            StreamReader sr = File.OpenText(Directory.GetCurrentDirectory() + @"\test.txt");
        }
        catch (IOException ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            sw.Close();
        }
    }
}

