namespace Lotto_Aufgabe_28._04._2026
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] userZahlen = new int[6];
            int[] gewinnZahlen = new int[6];

            Console.WriteLine("---------------------- Lotto  6 aus 49 ----------------------");
            Console.WriteLine("Bitte geben sich nacheinander 6 Zahlen zwischen 1 und 49 ein:");

            // 1. User-Eingaben
            for (int i = 0; i < 6; i++)
            {
                while (true)
                {
                    Console.Write($"Zahl {i + 1}: ");
                    string? input = Console.ReadLine();

                    if (int.TryParse(input, out int zahl)) // Prüft Eingabe auf Zahl
                    {

                        if (zahl < 1 || zahl > 49) // fangt Zahlen < 1 oder > 49 ab
                        {
                            Console.WriteLine("Zahl muss zwischen 1 und 49 liegen!");
                            continue;
                        }

                        if (Array.Exists(userZahlen, x => x == zahl)) // Verhindert doppelte Zahlen
                        {
                            Console.WriteLine("Diese Zahl wurde bereits eingegeben!");
                            continue;
                        }

                        userZahlen[i] = zahl; // Speichert die gültige Zahl im Array
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Ungültige Eingabe!");
                    }
                }
            }

            // 2. Zufallszahlen generieren (ohne doppelte Zahlen)

            Random rnd = new Random(); // erzeugt Zufallszahlen
            HashSet<int> gezogen = new HashSet<int>(); // speichert Zahlen ohne Duplikate

            while (gezogen.Count < 6)
            {
                int zahl = rnd.Next(1, 50); // 1 bis 49
                gezogen.Add(zahl);
            }

            gezogen.CopyTo(gewinnZahlen);

            // 3. Vergleich

            int richtige = 0;

            foreach (int zahl in userZahlen)
            {
                if (Array.Exists(gewinnZahlen, x => x == zahl))
                {
                    richtige++;
                }
            }

            // 4. Sortiert die Zahlen nach der Größe

            Array.Sort(userZahlen);
            Array.Sort(gewinnZahlen);

            // 5. Ausgabe

            Console.WriteLine("\nIhre Zahlen:\t");
            foreach (int z in userZahlen)
            {
                Console.Write(z + " ");
            }
            
            Console.WriteLine("\nGezogene Zahlen:\t");
            foreach (int z in gewinnZahlen)
            {
                Console.Write(z + " ");
            }

            Console.WriteLine($"\n\nSie haben {richtige} Richtige!");
        }
    }
}


