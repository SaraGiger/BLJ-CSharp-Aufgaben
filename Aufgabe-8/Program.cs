namespace Aufgabe_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte gib hier deinen Kommentar ein: ");
            string Kommentar = Console.ReadLine();
            string[] VerboteneWörter = { "Arschloch", "fick dich", "Scheisse", "****" };

            int i = 0;
            int AnzVW = 0;
            while (i < VerboteneWörter.Length)
            {
                if (Kommentar.Contains(VerboteneWörter[i]))
                {
                    
                    AnzVW++;
                }
                i++;
            }

            if (AnzVW == 0)
            {
                Console.WriteLine("Vielen Dank für ihren Kommentar");
            }
            else if(AnzVW == 1)
            {
                Console.WriteLine("Ihr Test enthält " + AnzVW + " Verbotenes Wort!");
            }
            else
            {
                Console.WriteLine("Ihr Text enthält " + AnzVW + " Verbotene Wörter!");
            }
        }
    }
}
