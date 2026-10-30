namespace Aufgabe_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bitte gib hier die Zahl an, um die Quersumme zu berechnen: ");
            int Zahl = Convert.ToInt32(Console.ReadLine());
            int Summe = 0;
            Console.WriteLine("-.-.-.-.-.-.-.-.-.-.");
            while (Zahl != 0)
            {
                Summe = Summe + Zahl % 10;
                Zahl = Zahl / 10;
            }
            Console.WriteLine(Summe + " |");
            Console.Write("-.-.-.-.-.-.-.-.-.-.");
        }
    }
}
