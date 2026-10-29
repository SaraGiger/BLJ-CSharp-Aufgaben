namespace Aufgabe_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zahlen zwischen 1-30, die durch 3 und 5 Teilbar sind: ");

            int x = 1;

            while (x * 3 <= 30 || x * 5 <= 30)
            {
                if (x * 3 < x * 5)
                {
                    Console.Write("," + "\t" + x * 3);
                    if (x * 5 < (x + 1) * 3)
                    {
                        Console.Write("," + "\t" + x * 5);
                    } 
                }
                else if (x * 5 < x * 3)
                {
                    Console.Write("," + "\t" + x * 5);
                }

                x++; 
            }
        }
    }
}
