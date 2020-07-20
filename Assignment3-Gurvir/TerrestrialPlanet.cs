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

    //this class inherits from abstract class named Planet, it extends that class
    class TerrestrialPlanet : Planet
    {
        //fields (private instance variables):
        private bool _oxygen;

        //constructor:
        public TerrestrialPlanet(string name, double diameter, double mass, bool oxygen)
            : base(name, diameter, mass)
        {
           _oxygen = oxygen;
        }

        //public methods
        //IHabitable() and IHasMoons interfaces implemented
        public bool Habitable()
        {
         if(_oxygen == true)
            {
                return true;
            }
         else
            {
                return false;
            }
        }

        public bool HasMoons()
        {
            if (MoonCount > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //This method overrides the inherited ToString() method
        public override string ToString()
        {
            string outputstring = "";
            outputstring += $"Name:          {Name}                     \n";
            outputstring += $"Mass:          {Mass}   Kg \n";
            outputstring += $"Diameter:      {Diameter}       Km \n";
            outputstring += $"Has Oxygen:    {_oxygen}       \n";
            outputstring += $"Has Moons:     {HasMoons()}            \n";
            outputstring += $"Is Habitable:  {Habitable()}            \n";
            return outputstring;

        }
    }
}
