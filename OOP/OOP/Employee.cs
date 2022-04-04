using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Employee
    {
        public double Salary;

        public virtual double CalculateSalary()
        {
            return Salary;
        }
    }
}
