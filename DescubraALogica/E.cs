namespace DescubraALogica
{
    public class E
    {
        public static void DiscoverTheLogic(int number)
        {
            int current = 1;
            int previous = 0;
            int next = 1;
            Console.Write("E) ");
            for (int i = 0; i <= number; i++)
            {
                Console.Write($"{current} ");

                previous = current;
                current = next;
                next = current + previous;
            }
            Console.WriteLine("\n");
        }
    }
}