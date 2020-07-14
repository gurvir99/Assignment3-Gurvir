using System;

namespace Assignment3_Gurvir
{
    class Program
    {
        static void Main(string[] args)
        {
            //a new GiantPlanet object created.
            GiantPlanet Jupiter = new GiantPlanet("Jupiter", 139820, 1.898E27, "Gas" );
            Jupiter.MoonCount = 67;
            Jupiter.RingCount = 4;
            Console.WriteLine(Jupiter.ToString());
            Console.WriteLine("");


           
            
        
        }
    }
}
