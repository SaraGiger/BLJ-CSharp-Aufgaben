using System.ComponentModel.Design;

namespace Aufgabe_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wie viele km willst du rennen?");
            int km = Convert.ToInt32(Console.ReadLine());
            double Runde = km * 1000 / 400;

            if (km > 45) 
            {
                Console.WriteLine("Das schaffst du nicht!");

            }
            else if (km < 45)
            {
                Console.WriteLine("Das sind " + Runde + " Runden");
                Console.WriteLine("Bist du bereit diese Anzahl Runden zu rennen?");
                string ent = Console.ReadLine();

                if (ent == "Nein")
                {
                    Console.WriteLine("Okay, dann kannst du das Training vergessen.");
                }
                else if (ent == "Ja")
                {
                    int i = 1;
                    while (i < Runde)
                    {
                        Console.WriteLine("Du bist bei der " + i + " Runde");
                        i++;
                    }
                    Console.WriteLine("Du hast es geschaft!");
                }
            }
        }
    }
}
