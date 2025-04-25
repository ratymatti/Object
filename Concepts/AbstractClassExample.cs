using System;

namespace OOPExplained.Concepts
{
    // Abstrakti luokka - ei voida instantioida suoraan
    public abstract class Document
    {
        // Abstrakti luokka voi sisältää normaaleja jäsenmuuttujia
        protected string title;
        protected DateTime created;
        
        // Abstrakti luokka voi sisältää tavallisia ominaisuuksia
        public string Author { get; set; }
        
        // Abstrakti luokka voi sisältää normaaleja metodeja
        public void DisplayInfo()
        {
            Console.WriteLine($"Dokumentti: {title}");
            Console.WriteLine($"Tekijä: {Author}");
            Console.WriteLine($"Luotu: {created}");
        }
        
        // Abstrakti luokka voi sisältää tavallisia rakentajia
        public Document(string title)
        {
            this.title = title;
            created = DateTime.Now;
            Author = "Tuntematon";
            Console.WriteLine("Document-luokan rakentaja kutsuttu");
        }
        
        // Abstraktit metodit - näille ei ole toteutusta tässä luokassa
        // Perivien luokkien on pakko toteuttaa nämä
        public abstract void Open();
        public abstract void Save();
        
        // Virtuaalinen metodi - tämä voidaan ylikirjoittaa, mutta ei ole pakko
        public virtual string GetFileType()
        {
            return "Geneerinen dokumentti";
        }
    }
    
    // Konkreettinen luokka, joka perii abstraktin luokan
    public class PdfDocument : Document
    {
        // Luokan omat jäsenmuuttujat
        private int pageCount;
        
        // Rakentaja, joka kutsuu kantaluokan rakentajaa
        public PdfDocument() : base("Uusi PDF-dokumentti")
        {
            pageCount = 0;
            Console.WriteLine("PdfDocument-luokan rakentaja kutsuttu");
        }
        
        // Abstraktien metodien toteutukset
        public override void Open()
        {
            Console.WriteLine($"Avataan PDF-dokumentti: {title}");
        }
        
        public override void Save()
        {
            Console.WriteLine($"Tallennetaan PDF-dokumentti: {title}");
        }
        
        // Virtuaalisen metodin ylikirjoitus
        public override string GetFileType()
        {
            return "PDF-dokumentti";
        }
        
        // Luokan oma metodi
        public void AddPage()
        {
            pageCount++;
            Console.WriteLine($"Lisätty sivu. Dokumentissa nyt {pageCount} sivua.");
        }
        
        // Demonstraatio abstrakteista luokista
        public void Explain()
        {
            Console.WriteLine("PdfDocument: Demonstroi abstrakteja luokkia.");
            Console.WriteLine("PdfDocument perii abstraktin Document-luokan.\n");
            
            Console.WriteLine("Kutsutaan abstraktista kantaluokasta perittyjä tavallisia metodeja:");
            DisplayInfo();
            
            Console.WriteLine("\nKutsutaan abstraktista kantaluokasta perittyjä ylikirjoitettuja metodeja:");
            Console.WriteLine($"Tiedostotyyppi: {GetFileType()}");
            
            Console.WriteLine("\nKutsutaan abstrakteja metodeja, jotka on toteutettu tässä luokassa:");
            Open();
            AddPage();
            AddPage();
            Save();
            
            Console.WriteLine("\nAbstraktit luokat mahdollistavat:");
            Console.WriteLine("- Yhteisen toteutuksen jakamisen periytyville luokille");
            Console.WriteLine("- Abstraktien metodien määrittämisen, jotka perivien luokkien on pakko toteuttaa");
            Console.WriteLine("- \"On tietyn tyyppinen\"-suhteen luokkien välillä (kun taas rajapinta kuvaa \"osaa tehdä\"-suhdetta)");
        }
    }
} 