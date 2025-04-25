using System;

namespace OOPExplained.Concepts
{
    public class ConstructorDemo
    {
        // Jäsenmuuttujat
        private string name;
        private int value;

        // Oletusrakentaja
        public ConstructorDemo()
        {
            name = "Oletusnimi";
            value = 0;
            Console.WriteLine("Oletusrakentaja kutsuttu: name = {0}, value = {1}", name, value);
        }

        // Parametroitu rakentaja
        public ConstructorDemo(string name)
        {
            this.name = name;
            value = 0;
            Console.WriteLine("Yhden parametrin rakentaja kutsuttu: name = {0}, value = {1}", name, value);
        }

        // Kuormitettu rakentaja useammalla parametrilla
        public ConstructorDemo(string name, int value)
        {
            this.name = name;
            this.value = value;
            Console.WriteLine("Kahden parametrin rakentaja kutsuttu: name = {0}, value = {1}", name, value);
        }

        // Rakentaja, joka kutsuu toista rakentajaa (ketjuttaminen)
        public ConstructorDemo(int value) : this("Parametrista", value)
        {
            Console.WriteLine("Ketjutettu rakentaja kutsuttu: name = {0}, value = {1}", name, value);
        }

        public void Explain()
        {
            Console.WriteLine("ConstructorDemo: Demonstroi rakentajien toimintaa.");
            Console.WriteLine("Tämän olion arvot: name = {0}, value = {1}", name, value);
            
            Console.WriteLine("\nLuodaan olioita eri rakentajilla:");
            
            // Luodaan olioita eri rakentajilla
            ConstructorDemo olio1 = new ConstructorDemo();
            ConstructorDemo olio2 = new ConstructorDemo("Mukautettu");
            ConstructorDemo olio3 = new ConstructorDemo("Täysin mukautettu", 42);
            ConstructorDemo olio4 = new ConstructorDemo(100);
            
            Console.WriteLine("\nRakentajat mahdollistavat olioiden alustamisen luonnin yhteydessä.");
        }
    }
} 