using System;
using Microsoft.VisualBasic;

namespace Assignment3_Gurvir
{
    //STUDENT NAME: Gurvir Singh
    //STUDENT ID: #301108852
    //COURSE NAME: Programming 2 SEC.001
    //COURSE CODE: COMP-123
    //ASSIGNMENT 3
    //DATE LAST MODIFIED: 2020-07-20

    class Program
    {
        static void Main(string[] args)
        {
            //a new GiantPlanet object created.
            Console.WriteLine("============================================");
            GiantPlanet Jupiter = new GiantPlanet("Jupiter", 139820, 1.898E27, "Gas" );
            Jupiter.MoonCount = 67;
            Jupiter.RingCount = 4;
            Console.WriteLine(Jupiter.ToString());
            Console.WriteLine("============================================");
            Console.WriteLine("");

            //a new TerrestrialPlanet object created.
            Console.WriteLine("============================================");
            TerrestrialPlanet Earth = new TerrestrialPlanet("Earth", 12742, 5.972E24, true);
            Earth.MoonCount = 1;
            Console.WriteLine(Earth.ToString());
            Console.WriteLine("============================================");
            Console.WriteLine("");
            
            Console.WriteLine("Please press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
