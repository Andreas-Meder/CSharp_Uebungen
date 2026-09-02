namespace Warm_oder_Kalt_einfach_Aufgabe_30._04._2026
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Spiel();

                Console.Write("Möchtest du noch einmal spielen? (j/n): ");
                string antwort = Console.ReadLine().ToLower();

                if (antwort != "j")
                {
                    Console.WriteLine("Danke fürs Spielen!");
                    break;
                }
            }
        }

        static void Spiel()
        {
            Random rand = new Random();
            int zielzahl = rand.Next(1, 101);
            int versuche = 0;
            int? letzterAbstand = null;

            Console.WriteLine("Ich habe mir eine Zahl zwischen 1 und 100 ausgedacht.");

            while (true)
            {
                Console.Write("Gib deinen Tipp ein: ");
                string eingabe = Console.ReadLine();

                if (!int.TryParse(eingabe, out int tipp))
                {
                    Console.WriteLine("Bitte gib eine gültige Zahl ein!");
                    continue;
                }

                versuche++;
                int abstand = Math.Abs(zielzahl - tipp);

                if (tipp == zielzahl)
                {
                    Console.WriteLine($"Richtig! Du hast die Zahl in {versuche} Versuchen erraten.");
                    break;
                }

                if (letzterAbstand == null)
                {
                    Console.WriteLine("Erster Versuch!");
                }
                else
                {
                    if (abstand < letzterAbstand)
                    {
                        Console.WriteLine("Wärmer!");
                    }
                    else if (abstand > letzterAbstand)
                    {
                        Console.WriteLine("Kälter!");
                    }
                    else
                    {
                        Console.WriteLine("Gleich weit entfernt!");
                    }
                }

                letzterAbstand = abstand;
            }
        }
    }
}
