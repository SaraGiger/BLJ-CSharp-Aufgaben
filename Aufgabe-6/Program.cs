namespace Aufgabe_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Zeile = 1;
            while (Zeile <= 10)
            {
                int Spalte = 1;
                while (Spalte <= 10)
                {
                    Console.Write(Zeile * Spalte + "\t");
                    Spalte++;
                }
                Console.WriteLine(" ");
                Zeile++;
                
                
            }
                
                

        }
    }
}
