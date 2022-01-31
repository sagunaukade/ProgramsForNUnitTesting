using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramforNUnitTesting
{
    internal class temperaturConversion
    {
        public void tempConversion(double celsius, double fahrenheit)

        {
           
            double celToFah = (celsius * 9 / 5) + 32;
            double fahToCel = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine("After celsius to fahrenheit conversion: {0}", celToFah);
            Console.WriteLine("After fahrenheit to celsius conversion: {0}", fahToCel);
        }
    }

}
