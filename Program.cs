using System;
using System.Collections.Generic;

namespace C_Multifabriken
{
    class Program
    {
        // fyra listor som lagrar beställda varor av en viss artikel
        static private List<cBilar> listaBilar = new List<cBilar>();
        static private List<cGodis> listaGodis = new List<cGodis>();            
        static private List<cPipes> listaPipes = new List<cPipes>();
        static private List<cMjolk> listaMjolk = new List<cMjolk>();

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
            cBilar bil = new cBilar();
            bil.InitData();
            listaBilar.Add(bil);
        }
        static void BestallGodis()
        {
            cGodis godisbit = new cGodis();
            godisbit.InitData();
            listaGodis.Add(godisbit);           
        }
        static void BestallPipes()
        {
            cPipes pipe = new cPipes();
            pipe.InitData();
            listaPipes.Add(pipe); 
        }
        static void BestallMjolk()
        {
            cMjolk mjolk = new cMjolk();
            mjolk.InitData();
            listaMjolk.Add(mjolk);
        }
        static void ListaBestallning()
        {
            Console.WriteLine("Detta är beställt så här långt:");

            // utskrift av beställda bilar
            foreach (cBilar rad in listaBilar)
            {
                rad.VisaData();
            }

            // utskrift av beställt godis
            foreach (cGodis rad in listaGodis)
            {
                rad.VisaData();
            }

            // utskrift av beställda rör
            foreach (cPipes rad in listaPipes)
            {
                rad.VisaData();
            }

            // utskrift av beställd mjölk
            foreach (cMjolk rad in listaMjolk)
            {
                rad.VisaData();
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
