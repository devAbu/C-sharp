using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Student
    {
        // fields
        public int StudentID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        private static int Counter;


        //default constructor
        //public Student()
        //{
        //    //default value
        //    Address = "Dobrinja";
        //}

        // Param constructor // constructor overloading
        public Student(int stuId, string name, string addr)
        {
            this.StudentID = stuId;
            this.Name = name;
            this.Address = addr;
        }

        // Param constructor // constructor overloading
        public Student(int stuId, string name)
        {
            this.StudentID = stuId;
            this.Name = name;
        }

        // Private constructor
        private Student() { 
            Counter = 10;
        }

        //public constructor
        public Student(int counter)
        {
            Counter = Counter + counter;
        }

        // Static constructor
        static Student()
        {
            Counter = 20;
        }

        public void ShowDetails()
        {
            Console.WriteLine("Student Information:");
            Console.WriteLine("ID: {0} -- Name: {1} -- Address: {2}", StudentID, Name, Address );
        }

        public static int GetCounter()
        {
            return ++Counter;
        }

        // nested class
        public class NestedStudent
        {
            public void Test()
            {
                // internal instance
                Student student = new Student();
                // can access all of the members
            }
        }
    }
}
