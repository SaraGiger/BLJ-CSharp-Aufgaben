namespace Aufgabe_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bitte gib die gewünschte Zahl ein: ");
            int Zahl = Convert.ToInt32(Console.ReadLine());
            string Binär = Convert.ToString(Zahl, 2);
            Console.WriteLine("Diese Zahl: " + Zahl + " sieht in Binär so aus: " + Binär);

        }
    }
}
