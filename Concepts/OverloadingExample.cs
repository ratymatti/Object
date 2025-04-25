using System;

namespace OOPExplained.Concepts
{
    public class OverloadingDemo
    {
        // Metodi ilman parametreja
        public void Calculate()
        {
            Console.WriteLine("Calculate(): Lasketaan oletusarvolla 0");
            Calculate(0);
        }
        
        // Sama metodi yhdellä parametrilla - kuormitettu versio
        public void Calculate(int value)
        {
            Console.WriteLine($"Calculate(int): Lasketaan kokonaisluvulla {value}");
            Console.WriteLine($"  Tulos: {value * 2}");
        }
        
        // Sama metodi kahdella parametrilla - toinen kuormitettu versio
        public void Calculate(int first, int second)
        {
            Console.WriteLine($"Calculate(int, int): Lasketaan kahdella kokonaisluvulla {first} ja {second}");
            Console.WriteLine($"  Tulos: {first + second}");
        }
        
        // Sama metodi eri tyypin parametrilla - kuormitettu versio
        public void Calculate(double value)
        {
            Console.WriteLine($"Calculate(double): Lasketaan liukuluvulla {value}");
            Console.WriteLine($"  Tulos: {value * 2.5}");
        }
        
        // Sama metodi eri tyyppien parametreilla - kuormitettu versio
        public void Calculate(string text, int count)
        {
            Console.WriteLine($"Calculate(string, int): Toistetaan merkkijonoa '{text}' {count} kertaa");
            for (int i = 0; i < count; i++)
            {
                Console.Write(text);
            }
            Console.WriteLine();
        }
        
        // Staattinen kuormitettu metodi
        public static int Add(int a, int b)
        {
            return a + b;
        }
        
        // Staattinen kuormitettu metodi - eri määrä parametreja
        public static int Add(int a, int b, int c)
        {
            return a + b + c;
        }
        
        // Metodin kuormittaminen palautusarvon mukaan ei ole mahdollista C#:ssa
        // Seuraava koodi ei kääntyisi:
        // public double Add(int a, int b) { return (double)(a + b); }
        
        // Demonstraatio
        public void Explain()
        {
            Console.WriteLine("OverloadingDemo: Demonstroi metodien kuormittamista.");
            Console.WriteLine("Metodin kuormittaminen tarkoittaa saman nimisen metodin toteuttamista");
            Console.WriteLine("erilaisilla parametrilistoilla.\n");
            
            Console.WriteLine("Kutsutaan kuormitettuja metodeja:");
            Calculate();
            Calculate(10);
            Calculate(5, 7);
            Calculate(3.14);
            Calculate("*", 10);
            
            Console.WriteLine("\nStaattiset kuormitetut metodit:");
            int sum1 = Add(5, 10);
            int sum2 = Add(5, 10, 15);
            Console.WriteLine($"Add(5, 10) = {sum1}");
            Console.WriteLine($"Add(5, 10, 15) = {sum2}");
            
            Console.WriteLine("\nRakentajat voivat myös olla kuormitettuja (katso ConstructorDemo)");
            
            Console.WriteLine("\nKuormittaminen mahdollistaa:");
            Console.WriteLine("- Saman toiminnallisuuden tarjoamisen eri parametrivaihtoehdoilla");
            Console.WriteLine("- Oletusparametrien simuloinnin (kutsumalla toista kuormitettua metodia)");
            Console.WriteLine("- Selkeämmän API:n luomisen, kun metodien nimet ovat kuvaavia");
            Console.WriteLine("- Metodien määrä ei kasva tarpeettomasti erilaisilla nimillä");
        }
    }
} 