using System.Collections;

namespace Aufgabe_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bitte gib die Anzahl Tage von einem Monat an ");
            int AnzT = Convert.ToInt32(Console.ReadLine());
            if (AnzT <= 31)
            {
                Console.WriteLine("Ihre Zahl ist gültig");
            }
            else if (AnzT > 31)
            {
                Console.WriteLine("Es gibt nicht soviele Tage in einem Monat");

            }
            else
            {
                Console.WriteLine("Ihre Eingabe ist ungültig, bitte geben sie eine neue Zahl ein: ");
                AnzT = Convert.ToInt32(Console.ReadLine());
            }
            int AnzSek = 60 * 60 * 24;
            int Sekunden = AnzT * AnzSek;
            Console.WriteLine("Ein Monat mit " + AnzT + " hat so viele Sekunden: " +Sekunden);

        }
    }
}
