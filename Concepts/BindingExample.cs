using System;

namespace OOPExplained.Concepts
{
    // Kantaluokka aikaisen ja myöhäisen sidonnan demonstrointiin
    public class BindingBase
    {
        // Tavallinen metodi - käyttää aikaista sidontaa
        public void EarlyBoundMethod()
        {
            Console.WriteLine("BindingBase.EarlyBoundMethod(): Aikainen sidonta");
        }
        
        // Virtuaalinen metodi - käyttää myöhäistä sidontaa
        public virtual void LateBoundMethod()
        {
            Console.WriteLine("BindingBase.LateBoundMethod(): Myöhäinen sidonta (kantaluokka)");
        }
        
        // Havainnollistaa metodikutsun eroavaisuutta
        public void CallMethods()
        {
            Console.WriteLine("Kutsutaan metodeja BindingBase-luokan sisältä:");
            EarlyBoundMethod();  // Aina kantaluokan toteutus
            LateBoundMethod();   // Riippuu olion todellisesta tyypistä
        }
    }
    
    // Perivä luokka
    public class BindingDerived : BindingBase
    {
        // Peittää (hide) kantaluokan metodin - ei käytä override-avainsanaa
        public new void EarlyBoundMethod()
        {
            Console.WriteLine("BindingDerived.EarlyBoundMethod(): Peittää kantaluokan metodin (new)");
        }
        
        // Ylikirjoittaa kantaluokan virtuaalisen metodin
        public override void LateBoundMethod()
        {
            Console.WriteLine("BindingDerived.LateBoundMethod(): Ylikirjoittaa kantaluokan virtuaalisen metodin");
        }
    }
    
    // Demonstraatioluokka
    public class BindingDemo
    {
        // Demonstraatio
        public void Explain()
        {
            Console.WriteLine("BindingDemo: Demonstroi aikaista ja myöhäistä sidontaa.");
            Console.WriteLine("Aikainen sidonta (Early binding): Kutsuva metodi päätetään käännösaikana.");
            Console.WriteLine("Myöhäinen sidonta (Late binding): Kutsuva metodi päätetään ajonaikana.\n");
            
            Console.WriteLine("Luodaan oliot ja viittaukset:");
            
            // Tavallinen tapaus - viittaus ja olio samaa tyyppiä
            Console.WriteLine("\n1. Viittauksen tyyppi ja olion tyyppi samat:");
            BindingBase baseObj = new BindingBase();
            BindingDerived derivedObj = new BindingDerived();
            
            Console.WriteLine("\nKutsutaan baseObj:n metodeja (BindingBase):");
            baseObj.EarlyBoundMethod();  // Kutsuu BindingBase.EarlyBoundMethod
            baseObj.LateBoundMethod();   // Kutsuu BindingBase.LateBoundMethod
            
            Console.WriteLine("\nKutsutaan derivedObj:n metodeja (BindingDerived):");
            derivedObj.EarlyBoundMethod();  // Kutsuu BindingDerived.EarlyBoundMethod
            derivedObj.LateBoundMethod();   // Kutsuu BindingDerived.LateBoundMethod
            
            // Polymorfinen tapaus - kantaluokan viittaus perivän luokan olioon
            Console.WriteLine("\n2. Viittauksen tyyppi on kantaluokka, olion tyyppi on perivä luokka:");
            BindingBase polyRef = new BindingDerived();
            
            Console.WriteLine("\nKutsutaan polyRef:n metodeja (viittaus=BindingBase, olio=BindingDerived):");
            polyRef.EarlyBoundMethod();  // Aikainen sidonta - kutsuu BindingBase.EarlyBoundMethod!
            polyRef.LateBoundMethod();   // Myöhäinen sidonta - kutsuu BindingDerived.LateBoundMethod!
            
            // Havainnollistetaan eroa CallMethods-metodin kautta
            Console.WriteLine("\n3. Polymorfinen metodikutsu:");
            Console.WriteLine("\nbaseObj.CallMethods():");
            baseObj.CallMethods();  // Molemmat kutsut BindingBase-metodeihin
            
            Console.WriteLine("\npolyRef.CallMethods():");
            polyRef.CallMethods();  // EarlyBoundMethod tulee BindingBase:sta, LateBoundMethod BindingDerived:sta!
            
            Console.WriteLine("\nAikainen ja myöhäinen sidonta:");
            Console.WriteLine("- Aikainen sidonta: Metodi sidotaan käännösaikana (normaali metodi)");
            Console.WriteLine("- Myöhäinen sidonta: Metodi sidotaan ajonaikana (virtual/override)");
            Console.WriteLine("- Sidontatapa vaikuttaa polymorfisten viittausten käyttäytymiseen");
            Console.WriteLine("- Myöhäinen sidonta on OOP:n polymorfismin perusta");
        }
    }
} 