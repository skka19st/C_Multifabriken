// namespace som används
using System;
using System.Collections.Generic;

namespace C_Multifabriken
{
    // public = klassen kan användas av andra projekt
    // standard är 'internal' = endast det egna projektet kan använda
    public class cGodis
    {
        // deklaration av klassens data
        private string smak;
        private string antal;        
        
        // data tas in från skärmen
        public void InitData()
        {
            Console.WriteLine("val: beställ godis");
            Console.Write("vilken smak? ");
            smak = Console.ReadLine();
            Console.Write("antal: ");
            antal = Console.ReadLine();
        }

        // data i utskrift-format
        public void VisaData()
        {
            Console.WriteLine($"{antal} st godis med smak av {smak}");
        }       
    }
}