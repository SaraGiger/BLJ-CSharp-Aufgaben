namespace Aufgabe_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wie lange soll die Linie sein?");
            int länge = Convert.ToInt32(Console.ReadLine());
            string leer = " ";
            string Stern = "*";
            int Zeile = 0;
            
            while (Zeile < länge)
            {

                int Spalte = 0;
                while (Spalte < länge)
                {
                    if (Zeile == Spalte)
                    {
                        Console.Write(leer);
                    }
                    else
                    {
                        Console.Write(Stern);
                    }
                    Spalte++;
                }
                Console.WriteLine();
                Zeile++;
            }
        }
    }
}
