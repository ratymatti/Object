using System;

namespace OOPExplained.Concepts
{
    public class VisibilityDemo
    {
        // Yksityinen jäsenmuuttuja - vain tämän luokan sisällä näkyvä
        private string privateData = "Yksityinen tieto - vain luokan sisäiseen käyttöön";
        
        // Julkinen jäsenmuuttuja - näkyy kaikkialle
        public string publicData = "Julkinen tieto - näkyy kaikkialle";
        
        // Suojattu jäsenmuuttuja - näkyy tässä luokassa ja perivissä luokissa
        protected string protectedData = "Suojattu tieto - näkyy myös perivissä luokissa";
        
        // Sisäinen jäsenmuuttuja - näkyy vain saman nimiavaruuden sisällä
        internal string internalData = "Sisäinen tieto - näkyy vain saman nimiavaruuden sisällä";
        
        // Suojattu sisäinen - yhdistelmä suojatusta ja sisäisestä
        protected internal string protectedInternalData = "Näkyy perivissä luokissa ja saman nimiavaruuden sisällä";
        
        // Yksityinen suojattu - suojattu taso, mutta rajoitetumpi kuin protected
        private protected string privateProtectedData = "Näkyy vain perivissä luokissa saman nimiavaruuden sisällä";
        
        // Kapselointi ominaisuuksien avulla
        private int counter;
        
        // Julkinen ominaisuus, jolla on yksityiset asetus- ja hakutoiminnot
        public int Counter
        {
            get { return counter; }
            set 
            { 
                if (value >= 0)  // Validointi
                {
                    counter = value;
                    Console.WriteLine($"Counter asetettu arvoon: {counter}");
                }
                else
                {
                    Console.WriteLine("Virhe: Laskurin arvo ei voi olla negatiivinen");
                }
            }
        }
        
        // Toiminnon näkyvyyden määrittäminen
        public void PublicMethod()
        {
            Console.WriteLine("Julkinen metodi - voidaan kutsua mistä tahansa");
            PrivateMethod(); // Luokan sisältä voidaan kutsua yksityisiä metodeja
        }
        
        private void PrivateMethod()
        {
            Console.WriteLine("Yksityinen metodi - voidaan kutsua vain luokan sisältä");
        }
        
        protected void ProtectedMethod()
        {
            Console.WriteLine("Suojattu metodi - voidaan kutsua luokan sisältä ja perivistä luokista");
        }
        
        // Demonstraatio näkyvyysmääreistä
        public void Explain()
        {
            Console.WriteLine("VisibilityDemo: Demonstroi näkyvyysmääreiden käyttöä.");
            
            Console.WriteLine("\nLuokan sisällä kaikki jäsenet ovat näkyvissä:");
            Console.WriteLine($"Yksityinen: {privateData}");
            Console.WriteLine($"Julkinen: {publicData}");
            Console.WriteLine($"Suojattu: {protectedData}");
            Console.WriteLine($"Sisäinen: {internalData}");
            Console.WriteLine($"Suojattu sisäinen: {protectedInternalData}");
            Console.WriteLine($"Yksityinen suojattu: {privateProtectedData}");
            
            Console.WriteLine("\nMetodit voidaan myös rajoittaa eri näkyvyystasoille:");
            PublicMethod();
            PrivateMethod();  // Voidaan kutsua luokan sisältä
            ProtectedMethod();  // Voidaan kutsua luokan sisältä
            
            Console.WriteLine("\nKapseloinnin demonstraatio ominaisuuksien avulla:");
            Counter = 5;  // Käyttää ominaisuuden set-toimintoa
            Console.WriteLine($"Counter-ominaisuuden arvo: {Counter}");  // Käyttää get-toimintoa
            Counter = -3;  // Yrittää asettaa virheellisen arvon, validointi estää
            
            Console.WriteLine("\nNäkyvyysmääreet mahdollistavat:");
            Console.WriteLine("- Luokan sisäisen tilan piilottamisen (kapselointi)");
            Console.WriteLine("- Rajapinnan määrittämisen julkisille toiminnoille");
            Console.WriteLine("- Periytyville luokille näkyvien jäsenten määrittämisen");
            Console.WriteLine("- Nimiavaruuden sisäisten jäsenten määrittämisen");
        }
        
        // Sisäkkäinen luokka demonstroimaan näkyvyysmääreitä eri luokkakonteksteissa
        public class NestedClass
        {
            public void AccessMembers(VisibilityDemo parent)
            {
                Console.WriteLine("\nSisäkkäisestä luokasta käsin:");
                Console.WriteLine($"Julkinen: {parent.publicData}");
                Console.WriteLine($"Sisäinen: {parent.internalData}");
                // Ei pääsyä parent.privateData - yksityinen
                // Ei pääsyä parent.protectedData - ei peritty luokka
            }
        }
    }
    
    // Apuluokka, joka perii VisibilityDemo-luokan
    public class VisibilityInheritor : VisibilityDemo
    {
        public void ShowInheritedMembers()
        {
            Console.WriteLine("\nPerivässä luokassa näkyvät jäsenet:");
            Console.WriteLine($"Julkinen: {publicData}");
            Console.WriteLine($"Suojattu: {protectedData}");
            Console.WriteLine($"Sisäinen: {internalData}");
            Console.WriteLine($"Suojattu sisäinen: {protectedInternalData}");
            Console.WriteLine($"Yksityinen suojattu: {privateProtectedData}");
            // Ei pääsyä privateData - yksityinen
            
            ProtectedMethod();  // Voidaan kutsua, koska se on suojattu
            // PrivateMethod();  // Ei voida kutsua, koska se on yksityinen
        }
    }
} 