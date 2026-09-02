namespace Schaltjahr_Aufgabe_29._04._2026
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool weitermachen = true;
            string weiter;

            while (weitermachen)
            {
                Console.Write("Gib eine Jahreszahl ein: ");
                string eingabe = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(eingabe))
                {
                    Console.WriteLine("Keine Eingabe erkannt!");
                }
                else if (!int.TryParse(eingabe, out int jahr))
                {
                    Console.WriteLine("Ungültige Eingabe!");
                }
                else
                {
                    if ((jahr % 4 == 0 && jahr % 100 != 0) || (jahr % 400 == 0))
                        Console.WriteLine($"{jahr} ist ein Schaltjahr.");
                    else
                        Console.WriteLine($"{jahr} ist kein Schaltjahr.");

                }
                Console.Write("Weitere Jahreszahl ? Bitte 'ja' oder 'nein' eingeben: ");
                weiter = Console.ReadLine().Trim().ToLower();

                if (weiter == "ja" || weiter == "j")
                    continue;
                else
                    Console.WriteLine("Programm beendet.");
                break;
            }
        }
    }
}

