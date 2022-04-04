using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Example
    {
        public Example()
        {
        Console.WriteLine("Constructor called");
        }

        //desctructor
        ~Example()
        {
            //TO DO: Clean up unmanaged objects
            Console.WriteLine("Desctructor called to clean up unmanaged objects");
        }
    }
}
