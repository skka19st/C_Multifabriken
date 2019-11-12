// namespace som används
using System;
using System.Collections.Generic;

namespace C_Multifabriken
{
    // public = klassen kan användas av andra projekt
    // standard är 'internal' = endast det egna projektet kan använda
    public class cMjolk
    {
        // deklaration av klassens data
        private string fetthalt;
        private string liter;        
        
        // data tas in från skärmen
        public void InitData()
        {
            Console.WriteLine("val: beställ havremjölk");
            Console.Write("fetthalt? ");
            fetthalt = Console.ReadLine();
            Console.Write("hur många liter? ");
            liter = Console.ReadLine();
        }

        // data i utskrift-format
        public void VisaData()
        {
            Console.WriteLine($"{liter} liter mjölk med {fetthalt}% fetthalt");
        }       
    }
}