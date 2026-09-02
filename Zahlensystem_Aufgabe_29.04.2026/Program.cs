namespace Zahlensystem_Aufgabe_29._04._2026
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string eingabe;

            do
            {
                int operation;

                Console.WriteLine("\nWählen Sie die Operation:");
                Console.WriteLine("1: Überprüfung Primzahl");
                Console.WriteLine("2: Quersumme bilden");
                Console.WriteLine("3: Potenzieren");
                Console.WriteLine("4: Zahlen spiegeln");
                Console.WriteLine("5: Zahlen-Palindrom");
                Console.WriteLine("6: Programmende");

                // Auswahl prüfen
                while (true)
                {
                    Console.Write("Ihre Wahl: ");
                    if (int.TryParse(Console.ReadLine(), out operation) &&
                        operation >= 1 && operation <= 6)
                        break;

                    Console.WriteLine("Ungültige Auswahl! Bitte 1–6 wählen.");
                }

                switch (operation)
                {
                    case 1: // Primzahl
                        int zahl1;
                        while (true)
                        {
                            Console.Write("Gib eine Zahl ein: ");
                            if (int.TryParse(Console.ReadLine(), out zahl1))
                                break;

                            Console.WriteLine("Ungültige Eingabe!");
                        }

                        bool istPrim = true;

                        if (zahl1 <= 1)
                            istPrim = false;
                        else if (zahl1 % 2 == 0 && zahl1 != 2)
                            istPrim = false;
                        else
                        {
                            for (int i = 3; i <= Math.Sqrt(zahl1); i += 2)
                            {
                                if (zahl1 % i == 0)
                                {
                                    istPrim = false;
                                    break;
                                }
                            }
                        }

                        Console.WriteLine(istPrim
                            ? $"{zahl1} ist eine Primzahl"
                            : $"{zahl1} ist keine Primzahl");
                        break;

                    case 2: // Quersumme
                        int zahl2;
                        while (true)
                        {
                            Console.Write("Gib eine ganze Zahl ein: ");
                            if (int.TryParse(Console.ReadLine(), out zahl2))
                                break;

                            Console.WriteLine("Ungültige Eingabe!");
                        }

                        int summe = 0;
                        int temp2 = Math.Abs(zahl2);

                        while (temp2 > 0)
                        {
                            summe += temp2 % 10;
                            temp2 /= 10;
                        }

                        Console.WriteLine($"Quersumme: {summe}");
                        break;

                    case 3: // Potenzieren
                        int basis, exponent;

                        Console.Write("Gib eine Zahl ein: ");
                        while (!int.TryParse(Console.ReadLine(), out basis))
                            Console.Write("Ungültig, bitte Zahl eingeben: ");

                        Console.Write("Gib den Faktor ein: ");
                        while (!int.TryParse(Console.ReadLine(), out exponent))
                            Console.Write("Ungültig, bitte Zahl eingeben: ");

                        int ergebnis = 1;

                        for (int i = 0; i < exponent; i++)
                        {
                            ergebnis *= basis;
                        }

                        Console.WriteLine($"{basis}^{exponent} = {ergebnis}");
                        break;

                    case 4: // Spiegeln
                        int zahl4;
                        Console.Write("Gib eine Zahl ein: ");
                        while (!int.TryParse(Console.ReadLine(), out zahl4))
                            Console.Write("Ungültig, bitte Zahl eingeben: ");

                        int gespiegelt = 0;
                        int temp4 = Math.Abs(zahl4);

                        while (temp4 > 0)
                        {
                            int ziffer = temp4 % 10;
                            gespiegelt = gespiegelt * 10 + ziffer;
                            temp4 /= 10;
                        }

                        if (zahl4 < 0)
                            gespiegelt *= -1;

                        Console.WriteLine($"Gespiegelte Zahl: {gespiegelt}");
                        break;

                    case 5: // Palindrom
                        int zahl5;
                        while (true)
                        {
                            Console.Write("Gib eine Zahl mit mindestens 2 Stellen ein: ");
                            if (int.TryParse(Console.ReadLine(), out zahl5))
                            {
                                if (Math.Abs(zahl5) >= 10)
                                    break;

                                Console.WriteLine("Mindestens 2-stellig!");
                            }
                            else
                            {
                                Console.WriteLine("Ungültige Eingabe!");
                            }
                        }

                        int original = Math.Abs(zahl5);
                        int gespiegelt2 = 0;
                        int temp5 = original;

                        while (temp5 > 0)
                        {
                            int ziffer = temp5 % 10;
                            gespiegelt2 = gespiegelt2 * 10 + ziffer;
                            temp5 /= 10;
                        }

                        Console.WriteLine(original == gespiegelt2
                            ? $"{zahl5} ist ein Palindrom"
                            : $"{zahl5} ist kein Palindrom");
                        break;

                    case 6:
                        Console.WriteLine("Programm beendet.");
                        return;
                }

                Console.Write("Weitere Rechnung? (ja/nein): ");
                eingabe = Console.ReadLine().Trim().ToLower();

            } while (eingabe == "ja" || eingabe == "j");

            Console.WriteLine("Programm beendet.");
        }
    }
}
