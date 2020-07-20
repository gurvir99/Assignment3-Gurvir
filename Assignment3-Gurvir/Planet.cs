using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3_Gurvir
{
    //STUDENT NAME: Gurvir Singh
    //STUDENT ID: #301108852
    //COURSE NAME: Programming 2 SEC.001
    //COURSE CODE: COMP-123
    //ASSIGNMENT 3
    //DATE LAST MODIFIED: 2020-07-20

    // Planet is an abstract class 
    abstract class Planet
    {
        //fields (private instance variables):
        private double _diameter;
        private double _mass;
        private int _moonCount;
        private string _name;
        private double _orbitalPeriod;
        private int _ringCount;
        private double _rotationPeriod;

        // public properties:
        public double Diameter
        {
            get
            {
                return _diameter;
            }
        }

        public double Mass
        {
            get
            {
                return _mass;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }

        public int MoonCount
        {
            get
            {
                return _moonCount;
            }
            set
            {
                _moonCount = value;
            }
        }

        public double OrbitalPeriod
        {
            get
            {
                return _orbitalPeriod;
            }
            set
            {
                _orbitalPeriod = value;
            }
        }

        public int RingCount
        {
            get
            {
                return _ringCount;
            }
            set
            {
                _ringCount = value;
            }
        }

        public double RotationPeriod
        {
            get
            {
                return _rotationPeriod;
            }
            set
            {
                _rotationPeriod = value;
            }
        }

        //constructor
        public Planet(string name, double diameter, double mass)
        {
            _name = name;
            _diameter = diameter;
            _mass = mass;
        }

        //public methods
        //This method overrides the inherited ToString() method and returns the name, mass and diameter to the console.
        public override string ToString()
        {
            string output = "";
            output += $"Name:     {Name}                     \n";
            output += $"Mass:     {Mass}     Kg \n";
            output += $"Diameter: {Diameter}        Km \n";
            return output;

        }

    }
}
