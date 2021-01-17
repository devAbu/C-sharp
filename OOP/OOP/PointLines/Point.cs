using System;

namespace PointLines // the name of the folder
{
    /*
     Contructor has the name of the class, does not have any data type, may or may not take arguments

    For example: Human class - contructor with two arguments height and weight...we don't want to have any human without height or wieght
     
     */

    class Point
    {
        private int x; // -- FIELD -- accessable only inside the class
        private int y;
        private int z;

        // STATIC - does not need an instance - can be accessed without creating a new instance / object of the class
        public static int currentID;

        public const int ID = 12; // CONST - hardcoded value -- THE_CONST_NAME
        public readonly int id; //  READ-ONLY - value assigned at runtime through code logic

        // ENUMERATIONS - define a set of constants which can be used to milit some kind of options or variables (for example: chosee BLACK or WHITE)
        // Race.cs
        public Race race;


        //public int X
        //{
        //    get
        //    {
        //        return x;
        //    }
        //    set
        //    {
        //        x = value;
        //    }
        //}

        public int X { get; set; } // Getter and setter -- PROPERTY - access and modify the values of thefield
        public int Y { get; set; }
        public Point()
        {
            currentID++; id = currentID; race = Race.Earthling; // or Marsian 
        }

        public Point(int x, int y)
        {
            // this gives you access to the memebers of your class and leys you distinguish between two variables or methods that have the same name
            this.x = x;
            this.y = y;
            this.z = 5; // this keyword is optional here

            currentID++;
            id = currentID;
        }

        private string username;
        private int password;

        public string Username
        {
            get
            {
                return username;
            }
            //READ-ONLY PROPERTY -- WE WILL SET THE USERNAME VIA THE CONSTRUCTOR
            //set
            //{
            //    if(value.Length >= 4 && value.Length <= 10)
            //        username = value;
            //    else
            //        Console.WriteLine("Invalid");
            //}
        }

        public int Password
        {
            // WRITE-ONLY PROPERTY
            //get
            //{
            //    return password;
            //}
            set
            {
                if (value >= 4 && value <= 10)
                    password = value;
                else
                    Console.WriteLine("Invalid password");
            }
        }
    }
}