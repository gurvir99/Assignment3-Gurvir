using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3_Gurvir
{
    //this class inherits from abstract class named Planet, it extends that class
    class TerrestrialPlanet : Planet
    {
        //fields (private instance variables):
        private bool _oxygen;

        //constructor:
        public TerrestrialPlanet(string name, double diameter, double mass, bool oxygen)
            : base(name, diameter, mass)
        {
            oxygen = _oxygen;
        }

        //public methods
        //IHabitable() and IHasMoons interfaces implemented
        public bool Habitable()
        {
            if (_oxygen == true)
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
    }
}
