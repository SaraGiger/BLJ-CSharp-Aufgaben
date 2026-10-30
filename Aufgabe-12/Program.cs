namespace Aufgabe_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bitte geben die Zahlen zum summierenden ein (Mit Komma): ");
            string eingabe = Console.ReadLine();
            Console.WriteLine(" Vielen Dank für ihre Eingabe.");
            
            string[] Zahl = eingabe.Split(',');
            int Länge = Zahl.Length;

            int[] zahlen = new int[Länge];
            int x = 0;
            while (x < Länge)
            {
                zahlen[x] = Convert.ToInt32(Zahl[x]);
                x++;
            }
            
            int[] result = SumUp(zahlen);
            for (int i = 0; i < Länge; i++)
 
            Console.Write( " --> " + result[i]);
            
        }


        static int[] SumUp(int[] arr)
        {
            int[] result = new int[arr.Length];
            int Summe = 0;
            int j = 0;
            while (j < arr.Length)
            {
                result[j] = Summe + arr[j];
                Summe = result[j];
                j++;
            }
            return result;
        }
    }
}
