using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] array = { 5, 3, 2, 6, -5 };
        Console.WriteLine(array[1]);

        string dashes = new string('-', 40);

        // Array from the console - input
        Console.WriteLine("How long should the array be?");

        int lengthArray = int.Parse(Console.ReadLine());

        int[] intArray = new int[lengthArray];

        for (int i = 0; i < intArray.Length; i++)
        {
            Console.WriteLine("Please enter the {0} item: ", i);
            intArray[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine(dashes);

        for (int i = 0; i < intArray.Length; i++)
        {
            Console.WriteLine(array[i]);
        }

        Console.WriteLine(dashes);

        foreach (var item in intArray)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine(dashes);

        Console.WriteLine(string.Join("|", intArray));

        // Value type = Primitive type
        int someNumber = 5;
        int secondNumber = someNumber;

        someNumber++;
        Console.WriteLine(someNumber);
        Console.WriteLine(secondNumber);

        int[] someArray = { 1, 2, 3 };
        int[] secondArray = someArray;

        someArray[0] = 10;
        Console.WriteLine(someArray[0]);
        Console.WriteLine(secondArray[0]);

        // Clone / Duplicate -  array
        int[] array1 = { 1, 2, 3, 4, 5 };
        int[] clonedArray = array1; // reference

        Console.WriteLine(string.Join(" ,", array1));
        Console.WriteLine(string.Join(" ,", clonedArray));

        array1[2] = 10;
        Console.WriteLine(string.Join(", ",array1));
        Console.WriteLine(string.Join(", ", clonedArray));

        clonedArray[0] = 50;
        Console.WriteLine(string.Join(", ", array1));
        Console.WriteLine(string.Join(", ", clonedArray));

        // to clone an array
        int[] clonedArray2 = (int[])array1.Clone();
        array1[3] = 100;
        Console.WriteLine(string.Join(", ", array1));
        Console.WriteLine(string.Join(", ", clonedArray2));

        Console.WriteLine(dashes);

        // Reference as array
        int[] refArray = { 1, 2, 3, 4 };
        int[] tempArray = new int[refArray.Length];
        Console.WriteLine(string.Join(", ", refArray));
        Console.WriteLine(string.Join(", ", tempArray));

        for (int i = 0; i < refArray.Length; i++)
        {
            tempArray[refArray.Length - 1 - i] = refArray[i];
        }

        refArray = (int[])tempArray.Clone();
        Console.WriteLine(string.Join(", ", refArray));
        Console.WriteLine(string.Join(", ", tempArray));

        Console.WriteLine(new string('-', 40));

        Array.Reverse(refArray);
        Console.WriteLine(string.Join(", ", refArray));

        // Bubble sort
        int[] bubbleArray = { 5, 80, 62, -5, 0 };
        int temp = 0;
        Console.WriteLine(string.Join(" * ", bubbleArray));

        for (int i = 0; i < bubbleArray.Length; i++)
        {
            for (int j = 0; j < bubbleArray.Length - 1; j++)
            {
                if(bubbleArray[j] > bubbleArray[j + 1])
                {
                    temp = bubbleArray[j + 1];
                    bubbleArray[j + 1] = bubbleArray[j];
                    bubbleArray[j] = temp;
                }
            }
            Console.WriteLine("New iteration");
            Console.WriteLine(string.Join(" * ", bubbleArray));
        }

        Console.WriteLine(string.Join(" * ", bubbleArray));

        // easier way
        Array.Sort(bubbleArray);
        Console.WriteLine(string.Join(" * ", bubbleArray));

        // chech array for symmetry

        // 1 2 3 4 4 3 2 1 - symmetric array
        // 1 2 3 4 3 2 1 - symmetric array
        // 1 2 3 4 2 3 1 - not symmetric array

        Console.WriteLine("How long should the array be?");

        int lengthArraySymmetric = int.Parse(Console.ReadLine());

        int[] intArraySymmetric = new int[lengthArraySymmetric];

        for (int i = 0; i < intArraySymmetric.Length; i++)
        {
            Console.WriteLine("Please enter the {0} item: ", i);
            intArraySymmetric[i] = int.Parse(Console.ReadLine());
        }

        bool isSymmetric = true;

        for (int i = 0; i < intArraySymmetric.Length / 2; i++)
        {
            if(intArraySymmetric[i] != intArraySymmetric[intArraySymmetric.Length - 1 - i]) 
            {
                isSymmetric = false;
                break;
            }
        }

        Console.WriteLine(isSymmetric);

        // Enter array element at once
        Console.WriteLine("Enter your array: ");
        string rawArray = Console.ReadLine();

        int[] newArray = rawArray.Split(' ')
            .Select(elements => int.Parse(elements))
            .ToArray();

        Console.WriteLine(string.Join(" - ", newArray));

        // Lists - dynamic array

        List<int> someList = new List<int>(); // Initialize

        someList.Add(5);
        someList.Add(3);
        someList.Add(10);

        Console.WriteLine(string.Join(" - ", someList));

        someList[2] = 100;

        Console.WriteLine(string.Join(" - ", someList));

        someList.RemoveAt(0); // by index

        Console.WriteLine(string.Join(" - ", someList));

        someList.Remove(3); // by value

        Console.WriteLine(string.Join(" - ", someList));

        Console.WriteLine(someList.Count); // length of the list

        someList.Clear(); // delete everything inside the list

    }
}
