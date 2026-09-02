using System;

namespace Brauerei_Aufgabe_04._05._2026
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double gesamtSumme = 0;
            

            // ===================== BIER =====================
            double bierPreis = EingabePreisBier();
            int bierStueck = EingabeStueckBier();
            double bierGesamt = BerechnungBier(bierPreis, bierStueck);

            gesamtSumme += bierGesamt;

            double sonstigeSumme = 0;

            // ===================== WEITERE GETRÄNKE =====================
            while (WeitereBestellung())
            {
                string getraenk = EingabeGetraenk();
                double preis = EingabePreis();
                int stueck = EingabeStueck();

                double gesamt = BerechnungStandard(preis, stueck);

                Ausgabe(getraenk, preis, stueck, gesamt);

                gesamtSumme += gesamt;
                sonstigeSumme += gesamt;
            }

            // ===================== MWST =====================
            double mwst19 = bierGesamt * 0.19;
            double mwst7 = sonstigeSumme * 0.07;

            // ===================== RECHNUNG =====================
            AusgabeRechnung(bierPreis, bierStueck, bierGesamt, gesamtSumme, mwst19, mwst7, sonstigeSumme);
        }

        // ===================== EINGABEN ======================

        static double EingabePreisBier()
        {
            double preis;

            while (true)
            {
                Console.Write("Bitte Bier Kistenpreis eintragen: ");

                if (double.TryParse(Console.ReadLine(), out preis) && preis > 0)
                    return preis;

                Console.WriteLine("Ungültige Eingabe!");
            }
        }

        static int EingabeStueckBier()
        {
            int stueck;

            while (true)
            {
                Console.Write("Bitte Bier Kistenanzahl eintragen: ");

                if (int.TryParse(Console.ReadLine(), out stueck) && stueck > 0 && stueck <= 10000)
                    return stueck;

                Console.WriteLine("Ungültige Eingabe!");
            }
        }

        static string EingabeGetraenk()
        {
            Console.Write("Getränk: ");
            return Console.ReadLine();
        }

        static double EingabePreis()
        {
            double preis;

            while (true)
            {
                Console.Write("Kistenpreis: ");

                if (double.TryParse(Console.ReadLine(), out preis) && preis > 0)
                    return preis;

                Console.WriteLine("Ungültige Eingabe!");
            }
        }

        static int EingabeStueck()
        {
            int stueck;

            while (true)
            {
                Console.Write("Anzahl Kisten: ");

                if (int.TryParse(Console.ReadLine(), out stueck) && stueck > 0 && stueck <= 10000)
                    return stueck;

                Console.WriteLine("Ungültige Eingabe!");
            }
        }

        // ==================== BERECHNUNG =====================

        static double BerechnungBier(double preis, int stueck)
        {
            if (stueck < 10)
                return preis * stueck;
            else if (stueck < 50)
                return preis * stueck * 0.95;
            else if (stueck < 100)
                return preis * stueck * 0.93;
            else
                return preis * stueck * 0.90;
        }

        static double BerechnungStandard(double preis, int stueck)
        {
            return preis * stueck;
        }

        // ===================== LOGIK =========================

        static bool WeitereBestellung()
        {
            Console.Write("Möchten Sie weitere Getränke? (ja/nein): ");
            string eingabe = Console.ReadLine().Trim().ToLower();

            return eingabe == "ja" || eingabe == "j";
        }

        // ===================== AUSGABE =======================

        static void Ausgabe(string name, double preis, int stueck, double gesamt)
        {
            Console.WriteLine("\n--- Bestellung ---");
            Console.WriteLine($"Getränk: {name}");
            Console.WriteLine($"Preis: {preis:F2} Euro");
            Console.WriteLine($"Menge: {stueck}");
            Console.WriteLine($"Gesamt: {gesamt:F2} Euro\n");
        }

        static void AusgabeRechnung(double bierPreis, int bierStueck, double bierGesamt,
                                    double gesamtSumme, double mwst19, double mwst7, double sonstigeSumme)
        {

            Console.WriteLine("\n=====================================");
            Console.WriteLine("   Getränke Großhandel München");
            Console.WriteLine("=====================================");

            Console.WriteLine($"Bier Preis: {bierPreis:F2} Euro");
            Console.WriteLine($"Bier Menge: {bierStueck}");
            Console.WriteLine($"Bier Summe: {bierGesamt:F2} Euro");

            Console.WriteLine("-------------------------------------");
            Console.WriteLine($"Sonstige Getränke Summe: {sonstigeSumme:F2} Euro");

            Console.WriteLine("-------------------------------------");
            Console.WriteLine($"Gesamtsumme: {gesamtSumme:F2} Euro");

            Console.WriteLine("-------------------------------------");

            Console.WriteLine($"MwSt 19%: {mwst19:F2} Euro");
            Console.WriteLine($"MwSt 7%: {mwst7:F2} Euro");

            Console.WriteLine("=====================================");
        }
    }
}