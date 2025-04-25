using System;

namespace OOPExplained.Concepts
{
    // Rajapinta määrittelee "sopimuksen", jonka toteuttavat luokat täyttävät
    public interface IRunnable
    {
        // Rajapinta määrittelee metodin signaturin, mutta ei toteutusta
        void Run();
        
        // Rajapinnassa voi olla myös ominaisuuksia ilman toteutusta
        string Status { get; set; }
        
        // C# 8.0 lähtien rajapinnoissa voi olla oletustoteutuksia metodeille
        void LogInfo()
        {
            Console.WriteLine($"Tehtävän tila: {Status}");
        }
    }

    // Toinen rajapinta demonstraatiota varten
    public interface ISchedulable
    {
        DateTime ScheduledTime { get; set; }
        bool IsScheduled { get; }
    }

    // Luokka, joka toteuttaa rajapinnan
    public class TaskRunner : IRunnable, ISchedulable
    {
        // Toteutetaan rajapinnan ominaisuus
        public string Status { get; set; } = "Valmis";
        
        // Toteutetaan toisen rajapinnan ominaisuudet
        public DateTime ScheduledTime { get; set; } = DateTime.Now;
        public bool IsScheduled => ScheduledTime > DateTime.Now;

        // Luokan rakentaja
        public TaskRunner()
        {
            Console.WriteLine("TaskRunner luotu");
        }

        // Toteutetaan IRunnable-rajapinnan metodi
        public void Run()
        {
            Console.WriteLine("TaskRunner.Run(): Tehtävä suoritetaan...");
            Status = "Suoritettu";
        }
        
        // Demonstraatio polymorfismista rajapintojen avulla
        public void Explain()
        {
            Console.WriteLine("TaskRunner: Demonstroi rajapintojen käyttöä.");
            Console.WriteLine("TaskRunner toteuttaa rajapinnat IRunnable ja ISchedulable.\n");
            
            // Käytetään luokkaa sen omana tyyppinä
            Console.WriteLine("Käytetään TaskRunner-luokkaa suoraan:");
            Run();
            Console.WriteLine($"Tila: {Status}");
            
            // Käytetään luokkaa rajapinnan kautta (polymorfismi)
            Console.WriteLine("\nKäytetään TaskRunner-luokkaa IRunnable-rajapinnan kautta:");
            IRunnable runnableTask = this;
            runnableTask.Run();
            runnableTask.LogInfo();  // Kutsutaan rajapinnan oletustoteutusta
            
            Console.WriteLine("\nKäytetään TaskRunner-luokkaa ISchedulable-rajapinnan kautta:");
            ISchedulable schedulableTask = this;
            Console.WriteLine($"Ajastettu aika: {schedulableTask.ScheduledTime}");
            Console.WriteLine($"Onko ajastettu tulevaisuuteen: {schedulableTask.IsScheduled}");
            
            Console.WriteLine("\nRajapinnat mahdollistavat:");
            Console.WriteLine("- Polymorfismin (saman metodin kutsuminen eri oliotyypeille)");
            Console.WriteLine("- Monen rajapinnan toteuttamisen (C# ei tue moniperiytymistä luokilla)");
            Console.WriteLine("- Löyhän kytkennän komponenttien välillä");
        }
    }
} 