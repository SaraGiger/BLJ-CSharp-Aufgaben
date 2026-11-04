using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Aufgabe_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Gib einen Text ein: ");
            string Text = Console.ReadLine();
            Text = Text.ToLower();

            int AnzA = 0, AnzE = 0, AnzI = 0, AnzO = 0, AnzU = 0, AnzÜ = 0, AnzÄ = 0, AnzÖ = 0;
           
            for (int j = 0; j < Text.Length; j++)
            {
                switch(Text[j])
                {
                    case 'a' : AnzA++; break;
                    case 'e' : AnzE++; break;
                    case 'i' : AnzI++; break;
                    case 'o' : AnzO++; break;
                    case 'u' : AnzU++; break;
                    case 'ö' : AnzÖ++; break;
                    case 'ü' : AnzÜ++; break;
                    case 'ä' : AnzÄ++; break;
                }
            }

                int Total = AnzA + AnzE + AnzI + AnzO + AnzU + AnzÜ + AnzÄ + AnzÖ;

                Console.WriteLine("Der Vokal a kommt " + AnzA + " mal vor.");
                Console.WriteLine("Der Vokal e kommt " + AnzE + " mal vor.");
                Console.WriteLine("Der Vokal i kommt " + AnzI + " mal vor.");
                Console.WriteLine("Der Vokal o kommt " + AnzO + " mal vor.");
                Console.WriteLine("Der Vokal u kommt " + AnzU + " mal vor.");
                Console.WriteLine("Der Vokal ä kommt " + AnzÄ + " mal vor.");
                Console.WriteLine("Der Vokal ü kommt " + AnzÜ + " mal vor.");
                Console.WriteLine("Der Vokal ö kommt " + AnzÖ + " mal vor.");
                Console.WriteLine();
            Console.WriteLine("Es ist ein Total von " + Total + " Vokalen in ihrem Text.");
        }
    }
}
