using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3_Gurvir
{
    //this class inherits from abstract class named Planet, it extends that class
    class GiantPlanet : Planet
    {
        //fields (private instance variables):
        private string _type;

        //constructor:
        public GiantPlanet(string name, double diameter, double mass, string type) : base(name, diameter, mass)
        {
            type = _type;
        }

    }
}
