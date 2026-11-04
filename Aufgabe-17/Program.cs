namespace Aufgabe_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bitte gib ein paar Zahlen ein (durch Leerzeichen getrennt) ");
            string input = Console.ReadLine();

            string[] strings = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int[] numbers = new int[strings.Length];
            for (int i = 0; i < strings.Length; i++)
            {
                numbers[i] = Convert.ToInt32(strings[i]);
            }
            SortiereArray(numbers);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
        }
        private static void SortiereArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {

                for (int j = 0; j < arr.Length - 1; j++)
                {

                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }

                }
            }
        }
    }
}
   