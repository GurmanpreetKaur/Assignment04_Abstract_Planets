using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name - Gurmanpreet Kaur 
 * Date - 25 July , 2017
 * Description - This is my GaintPlanet class which is a derived class from Abstract class Planet
 * Version 0.1 - Created Abstract class  
 * */
namespace Assignment04_Abstract_Planets
{
    public class GaintPlanet : Planet
    {
        //private instance variables
        private string _type;
        /// <summary>
        /// this is the constructor of my GaintPlanet class
        /// it takes 4 arguments - name(string) , diameter(double), mass(double), type(string)
        /// name , diameter , mass are from the Planet class
        /// </summary>
        /// <param name="name"></param>
        /// <param name="diameter"></param>
        /// <param name="mass"></param>
        /// <param name="type"></param>
       public GaintPlanet(string name,double diameter,double mass,string type)
            :base(name,diameter,mass)
        {
            this._type = type;
        }

        /// <summary>
        /// this is the HasMoons() method which returns a bool value
        /// it returns true if MoonCount is greater than 0 , otherwise false
        /// </summary>
        /// <returns>bool</returns>
        public bool HasMoons()
        {
            if (this.MoonCount > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// this is the HasRings method() which returns a bool value
        /// it returns true if HasRings is greater than 0 , otherwise false
        /// </summary>
        /// <returns></returns>
        public bool HasRings()
        {
            if (this.RingCount > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}