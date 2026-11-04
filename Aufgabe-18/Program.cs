namespace Aufgabe_18
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Wir berechnen heute dein Alter in Jahr, Monat, Woche und Tage");
            Console.WriteLine("Bitte gib das Datum ein, von welchem aus das Alter berechnet werden soll ");
            Console.Write("Zuerst der Tag: ");
            int TagJetzt = Convert.ToInt32(Console.ReadLine());
            Console.Write("Als nächstes bitte der Monat (als Zahl): ");
            int MonatJetzt = Convert.ToInt32(Console.ReadLine());
            Console.Write("Als letztes noch das Jahr; ");
            int JahrJetzt = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Bitte gib nun das Geburtsdatum ein ");
            Console.Write("Zuerst der Tag: ");
            int TagVorher = Convert.ToInt32(Console.ReadLine());
            Console.Write("Als nächstes bitte der Monat (als Zahl): ");
            int MonatVorher = Convert.ToInt32(Console.ReadLine());
            Console.Write("Als letztes noch das Jahr; ");
            int JahrVorher = Convert.ToInt32(Console.ReadLine());

            
            if (TagJetzt < TagVorher)
            {
                TagJetzt = TagJetzt + 30;
                MonatJetzt = MonatJetzt - 1;
            }
        
            if (MonatJetzt < MonatVorher)
            {
                MonatJetzt = MonatJetzt + 12;
                JahrJetzt = JahrJetzt - 1;
            }

            int Tagrechnung = TagJetzt - TagVorher;

            int Monatrechnung = MonatJetzt - MonatVorher; 

            int Jahrrechnung = JahrJetzt - JahrVorher;

            int MonatInJahr = (Jahrrechnung * 12) + Monatrechnung;

            int TagInJahr = (Jahrrechnung * 356) + (Monatrechnung * 30) + Tagrechnung;

            Console.WriteLine("Wenn wir nur die Jahre anschauen ohne die Monate, sind sie " + Jahrrechnung + " Jahre alt.");
            Console.WriteLine("Wenn wir nur die Monate anschauen ohne extra Jahr angabe, sind sie " + MonatInJahr + " Monate alt.");
            Console.WriteLine("Wenn wir nur die Tage anschauen ohne extra Monate/Jahre, sind sie " + TagInJahr + " Tage alt.");
            Console.WriteLine("Wenn wir es also zusammenfassen ist die Person " + Jahrrechnung + " Jahre " + Monatrechnung + " Monate und " + Tagrechnung + " Tage alt.");




        }
    }
}
