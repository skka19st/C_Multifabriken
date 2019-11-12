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
            bilmarke = "audi";
            regnr = "kcy487";
            farg = "röd";
        }
        // skapar en rad för utskrift av lagrat data
        public string SkapaUtskriftRad()
        {
            string rad = "en utskriftsrad är skapad";
            return rad;
        }       
    }
}