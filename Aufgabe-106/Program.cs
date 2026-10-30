namespace Aufgabe_106
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wir spielen ein Zahlenrate Spiel!");
            Console.Write("Gib eine Zahl zwischen 1-100 an: ");
            int Zahl = Convert.ToInt32(Console.ReadLine());

            Random rnd = new Random();
            int RateZahl = rnd.Next(1, 101);


            while (Zahl != RateZahl)
            {
                if (Zahl < RateZahl)
                {
                    Console.WriteLine("Du hast zu tief geschätzt!");
                }
                else if (Zahl > RateZahl)
                {
                    Console.WriteLine("Du hast zu hoch geschätzt!");
                }
                Zahl = Convert.ToInt32(Console.ReadLine());

                if (Zahl == RateZahl)
                {
                    Console.WriteLine("Du hast es geschafft! :)");
                    Console.WriteLine("Die Gesuchte Zahl war: " + RateZahl);
                    Console.WriteLine();
                    Console.WriteLine("Willst du weiter spielen? (Ja/Nein)");
                    
                    string Wiederholung = Console.ReadLine();
                    if (Wiederholung == "Ja")
                    {
                        Console.WriteLine("Ups, Leider gerade nicht möglich- :( ");
                        Console.WriteLine("Diese Funktion muss zuerst noch programmiert werden ;)");
                    }
                    else if (Wiederholung == "Nein")
                    {
                        Console.WriteLine("Vielen Dank für das mitmachen ~Bye~");
                    }
                }
            }
        }
    }
}
