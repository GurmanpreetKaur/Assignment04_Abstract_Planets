using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Name - Gurmanpreet Kaur 
 * Date - 25 July , 2017
 * Description - This is my main program(driver class) for the project
 * Version 0.1 - Created main program 
 * */
 
namespace Assignment04_Abstract_Planets
{
    class Program
    {
        static void Main(string[] args)
        {
            GaintPlanet Gaint = new GaintPlanet("Mercury", 4879, 3.285, "solid");
            Console.WriteLine(Gaint.ToString());
            Console.WriteLine();
            TerrestrialPlanet teri = new TerrestrialPlanet("Earth", 12742, 5.972, true);
            Console.WriteLine(teri.ToString());
            WaitForAnyKey();

        }
        public static void WaitForAnyKey()
        {
            string output = "Please enter any key to continue";
            Console.WriteLine(output);

        }
    }
    }
}
