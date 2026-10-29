namespace Aufgabe_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte gib hier deinen Kommentar ein: ");
            string Kommentar = Console.ReadLine();
            string[] VerboteneWörter = { "Arschloch", "fick dich", "Scheisse" };

            int i = 0;
            while (i < VerboteneWörter.Length)
             {
                i++;

                if (Kommentar.Contains(VerboteneWörter[i]))
                {
                    Console.WriteLine("Ihr Text enthält " + VerboteneWörter[i] + " Verbotene Wörter!");
                }

                else if (Kommentar.Contains(VerboteneWörter[i] = "0"))
                {
                    Console.WriteLine("Vielen Dank für ihren Kommentar");
                }
             }

           

        }
    }
}
