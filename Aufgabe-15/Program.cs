namespace Aufgabe_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Wie breit soll der Stamm sein? ");
            int SB = Convert.ToInt32(Console.ReadLine());
            Console.Write("Wie hoch soll der Stamm sein? ");
            int SH = Convert.ToInt32(Console.ReadLine());
            Console.Write("Wie hoch soll die Krone sein? ");
            int KH = Convert.ToInt32(Console.ReadLine());

            int leer = KH - 1;
            int stern = 1;
            for (int i = 0; i < KH; i++)
            {
                ZeileKrone(leer, stern);
                leer = leer - 1;
                stern = stern + 2;
            }

            int Leer = (KH - 1) - (SB/2);
            int Stern = SB;
            int anzZeilen = SH;
            for (int i = 0; i < anzZeilen; i++)
            {
                ZeileStamm(Leer, Stern);
            }

        }
        static void ZeileKrone(int anzleer, int anzstern)
        {
            for (int i = 0; i < anzleer; i++)
            {
                Console.Write(" ");
            }
            for (int i = 0; i < anzstern; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        static void ZeileStamm(int anzLeer, int anzStern)
        {
            for (int i = 0; i < anzLeer; i++)
            {
                Console.Write(" ");
            }
            for (int i = 0; i < anzStern; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            
        }



    }
}
