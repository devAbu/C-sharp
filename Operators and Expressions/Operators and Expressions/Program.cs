using System;
class Program
{
    static void Main()
    {
        //Aritjmetic Operators: + - * / % ++ --
        int firstNumber = 15;
        int secondNumber = 10;

        int addResult = firstNumber + secondNumber;
        Console.WriteLine(addResult);
        int subResult = firstNumber - secondNumber;
        Console.WriteLine(subResult);
        int multResult = firstNumber * secondNumber;
        Console.WriteLine(multResult);
        int divResult = firstNumber / secondNumber;
        Console.WriteLine(divResult);
        double divResult2 = (double)firstNumber / (double)secondNumber;
        Console.WriteLine(divResult2);

        Console.WriteLine(firstNumber++);
        Console.WriteLine(firstNumber--);
        int modResult = firstNumber % secondNumber;
        Console.WriteLine(modResult);

        // Logical Operators: && || ! ^
        bool theTrue = true;
        bool theFalse = false;

        Console.WriteLine(theTrue && theFalse);
        Console.WriteLine(theTrue || theFalse);
        Console.WriteLine(theTrue ^ theFalse);
        Console.WriteLine(!theTrue);
        Console.WriteLine(!theFalse);
        Console.WriteLine((theTrue || theFalse) && theTrue);

        // Compare: == != < > <= >=
        string cat = "cat";
        string secondCat = "cat";
        string dog = "dog";
        int num1 = 10;
        int num2 = 15;

        Console.WriteLine(cat == secondCat);
        Console.WriteLine(cat == dog);
        Console.WriteLine(num1 == num2);

        Console.WriteLine(cat != secondCat);
        Console.WriteLine(cat != dog);
        Console.WriteLine(num1 != num2);

        Console.WriteLine(num1 > num2);
        Console.WriteLine(num1 >= num2);
        Console.WriteLine(num1 < num2);
        Console.WriteLine(num1 <= num2);

        // assignment operators: = += -+ *= /= %= &= |= ^=
        int someNumber = 1;
        int someNumberTwo = 5;
        int result = 0;
        result += 5;
        Console.WriteLine(result);
        result -= 5;
        Console.WriteLine(result);
        result *= 2;
        Console.WriteLine(result);
        result /= 2;
        Console.WriteLine(result);
        result %= 5;
        Console.WriteLine(result);

        bool theTrueValue = true;

        theTrueValue |= true;
        Console.WriteLine(theTrueValue);
        theTrueValue |= false;
        Console.WriteLine(theTrueValue);
        theTrueValue &= true;
        Console.WriteLine(theTrueValue);
        theTrueValue &= false;
        Console.WriteLine(theTrueValue);
        theTrueValue ^= true;
        Console.WriteLine(theTrueValue);
        theTrueValue ^= false;
        Console.WriteLine(theTrueValue);

        // Unary: - + -- ++
        // Binary: - + <= >= ==
        // Ternary: expression ? true : false

        Console.WriteLine(-7);
        Console.WriteLine(5);
        Console.WriteLine(5 + 7);
        Console.WriteLine(2 - 1);
        Console.WriteLine(5 >= 7);
        Console.WriteLine(5 <= 7);
        Console.WriteLine(5 == 7);
        Console.WriteLine("str" + "ing");

        int someNumber1 = 4;
        int someNumber2 = 7;

        string ternaryResult = (someNumber1 < someNumber2) ? "4 is less than 7" : "4 is not less than 7";
        Console.WriteLine(ternaryResult);
        Console.WriteLine((someNumber1 < someNumber2) ? "4 is less than 7" : "4 is not less than 7");

        int even = 4;
        int odd = 5;

        Console.WriteLine(even % 2);
        Console.WriteLine(odd % 2);

        if(even % 2 == 0)
        {
            Console.WriteLine("The number is even");
        }else
        {
            Console.WriteLine("The number is odd");
        }

        Console.WriteLine((even % 2 == 0 ? "The number is even" : "The number is odd"));
    }
}
