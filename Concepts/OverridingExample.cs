using System;

namespace OOPExplained.Concepts
{
    // Kantaluokka, jossa on virtuaalisia metodeja
    public class OverrideBaseClass
    {
        // Virtuaalinen metodi, jonka perivä luokka voi ylikirjoittaa
        public virtual void Process()
        {
            Console.WriteLine("OverrideBaseClass.Process(): Kantaluokan käsittely");
        }
        
        // Toinen virtuaalinen metodi parametreilla
        public virtual string Format(string input)
        {
            return $"Kantaluokka: {input.ToUpper()}";
        }
        
        // Tavallinen metodi, jota ei voida ylikirjoittaa
        public void NonVirtualMethod()
        {
            Console.WriteLine("OverrideBaseClass.NonVirtualMethod(): Tätä ei voi ylikirjoittaa");
        }
        
        // Virtuaalinen ominaisuus
        public virtual string Status
        {
            get { return "Kantaluokan tila"; }
        }
    }
    
    // Perivä luokka, joka ylikirjoittaa metodeja
    public class OverrideDemo : OverrideBaseClass
    {
        // Ylikirjoittaa kantaluokan virtuaalisen metodin
        public override void Process()
        {
            Console.WriteLine("OverrideDemo.Process(): Perivän luokan käsittely, korvaa kantaluokan toteutuksen");
            
            // Kutsutaan kantaluokan metodia tästä
            base.Process();
            
            Console.WriteLine("OverrideDemo.Process(): Valmis");
        }
        
        // Ylikirjoittaa kantaluokan toisen virtuaalisen metodin
        public override string Format(string input)
        {
            // Ei kutsu kantaluokan toteutusta, korvaa sen kokonaan
            return $"OverrideDemo: [{input.ToLower()}]";
        }
        
        // Ylikirjoittaa kantaluokan virtuaalisen ominaisuuden
        public override string Status
        {
            get { return "Perivän luokan tila"; }
        }
        
        // Lisää uuden metodin, joka ei ylikirjoita mitään
        public void ExtraMethod()
        {
            Console.WriteLine("OverrideDemo.ExtraMethod(): Perivän luokan oma metodi");
        }
        
        // Demonstraatio
        public void Explain()
        {
            Console.WriteLine("OverrideDemo: Demonstroi metodien ylikirjoittamista.");
            Console.WriteLine("Ylikirjoittaminen mahdollistaa kantaluokan virtual-metodien");
            Console.WriteLine("käyttäytymisen muuttamisen perivässä luokassa.\n");
            
            Console.WriteLine("Kutsutaan ylikirjoitettua Process-metodia:");
            Process();
            
            Console.WriteLine("\nKutsutaan ylikirjoitettua Format-metodia:");
            string formatted1 = Format("Testiteksti");
            Console.WriteLine(formatted1);
            
            Console.WriteLine("\nLuodaan kantaluokan olio ja kutsutaan sen Process-metodia:");
            OverrideBaseClass baseObj = new OverrideBaseClass();
            baseObj.Process();
            
            string formatted2 = baseObj.Format("Testiteksti");
            Console.WriteLine(formatted2);
            
            Console.WriteLine("\nKäytetään polymorfismia kantaluokan viittauksen kautta:");
            OverrideBaseClass polyRef = new OverrideDemo();  // Viittaus on kantaluokan tyyppiä, olio on perivää luokkaa
            polyRef.Process();  // Kutsuu perivän luokan ylikirjoitettua toteutusta!
            
            Console.WriteLine("\nOminaisuuksien ylikirjoittaminen:");
            Console.WriteLine($"Perivä luokka: {Status}");
            Console.WriteLine($"Kantaluokka: {baseObj.Status}");
            Console.WriteLine($"Polymorfinen viittaus: {polyRef.Status}");
            
            Console.WriteLine("\nTavallisen metodin kutsu (ei virtuaalinen, ei ylikirjoitettu):");
            NonVirtualMethod();
            
            Console.WriteLine("\nYlikirjoittaminen mahdollistaa:");
            Console.WriteLine("- Kantaluokan käyttäytymisen muuttamisen perivissä luokissa");
            Console.WriteLine("- Polymorfismin (oikea metodiversio valitaan olion todellisen tyypin mukaan)");
            Console.WriteLine("- Kantaluokan toteutuksen käytön osana yliajavaa metodia (base-avainsana)");
        }
    }
} 