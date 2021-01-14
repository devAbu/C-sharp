using System;

namespace PointLines // the name of the folder
{
    /*
     Contructor has the name of the class, does not have any data type, may or may not take arguments

    For example: Human class - contructor with two arguments height and weight...we don't want to have any human without height or wieght
     
     */

    class Point
    {
        public int x;
        public int y;
        public int z;

        public Point() { }

        public Point(int x, int y)
        {
            // this gives you access to the memebers of your class and leys you distinguish between two variables or methods that have the same name
            this.x = x;
            this.y = y;
            this.z = 5; // this keyword is optional here
        }
    }
}