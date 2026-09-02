// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata;

Console.WriteLine("Hallo, heute wieder zu tief ins Glas geschaut!");
Console.WriteLine("Sollen wir es mal Testen!");

Console.WriteLine("Wieviel Liter Bier hast du getrunken: ");
double Bier = Convert.ToDouble(Console.ReadLine());

var Alkohol = Bier * 100 * 0.05 * 0.8;

Console.WriteLine("Körbergewicht: ");
double Gewicht1 = Convert.ToDouble(Console.ReadLine());

var Gewicht2 = 0.65 * Gewicht1;

var Promillewert = Alkohol / Gewicht2;

Console.WriteLine($"\nDein Promillewert: {Promillewert:F2}");

if (Promillewert <= 0.3)
{
    Console.WriteLine("Noch akzeptabel. Dennoch vorsichtig sein!");
}
else if (Promillewert <= 0.5)
{
    Console.WriteLine("Achtung! Hände weg vom Steuer!");
}
else if (Promillewert <= 0.8)
{
    Console.WriteLine("Das ist jetzt schon ganz schön ordentlich.");
}
else
{
    Console.WriteLine("Kein Kommentar...");
}

