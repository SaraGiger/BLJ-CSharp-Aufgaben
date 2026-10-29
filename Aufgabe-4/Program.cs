using System.Collections;

namespace Aufgabe_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Gib eine Zahl zwischen 1 - 12 ein: ");
            int Monat = Convert.ToInt32(Console.ReadLine());
            switch (Monat)
            {
                case 1:
                Console.WriteLine("Das ist der Monat : Januar");
                break;
                case 2:
                Console.WriteLine("Das ist der Monat : Februar");
                break;
                case 3:
                Console.WriteLine("Das ist der Monat : März");
                break;
                case 4:
                Console.WriteLine("Das ist der Monat : April");
                break;
                case 5:
                Console.WriteLine("Das ist der Monat : Mai");
                break;
                case 6:
                Console.WriteLine("Das ist der Monat : Juni");
                break;
                case 7:
                Console.WriteLine("Das ist der Monat : Juli");
                break;
                case 8:
                Console.WriteLine("Das ist der Monat : August");
                break;
                case 9:
                Console.WriteLine("Das ist der Monat : September");
                break;
                case 10:
                Console.WriteLine("Das ist der Monat : Oktober");
                break;
                case 11:
                Console.WriteLine("Das ist der Monat : November");
                break;
                case 12:
                Console.WriteLine("Das ist der Monat : Dezember");
                break;

            }
            if (Monat > 12 || Monat < 1)
                Console.WriteLine("Die Eingabe ist ungültig");

            }
    }
}
