using System;

namespace OOPExplained.Concepts
{
    // Kantaluokka, josta peritään
    public class BaseClass
    {
        // Suojattu jäsenmuuttuja, jota perivät luokat voivat käyttää
        protected string baseData;

        // Julkinen ominaisuus, jonka perivät luokat perivät
        public string Description { get; set; }

        // Kantaluokan rakentaja
        public BaseClass()
        {
            baseData = "Kantaluokan tieto";
            Description = "Kantaluokan kuvaus";
            Console.WriteLine("BaseClass-rakentaja kutsuttu");
        }

        // Virtuaalinen metodi, jonka perivä luokka voi ylikirjoittaa
        public virtual void DisplayInfo()
        {
            Console.WriteLine("BaseClass.DisplayInfo(): Tämä on kantaluokan metodi");
            Console.WriteLine($"  Description: {Description}");
            Console.WriteLine($"  baseData: {baseData}");
        }

        // Tavallinen metodi, joka periytyy sellaisenaan
        public void BaseMethod()
        {
            Console.WriteLine("BaseClass.BaseMethod(): Tämä metodi periytyy sellaisenaan");
        }
    }

    // Perivä luokka, joka laajentaa kantaluokkaa
    public class InheritanceDemo : BaseClass
    {
        // Luokan oma jäsenmuuttuja
        private string derivedData;

        // Perivän luokan rakentaja
        public InheritanceDemo() : base() // Kutsuu kantaluokan rakentajaa
        {
            derivedData = "Perivän luokan tieto";
            Description = "Perivän luokan kuvaus"; // Muuttaa peritttyä ominaisuutta
            Console.WriteLine("InheritanceDemo-rakentaja kutsuttu");
        }

        // Ylikirjoittaa kantaluokan virtuaalisen metodin
        public override void DisplayInfo()
        {
            Console.WriteLine("InheritanceDemo.DisplayInfo(): Tämä on perivän luokan ylikirjoittama metodi");
            Console.WriteLine($"  Description: {Description}");
            Console.WriteLine($"  baseData (peritty): {baseData}");
            Console.WriteLine($"  derivedData (oma): {derivedData}");
        }

        // Perivän luokan oma metodi
        public void DerivedMethod()
        {
            Console.WriteLine("InheritanceDemo.DerivedMethod(): Tämä on perivän luokan oma metodi");
        }

        // Selitys ja demonstraatio
        public void Explain()
        {
            Console.WriteLine("InheritanceDemo: Demonstroi periytymisen toimintaa.");
            Console.WriteLine("InheritanceDemo perii BaseClass-luokan.\n");
            
            Console.WriteLine("Kutsutaan kantaluokalta perittyä metodia:");
            BaseMethod();
            
            Console.WriteLine("\nKutsutaan ylikirjoitettua metodia:");
            DisplayInfo();
            
            Console.WriteLine("\nLuodaan kantaluokan olio vertailua varten:");
            BaseClass baseObject = new BaseClass();
            baseObject.DisplayInfo();
            
            Console.WriteLine("\nPeriytyminen mahdollistaa luokkahierarkian luomisen, jossa");
            Console.WriteLine("perivä luokka saa kantaluokan ominaisuudet ja metodit.");
        }
    }
} 