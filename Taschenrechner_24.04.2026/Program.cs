using System;
using System.Globalization;
using System.Net.NetworkInformation;

class Rechner
{
    static void Main()
    {
        string eingabe;
        do
        {
            double zahl1, zahl2;
            int operation;

            // Eingabe erste Zahl
            while (true)
            {
                Console.Write("Geben Sie die erste Zahl ein: ");
                string input = Console.ReadLine().Replace(',', '.');

                if (double.TryParse(input, NumberStyles.Any, CultureInfo.InvariantCulture, out zahl1))
                    break;

                Console.WriteLine("Ungültige Eingabe! Bitte eine Zahl eingeben (z.B. 3,5 oder 3.5).");
            }

            // Eingabe zweite Zahl
            while (true)
            {
                Console.Write("Geben Sie die zweite Zahl ein: ");
                string input = Console.ReadLine().Replace(',', '.');

                if (double.TryParse(input, NumberStyles.Any, CultureInfo.InvariantCulture, out zahl2))
                    break;

                Console.WriteLine("Ungültige Eingabe! Bitte eine Zahl eingeben (z.B. 3,5 oder 3.5).");
            }

            // Auswahl der Operation
            Console.WriteLine("\nWählen Sie die Operation:");
            Console.WriteLine("1: Addition");
            Console.WriteLine("2: Subtraktion");
            Console.WriteLine("3: Multiplikation");
            Console.WriteLine("4: Division");

            while (true)
            {
                Console.Write("Ihre Wahl: ");
                if (int.TryParse(Console.ReadLine(), out operation) &&
                    operation >= 1 && operation <= 4)
                    break;

                Console.WriteLine("Ungültige Auswahl! Bitte 1–4 wählen.");
            }

            // Berechnung
            switch (operation)
            {
                case 1:
                    //Console.WriteLine("Ergebnis: " + (zahl1 + zahl2));
                    Console.WriteLine($"{zahl1} + {zahl2} = {zahl1 + zahl2}");
                    break;
                case 2:
                    //Console.WriteLine("Ergebnis: " + (zahl1 - zahl2));
                    Console.WriteLine($"{zahl1} - {zahl2} = {zahl1 - zahl2}");
                    break;
                case 3:
                    //Console.WriteLine("Ergebnis: " + (zahl1 * zahl2));
                    Console.WriteLine($"{zahl1} * {zahl2} = {zahl1 * zahl2}");
                    break;
                case 4:
                    if (zahl2 == 0)
                        Console.WriteLine("Fehler: Division durch 0 ist nicht erlaubt!");
                    else
                        //Console.WriteLine("Ergebnis: " + (zahl1 / zahl2));
                        Console.WriteLine($"{zahl1} / {zahl2} = {zahl1 / zahl2}");
                    break;
            }

            Console.Write("Weitere Rechnung ? Bitte 'ja' oder 'nein' eingeben: ");
            eingabe = Console.ReadLine().Trim().ToLower();

        } while (eingabe == "ja" || eingabe == "j");

        Console.WriteLine("Programm beendet.");
    }
}