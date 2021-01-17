﻿using System;
using OOP;
using PointLines; // the name space

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
        //Point point = new Point(5,10); // new object of data type Point
        //Console.WriteLine(point.X);
        //Console.WriteLine(point.Y);

        Point pointTwo = new Point();
        pointTwo.X = 5; // giving some value to the property
        pointTwo.Y = 8;

        Console.WriteLine(pointTwo.X);
        Console.WriteLine(pointTwo.Y);

        Point newPoint = new Point();

        //newPoint.Username = "abud"; // ERROT - READ-ONLY (GET)
        newPoint.Password = 5;

        //Console.WriteLine(newPoint.Password); // ERROR - WRITE-ONLY (SET)

        // access static

        //Point.ID = 11;
        Console.WriteLine(Point.currentID);

        //newPoint.id = 100; // ERROR - READONLY

        // ENUM
        Console.WriteLine(newPoint.race);

        // STATIC CLASS

        Utilities.ColorfulWriteLine("juhu huju", ConsoleColor.Red);

        newPoint.SayMyName();
    }
}