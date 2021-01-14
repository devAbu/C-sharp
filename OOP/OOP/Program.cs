using System;
using PointLines; // the namespace

class Program
{
    static void Main(string[] args)
    {
        /*
        what is OOP? 
            - The mst obvious answer for that is that this is a kind of programming that depends on objects
        What is an object?
            - Anything can be an object, person, cart, glas, etc.
            - Anything that can be described with a given set of properties is an  object
        What is properties?
            - Properties are a variables that describe a given object, height, weight, hair-color of a Person

        The objects can have their own objects within them, the car has an Engine with its own properites

        The class holds the everything together
        The class holds the properties of the given object
        Class can have a class inside the class

        WHY?
            - Lets you organize your code in multiple files, every object (or class) has its own file
            - you can easily extend your code
            - easier maintenance
            - easier to understand
         */

        // Create object
        Point point = new Point(); // new object of data type Point

        point.x = 5; // giving some value to the property
        point.y = 10;

        Console.WriteLine(point.x);
        Console.WriteLine(point.y);

    }
}