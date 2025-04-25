using System;

namespace OOPExplained.Concepts
{
    public class StaticDemo
    {
        // Tavallinen jäsenmuuttuja - jokaisella oliolla oma
        private string instanceName;
        
        // Staattinen jäsenmuuttuja - jaettu kaikkien olioiden kesken
        private static int instanceCount = 0;
        
        // Staattinen vakio
        public const string CATEGORY = "Demonstraatio";
        
        // Staattinen lukumuuttuja - voidaan asettaa vain kerran
        public static readonly DateTime StartTime = DateTime.Now;
        
        // Tavallinen rakentaja
        public StaticDemo(string name)
        {
            instanceName = name;
            instanceCount++;  // Kasvatetaan laskuria jokaisella uudella oliolla
            Console.WriteLine($"Luotu uusi olio: {instanceName}, oliomäärä yhteensä: {instanceCount}");
        }
        
        // Tavallinen metodi - voidaan kutsua vain olion kautta
        public void DisplayInfo()
        {
            Console.WriteLine($"Olio: {instanceName}");
            Console.WriteLine($"Luotu: {GetTimeSinceStart()} sekuntia ohjelman käynnistymisestä");
        }
        
        // Staattinen metodi - kutsutaan luokan nimellä, ei tarvitse oliota
        public static double GetTimeSinceStart()
        {
            return (DateTime.Now - StartTime).TotalSeconds;
        }
        
        // Staattinen ominaisuus - voidaan käyttää ilman oliota
        public static int InstanceCount
        {
            get { return instanceCount; }
        }
        
        // Staattinen metodi, joka käsittelee olioita
        public static void CompareInstances(StaticDemo a, StaticDemo b)
        {
            Console.WriteLine($"Vertaillaan olioita {a.instanceName} ja {b.instanceName}");
            Console.WriteLine($"Nämä ovat kaksi eri oliota mutta jakavat saman staattisen tilan.");
        }
        
        // Demonstraatio
        public void Explain()
        {
            Console.WriteLine("StaticDemo: Demonstroi staattisia jäseniä.");
            Console.WriteLine($"Staattinen vakio CATEGORY: {CATEGORY}");
            Console.WriteLine($"Staattinen StartTime: {StartTime}");
            Console.WriteLine($"Ohjelman käynnistymisestä kulunut aika: {GetTimeSinceStart()} sekuntia\n");
            
            Console.WriteLine("Luodaan lisää olioita staattisen tilan demonstroimiseksi:");
            StaticDemo toinen = new StaticDemo("Toinen olio");
            StaticDemo kolmas = new StaticDemo("Kolmas olio");
            
            Console.WriteLine($"\nStaattinen laskuri näyttää nyt: {InstanceCount}");
            
            Console.WriteLine("\nNäytetään oliokohtaiset tiedot:");
            DisplayInfo();
            toinen.DisplayInfo();
            kolmas.DisplayInfo();
            
            // Staattisten metodien kutsumistavat
            Console.WriteLine("\nKutsutaan staattista metodia luokan nimen kautta:");
            Console.WriteLine($"StaticDemo.GetTimeSinceStart(): {StaticDemo.GetTimeSinceStart()} sekuntia");
            
            Console.WriteLine("\nStaattinen metodi, joka käsittelee olioita:");
            StaticDemo.CompareInstances(this, toinen);
            
            Console.WriteLine("\nStaattiset jäsenet mahdollistavat:");
            Console.WriteLine("- Luokkatasoisten tietojen ja toimintojen määrittämisen");
            Console.WriteLine("- Globaalien vakioiden ja apumetodien luomisen");
            Console.WriteLine("- Tilan jakamisen kaikkien luokan olioiden kesken");
            Console.WriteLine("- Metodien käytön ilman olion luomista (utiliteetit)");
        }
    }
    
    // Täysin staattinen luokka (ei voi instantioida)
    public static class MathUtils
    {
        // Staattinen vakio
        public const double PI = 3.14159265359;
        
        // Staattinen metodi
        public static double Square(double number)
        {
            return number * number;
        }
        
        // Staattinen ominaisuus
        public static double TwoPi
        {
            get { return 2 * PI; }
        }
    }
} 