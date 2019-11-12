using System;
using System.Collections.Generic;

namespace C_Multifabriken
{
    class Program
    {
        // fyra listor som lagrar beställda varor av en viss artikel
        static private List<cBilar> listaBilar = new List<cBilar>();
        // List<cBilar> listaGodis = new List<cGodis>();            
        // List<cBilar> listaPipes = new List<cPipes>();
        // List<cBilar> listaMjolk = new List<cMjolk>();

        static void Main(string[] args)
        {
            // loop som avslutas med val '6 - Avsluta'
            bool fortsatt = true;
            while (fortsatt) 
            {
                // ta in menyval från skärmen
                string svar = HanteraMeny();

                // innehållet i variabeln 'svar' testas
                switch(svar)
                {                    
                    case "1":               // beställ bil
                        BestallBil();
                        break;                    
                    case "2":               // beställ godis
                        BestallGodis();
                        break;                    
                    case "3":               // beställ rör
                        BestallPipes();
                        break;                    
                    case "4":               // beställ havremjölk
                        BestallMjolk();
                        break;                    
                    case "5":               // lista beställda artiklar
                        ListaBestallning();
                        break;                    
                    case "6":               // avsluta
                        Avsluta();
                        fortsatt = false;
                        break;                    
                    default:                // hopsamlingsheat för 'icke träff'
                        FelaktigtVal();
                        break;
                }
            }            
        }
        static string HanteraMeny()
        {
            Console.WriteLine(" ");
            Console.WriteLine("Välkommen till Multifabriken!");
            Console.WriteLine("[1] Beställ bil");
            Console.WriteLine("[2] Beställ godis");
            Console.WriteLine("[3] Beställ rör");
            Console.WriteLine("[4] Beställ havremjölk");
            Console.WriteLine("[5] Lista beställningen");
            Console.WriteLine("[6] Avsluta");

            // ta in svar från skärmen
            string menySvar = Console.ReadLine();
            return menySvar;
        }
        static void BestallBil()
        {
            Console.WriteLine("val: beställ bil");
            cBilar bil = new cBilar();
            bil.InitData();
            listaBilar.Add(bil);
            string utskriftsrad = bil.SkapaUtskriftRad();
            Console.WriteLine(utskriftsrad);
        }
        static void BestallGodis()
        {
            Console.WriteLine("val: beställ godis");
        }
        static void BestallPipes()
        {
            Console.WriteLine("val: beställ rör");
        }
        static void BestallMjolk()
        {
            Console.WriteLine("val: beställ mjölk");
        }
        static void ListaBestallning()
        {
            Console.WriteLine("Detta är beställt så här långt:");
            if (listaBilar.Count > 0)
            {
                foreach (cBilar rad in listaBilar)
                {
                    string utskriftsrad = rad.SkapaUtskriftRad();
                    Console.WriteLine(utskriftsrad);
                }
            }

        }
        static void Avsluta()
        {
            Console.WriteLine("hej då, tack för idag!");            
        }
        static void FelaktigtVal()
        {
            Console.WriteLine("Val 1-6 är möjliga");           
        }
    }
}
