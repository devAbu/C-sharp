using System;

namespace PointLines // the name of the folder
{
    /*
     Contructor has the name of the class, does not have any data type, may or may not take arguments

    For example: Human class - contructor with two arguments height and weight...we don't want to have any human without height or wieght
     
     */

    class Point
    {
        public int X;
        public int Y;

        public Point() { }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}