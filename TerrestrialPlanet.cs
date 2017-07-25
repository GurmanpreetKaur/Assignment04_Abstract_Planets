using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * Name - Gurmanpreet Kaur 
 * Date - 25 July , 2017
 * Description - This is my Terrestrial Planet class which is derived from Planet Abstract class
 * Version 0.1 - Created TerrestrailPlanet class
 * */
namespace Assignment04_Abstract_Planets
{
    public class TerrestrialPlanet : Planet
    {

        //private instance variables
        private bool _oxygen;
        // Constructors----------------------------------------------
        /// <summary>
        /// this is my main constructor of TerrestrailPlanet class
        /// it takes 4 arguments - name(string) , diameter (double), mass (double), oxygen(bool)
        /// name,diameter, mass are from Planet Abstract class
        /// </summary>
        /// <param name="name"></param>
        /// <param name="diameter"></param>
        /// <param name="mass"></param>
        /// <param name="oxygen"></param>
        public TerrestrialPlanet(string name, double diameter, double mass, bool oxygen) : base(name, diameter, mass)
        {
            this._oxygen = oxygen;
        }
        //public methods
        /// <summary>
        /// this is HasMoons() method which returns a bool value
        /// it returns true if the planet has moons , otherwise false
        /// </summary>
        /// <returns></returns>
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
        /// this is Habitable() method which returns a bool value
        /// it returns true if the planet has oxygen for living , otherwise false
        /// </summary>
        /// <returns></returns>
        public bool Habitable()
        {
            if (this._oxygen == true)
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