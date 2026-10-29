namespace Aufgabe_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bitte gib die erste Zahl ein: ");
            int Zahl1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Bitte gib die zweite Zahl ein: ");
            int Zahl2 = Convert.ToInt32(Console.ReadLine());
            int Summe = 0;
            int Zahl = 0;

            while (Zahl >= Zahl1 && Zahl <= Zahl2)
            {
                Summe = Summe + Zahl1 % 10;
                Zahl = Zahl / 10;
                Console.WriteLine(Summe);
                Zahl1++;
            }
            Console.WriteLine("Dies sind alle Quersummen, welche aus den Zahlen zwischen " + Zahl1 + " und " + Zahl2 + " entstehen können.");
        }
    }
}
