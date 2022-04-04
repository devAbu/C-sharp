using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class SalesEmployee : Employee
    {
        public double SalesBonus;

        //public override double CalculateSalary()
        //{
        //    return Salary + SalesBonus;
        //}

        public new double CalculateSalary()
        {
            return Salary + SalesBonus;
        }
    }
}
