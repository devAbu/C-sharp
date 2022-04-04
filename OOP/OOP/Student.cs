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

        public void ShowDetails()
        {
            Console.WriteLine("Student Information:");
            Console.WriteLine("ID: {0} -- Name: {1} -- Address: {2}", StudentID, Name, Address );
        }
    }
}
