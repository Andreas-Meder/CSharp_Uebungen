namespace Wassermelone_Aufgabe_30._04._2026
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double preis;
            double gPreis = 0;
            int stückzahl;
            DateTime dt1 = DateTime.Now;


            // Preis Eingabe
            while (true)
            {
                Console.Write("Geben Sie bitte den Stückpreis ein: ");

                if (double.TryParse(Console.ReadLine(), out preis) && preis > 0)
                    break;

                Console.WriteLine("Ungültige Eingabe!");
            }

            // Stückzahl Eingabe
            while (true)
            {
                Console.Write("Geben Sie bitte die Stückzahl ein: ");

                if (int.TryParse(Console.ReadLine(), out stückzahl) && stückzahl > 0 && stückzahl <= 10000)
                    break;

                Console.WriteLine("Ungültige Stückzahl!");
            }

            // Berechnung
            if (dt1.DayOfWeek == DayOfWeek.Thursday)
            {
                if (stückzahl < 5)
                    gPreis = preis * stückzahl;
                else if (stückzahl < 10)
                    gPreis = preis * stückzahl * 0.93; // 7%
                else
                    gPreis = preis * stückzahl * 0.88; // 12%
            }
            else
            {
                if (stückzahl < 5)
                    gPreis = preis * stückzahl;
                else if (stückzahl < 10)
                    gPreis = preis * stückzahl * 0.95; // 5%
                else
                    gPreis = preis * stückzahl * 0.90; // 10%
            }

            double mw = gPreis * 0.07; // 7% MwSt.

            Console.WriteLine();
            Console.WriteLine("Wassermelonenverkauf München");
            Console.WriteLine();
            Console.WriteLine("Quittung für Ihre Bestellung");
            Console.WriteLine();
            Console.WriteLine(dt1.ToLongDateString());
            Console.WriteLine();
            Console.WriteLine("Bestellte Menge Wassermelonen: " + stückzahl);
            Console.WriteLine();
            Console.WriteLine("Gesamtpreis: " + gPreis.ToString("F2") + " Euro");
            Console.WriteLine();
            Console.WriteLine("Enthaltene 7 % MwSt.: " + mw.ToString("F2") + " Euro");
            Console.WriteLine();
            Console.WriteLine("Vielen Dank für Ihren Einkauf");
        }
    }
}





