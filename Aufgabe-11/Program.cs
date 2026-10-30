namespace Aufgabe_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bitte gib die erste Zahl ein: ");
            int Zahl1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Bitte gib die zweite Zahl ein: ");
            int Zahl2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.");
            while (Zahl1 <= Zahl2) 
            {
                int Summe = 0;
                int Zahl = Zahl1;
                
                while (Zahl > 0) 
                {
                    Summe = Summe + Zahl % 10;
                    Zahl = Zahl / 10;
                }

                int Modulo = Zahl1 % Summe;
                
                if (Modulo == 0)
                {
                    Console.WriteLine(Zahl1 + " , " + Summe + " , " + Zahl1/Summe);
                }
                
                Zahl1++;
                
            }
            Console.Write("-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.");



        }
    }
}
