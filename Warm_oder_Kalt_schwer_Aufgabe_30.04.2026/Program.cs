using System;

namespace Warm_oder_Kalt_schwer_Aufgabe_30._04._2026
{
    internal class Program
    {
        static Random random = new Random();

        static int Spiel()
        {
            Console.WriteLine("Willkommen zu 'Warm oder Kalt'!");

            // Hardmode auswählen
            Console.Write("Möchtest du den Hardmode spielen? (j/n): ");
            string eingabe = Console.ReadLine().ToLower();

            int maxZahl = (eingabe == "j") ? 1000 : 100;

            int geheimeZahl = random.Next(1, maxZahl + 1);
            int versuche = 0;
            int? letzterAbstand = null;

            Console.WriteLine($"\nIch habe mir eine Zahl zwischen 1 und {maxZahl} ausgedacht.");

            while (true)
            {
                Console.Write("Dein Tipp: ");
                if (!int.TryParse(Console.ReadLine(), out int tipp))
                {
                    Console.WriteLine("Bitte gib eine gültige Zahl ein.");
                    continue;
                }

                versuche++;
                int aktuellerAbstand = Math.Abs(geheimeZahl - tipp);

                if (tipp == geheimeZahl)
                {
                    Console.WriteLine($"Richtig! Du hast die Zahl in {versuche} Versuchen erraten.");
                    return versuche;
                }

                if (letzterAbstand.HasValue)
                {
                    if (aktuellerAbstand < letzterAbstand.Value)
                        Console.WriteLine("→ Wärmer!");
                    else if (aktuellerAbstand > letzterAbstand.Value)
                        Console.WriteLine("→ Kälter!");
                    else
                        Console.WriteLine("→ Gleich weit entfernt!");
                }
                else
                {
                    Console.WriteLine("→ Erster Versuch!");
                }

                letzterAbstand = aktuellerAbstand;
            }
        }

        static void Main()
        {
            int? highscore = null;

            while (true)
            {
                int versuche = Spiel();

                // Highscore aktualisieren
                if (!highscore.HasValue || versuche < highscore.Value)
                {
                    highscore = versuche;
                    Console.WriteLine("🎉 Neuer Highscore!");
                }

                Console.WriteLine($"Aktueller Highscore: {highscore} Versuche");

                // Noch eine Runde?
                Console.Write("\nMöchtest du nochmal spielen? (j/n): ");
                string nochmal = Console.ReadLine().ToLower();

                if (nochmal != "j")
                {
                    Console.WriteLine("Danke fürs Spielen!");
                    break;
                }

                Console.WriteLine();
            }
        }
    }


}
 
