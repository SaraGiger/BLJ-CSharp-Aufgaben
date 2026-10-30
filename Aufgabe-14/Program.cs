namespace Aufgabe_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Schreibe ein Jahr zum Testen, ob es ein Schaltjahr ist!");

            while (true)
            {
                Console.Write("Eingabe Jahr: (Q to Quit) ");
                string Eingabe = Console.ReadLine();
                if (Eingabe == "Q") 
                {
                    Console.WriteLine("Danke für das mitmachen, ~Bye~");
                    break;
                }
                else
                {
                    int Jahr = Convert.ToInt32(Eingabe);
                    int Rechnen = Jahr % 4;
                    if (Rechnen == 0)
                    {
                        int neuRechnen = Jahr % 400;
                        if (neuRechnen == 0)
                        {
                            Console.WriteLine("Ich habe die Ausnahme Falsch gelesen, war aber Stolz genug das es sofort funktionierte ohne Fehlermeldung, darum tja ;)");
                            Console.WriteLine("Obwohl dieses Jahr theoretisch ein Schaltjahr wäre, ist es eine Ausnahme (durch 400 teilbar) und somit KEIN Schaltjahr");
                        }
                        else
                        {
                            Console.WriteLine("Dieses Jahr ist ein Schaltjahr!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Dies ist leider kein Schaltjahr");
                    }
                }
            }
        }
    }
}
