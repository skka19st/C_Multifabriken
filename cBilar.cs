// namespace som används
using System;
using System.Collections.Generic;

namespace C_Multifabriken
{
    // public = klassen kan användas av andra projekt
    // standard är 'internal' = endast det egna projektet kan använda
    public class cBilar
    {
        // deklaration av klassens data
        private string bilmarke;
        private string regnr;        
        private string farg;
        
        // data tas in från skärmen
        public void InitData()
        {
            Console.WriteLine("val: beställ bil");
            Console.Write("vilket bilmärke? ");
            bilmarke = Console.ReadLine();
            Console.Write("reg.nr: ");
            regnr = Console.ReadLine();
            Console.Write("färg på bilen? ");
            farg = Console.ReadLine();
        }

        // skapar en rad för utskrift av lagrat data
        public void VisaData()
        {
            Console.WriteLine($"en {farg} {bilmarke} med regnr {regnr}");
        }       
    }
}