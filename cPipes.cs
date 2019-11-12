// namespace som används
using System;
using System.Collections.Generic;

namespace C_Multifabriken
{
    // public = klassen kan användas av andra projekt
    // standard är 'internal' = endast det egna projektet kan använda
    public class cPipes
    {
        // deklaration av klassens data
        private string diameter;
        private string lengd;        
        
        // data tas in från skärmen
        public void InitData()
        {
            Console.WriteLine("val: beställ rör");
            Console.Write("diameter (centimeter): ");
            diameter = Console.ReadLine();
            Console.Write("längd (meter): ");
            lengd = Console.ReadLine();
        }

        // data i utskrift-format
        public void VisaData()
        {
            Console.WriteLine($"{lengd} meter rör med diameter {diameter} cm");
        }       
    }
}