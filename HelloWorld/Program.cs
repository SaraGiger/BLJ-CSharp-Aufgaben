namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bitte gib die 1 Zahl an: ");
            int Zahl1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Bitte gib die 2 Zahl an: ");
            int Zahl2 = Convert.ToInt32(Console.ReadLine());
            int resultat = Zahl1 + Zahl2;
            Console.WriteLine("Das Resultat ist: " + resultat);
        }
    }
}
