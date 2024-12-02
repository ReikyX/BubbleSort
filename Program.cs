namespace BubbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {


            BubbleSort();
            //Korrektur();
        }

        static void BubbleSort()
        {
            //Erstellen Sie ein int Array mit den Werten 4, 33, 7, 1, 23, 12 in genau dieser Reihenfolge.
            //Schreiben Sie dann einen Bubblesort um die Zahlen aufsteigend, von der kleinsten bis zur größten Zahl, zu sortieren. 
            //Lassen Sie sich zur Kontrolle dann das sortierte Array ausgeben. 
            //Keine verwendung der .Sort() Methode oder ähnlichen Methoden sind zulässig!

            int[] arrayDurcheinander = { 4, 33, 7, 1, 23, 12 };
            int arraySortierten;
            for (int i = 0; i < arrayDurcheinander.Length; i++)
            {
                for (int x = i + 1; x < arrayDurcheinander.Length; x++)
                {
                    if (arrayDurcheinander[i] > arrayDurcheinander[x])
                    {
                        arraySortierten = arrayDurcheinander[x];
                        arrayDurcheinander[x] = arrayDurcheinander[i];
                        arrayDurcheinander[i] = arraySortierten;
                    }
                }
                Console.WriteLine($"{string.Join('-', arrayDurcheinander)}"); //Veranschaulichung der Sortierung
            }
            //Console.WriteLine($"{string.Join('-', arrayDurcheinander)}");
        }
        static void Korrektur()
        {
            int[] bubbleArray = { 4, 33, 7, 1, 23, 12 };

            Console.WriteLine($"Array vor der Sortierung: {string.Join('-', bubbleArray)}");

            for (int elementIndex = 0; elementIndex < bubbleArray.Length; elementIndex++)
            {
                for (int sortierschleife = 0; sortierschleife < bubbleArray.Length - 1; sortierschleife++)
                {
                    if (bubbleArray[sortierschleife] > bubbleArray[sortierschleife + 1])
                    {
                        Console.WriteLine("Der Wert von sortierschleife ist größer");
                        int temp = bubbleArray[sortierschleife + 1];
                        bubbleArray[sortierschleife + 1] = bubbleArray[sortierschleife];
                        bubbleArray[sortierschleife] = temp;
                    }
                }
            }
            Console.WriteLine($"Array nach der Sortierung: {string.Join('-', bubbleArray)}");

        }
    }
}
