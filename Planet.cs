using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * Name - Gurmanpreet Kaur 
 * Date - 25 July , 2017
 * Description - This is my Abstarct class called Planet
 * Version 0.1 - Created Abstarct class 
 * */
namespace Assignment04_Abstract_Planets
{
    /// <summary>
    /// This is my Abstract class
    /// </summary>
    public abstract class Planet
    {
        //private instance variables
        private double _diameter;
        private double _mass;
        private int _mooncount;
        private string _name;
        private double _orbitalPeriod;
        private int _ringcount;
        private double _rotationPeriod;

        //public properties
        public double Diameter
        {
            get
            {
                return this._diameter;
            }
        }
        public double Mass
        {
            get
            {
                return this._mass;
            }
        }
        public int MoonCount
        {
            get
            {
                return this._mooncount;
            }
            set
            {
                this._mooncount = value;
            }
        }
        public string Name
        {
            get
            {
                return this._name;
            }
        }
            
            public double OrbitalPeriod
        {
            get
            {
                return this._orbitalPeriod;
            }
            set
            {
                this._orbitalPeriod = value;
            }
        }

        public int RingCount
        {
            get
            {
                return this._ringcount;
            }
            set
            {
                this._ringcount = value;
            }
        }
        public double RotationPeriod
        {
            get
            {
                return this._rotationPeriod;
            }
            set
            {
                this._rotationPeriod = value;
            }
        }

        //Constructors-------------------------------------------------------
        /// <summary>
        /// this is my main constructor for the Planet class
        /// it takes three parameters - name(string) ,  diameter(double), mass(double)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="diameter"></param>
        /// <param name="mass"></param>
        public Planet(string name,double diameter,double mass)
        {
            this._name = name;
            this._diameter = diameter;
            this._mass = mass; 
        }

        /// <summary>
        /// this is the inbulit override method that provides format of output
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return string.Format("Name of planet:{0} \n Diameter:{1}\n  Mass:{2} ",this.Name,this.Diameter,this.Mass);
        }
    }
}
