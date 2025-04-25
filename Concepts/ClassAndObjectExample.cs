using System;

namespace OOPExplained.Concepts
{
    public class ClassAndObjectDemo
    {
        // Jäsenmuuttuja - yksityinen muuttuja luokan sisällä
        private string memberVariable = "Olen jäsenmuuttuja";

        // Julkinen metodi, jota käytetään demonstroimaan luokan toiminnallisuutta
        public void Explain()
        {
            Console.WriteLine("ClassAndObjectDemo: Demonstroi luokkaa jäsenmuuttujalla ja metodilla.");
            Console.WriteLine($"Jäsenmuuttujan arvo: {memberVariable}");
            
            // Kutsu toista metodia luokan sisällä
            ExampleMethod();
            
            // Luodaan toinen olio samasta luokasta
            Console.WriteLine("\nLuodaan toinen olio samasta luokasta:");
            ClassAndObjectDemo toinenOlio = new ClassAndObjectDemo();
            toinenOlio.memberVariable = "Olen toisen olion jäsenmuuttuja";
            Console.WriteLine($"Toisen olion jäsenmuuttujan arvo: {toinenOlio.memberVariable}");
        }

        // Yksityinen metodi, jota voidaan kutsua vain luokan sisältä
        private void ExampleMethod()
        {
            Console.WriteLine("Tämä on esimerkki metodista luokan sisällä.");
            Console.WriteLine("Metodit suorittavat toimintoja ja voivat käsitellä luokan dataa.");
        }
    }
} 